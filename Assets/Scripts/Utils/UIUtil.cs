using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UI;

/****************************************************
    文件：UIUtil.cs
    作者：tg
    邮箱: 18178367954@139.com
    日期：#CreateTime#
    功能：Ui工具类
*****************************************************/
public static class UIUtil 
{
    private static RectTransform s_uiRoot = null;
    public static RectTransform uiRoot
    {
        get
        {
            if (s_uiRoot == null)
            {
                var go = GameObject.Find("UIRoot");
                if (go == null)
                {
                    Debug.LogError("Can't find UI Root.");
                    return null;
                }
                s_uiRoot = go.GetComponent<RectTransform>();
            }
            return s_uiRoot;
        }
    }
    private static CanvasScaler s_canvasScaler = null;
    public static CanvasScaler canvasScaler
    {
        get
        {
            if (s_canvasScaler != null)
                return s_canvasScaler;
            if (uiRoot == null)
                return null;
            s_canvasScaler = uiRoot.GetComponent<CanvasScaler>();
            return s_canvasScaler;
        }
    }

    public static float defaultWidth { get { return canvasScaler == null ? 1024 : canvasScaler.referenceResolution.x; } }
    public static float defaultHeight { get { return canvasScaler == null ? 768 : canvasScaler.referenceResolution.y; } }
    public static float defaultAspect { get { return defaultWidth / defaultHeight; } }
    public static float width { get { return aspect > defaultAspect ? defaultWidth * aspect / defaultAspect : defaultWidth; } }
    public static float height { get { return 1 / aspect * width; } }
    public static float aspect { get { return (float)Screen.width / Screen.height; } }
    public static Vector2 center { get { return size * 0.5f; } }
    public static Vector2 size { get { return new Vector2(width, height); } }
    private static float sRealToVirtualRate { get { return width / Screen.width; } }

    public static float FormatToVirtual(float value)
    {
        return sRealToVirtualRate * value;
    }
    public static Vector2 UIWorldToUIPos(Vector3 worldPos)
    {
        if (s_uiRoot == null)
            return Vector2.zero;
        Vector2 uiPos = worldPos / s_uiRoot.localScale.x;
        return uiPos + center;
    }

    public static Vector2 GetUIPos(Transform uiTransform)
    {
        return UIWorldToUIPos(uiTransform.position);
    }

    public static void SetText(Text uiText, string content)
    {
        uiText.text = content;
    }
}
