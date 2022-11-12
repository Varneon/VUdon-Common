using UnityEngine;

namespace Varneon.VUdon.Common.VRCEnums
{
    /// <summary>
    /// Layers used by VRChat
    /// </summary>
    public enum VRCWorldLayers
    {
        /// <summary>
        /// - Avatar pedestal visuals
        /// </summary>
        [Tooltip("Renders:\n- Avatar pedestal visuals")]
        Default = 0,

        TransparentFX = 1,

        IgnoreRaycast = 2,

        /// <summary>
        /// <para>- Portal visuals</para>
        /// <para>- Mirrors</para>
        /// </summary>
        [Tooltip("Renders:\n- Portals\n- Mirrors")]
        Water = 4,

        /// <summary>
        /// - Personal mirror
        /// </summary>
        [Tooltip("Renders:\n- Personal mirror")]
        UI = 5,

        Interactive = 8,

        /// <summary>
        /// - Remote players
        /// </summary>
        [Tooltip("Renders:\n- Remote players")]
        Player = 9,

        /// <summary>
        /// - Local player without a head
        /// </summary>
        /// <remarks>
        /// Mirrors refuse to render this layer
        /// </remarks>
        [Tooltip("Renders:\n- Local player without a head\n\nNotes:\n- Mirrors refuse to render this layer")]
        PlayerLocal = 10,

        Environment = 11,

        /// <summary>
        /// - Nameplates
        /// </summary>
        [Tooltip("Renders:\n- Nameplates")]
        UiMenu = 12,

        /// <summary>
        /// Default pickup layer
        /// </summary>
        [Tooltip("Default pickup layer")]
        Pickup = 13,

        PickupNoEnvironment = 14,

        StereoLeft = 15,

        StereoRight = 16,

        Walkthrough = 17,

        /// <summary>
        /// - Local player
        /// </summary>
        /// <remarks>
        /// <para>Only layer that is not rendered by the main camera</para>
        /// <para>Only layer that doesn't block interaction raycasts</para>
        /// </remarks>
        [Tooltip("Renders:\n- Local player\n\nNotes:\n- Only layer that is not rendered by the main camera\n- Only layer that doesn't block interaction raycasts")]
        MirrorReflection = 18,

        /// <summary>
        /// <para>- HUD</para>
        /// <para>- Main menu</para>
        /// <para>- Camera UI</para>
        /// <para>- Camera lens</para>
        /// <para>- Tooltips</para>
        /// </summary>
        [Tooltip("Renders:\n- HUD\n- Main menu\n- Camera UI\n- Camera lens\n- Tooltips")]
        reserved2 = 19,

        reserved3 = 20,

        reserved4 = 21
    }
}
