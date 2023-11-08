using UnityEngine;

namespace Varneon.VUdon.Common.VRCEnums
{
    /// <summary>
    /// Unity Layers used by VRChat
    /// <para>Layers 0-7 are 'Builtin' Unity layers.</para>
    /// <para>Layers 3, 6, and 7 are internal Unity layers.They cannot be used.</para>
    /// <para>Layers 8-21 are 'User' Unity layers managed by VRChat's SDK.</para>
    /// <para>Layers 22-31 are unused 'User' Unity layers. You can edit them freely, and changes to these layers will not be discarded when you build and upload your world.</para>
    /// <see href="https://creators.vrchat.com/worlds/layers"/>
    /// </summary>
    public enum VRCWorldLayers
    {
        /// <summary>
        /// Default layer for all Unity's GameObjects
        /// <para>- Avatar pedestal visuals</para>
        /// </summary>
        [Tooltip("Default layer for all Unity's GameObjects\n\nRenders:\n- VRChat Avatar Pedestal visuals")]
        Default = 0,

        /// <summary>
        /// Used for Unity's Flare Assets
        /// </summary>
        [Tooltip("Used for Unity's Flare Assets")]
        TransparentFX = 1,

        /// <summary>
        /// Ignored by Unity's Physics Raycasts if no layer mask is provided. Not ignored by VRChat's Physics Raycasts
        /// </summary>
        [Tooltip("Ignored by Unity's Physics Raycasts if no layer mask is provided. Not ignored by VRChat's Physics Raycasts")]
        IgnoreRaycast = 2,

        /// <summary>
        /// <para>- VRChat Portals</para>
        /// <para>- VRChat Mirrors</para>
        /// </summary>
        [Tooltip("Renders:\n- VRChat Portals\n- VRChat Mirrors")]
        Water = 4,

        /// <summary>
        /// - VRChat Personal mirror
        /// </summary>
        /// <remarks>
        /// All interactive objects in this layer will not be interactable unless the VRChat menu is open
        /// </remarks>
        [Tooltip("Renders:\n- VRChat Personal mirror\n\nNotes:\n- All interactive objects in this layer will not be interactable unless the VRChat menu is open")]
        UI = 5,

        /// <summary>
        /// Unused by Unity and VRChat
        /// </summary>
        [Tooltip("Unused by Unity and VRChat")]
        Interactive = 8,

        /// <summary>
        /// - Remote VRChat players
        /// </summary>
        [Tooltip("Renders:\n- Remote VRChat players")]
        Player = 9,

        /// <summary>
        /// - Local VRChat player without a head
        /// </summary>
        /// <remarks>
        /// Mirrors refuse to render this layer
        /// </remarks>
        [Tooltip("Renders:\n- Local VRChat player without a head\n\nNotes:\n- Mirrors refuse to render this layer")]
        PlayerLocal = 10,

        /// <summary>
        /// Unused by Unity and VRChat
        /// </summary>
        [Tooltip("Unused by Unity and VRChat")]
        Environment = 11,

        /// <summary>
        /// - VRChat Nameplates
        /// </summary>
        [Tooltip("Renders:\n- VRChat Nameplates")]
        UiMenu = 12,

        /// <summary>
        /// Default pickup layer for VRChat Pickups
        /// </summary>
        /// <remarks>
        /// Does not collide with players
        /// </remarks>
        [Tooltip("Default pickup layer for VRChat Pickups\n\nDoes not collide with players")]
        Pickup = 13,

        /// <summary>
        /// Colliders on this layer only collide with the 'Pickup' layer
        /// </summary>
        [Tooltip("Colliders on this layer only collide with the 'Pickup' layer")]
        PickupNoEnvironment = 14,

        /// <summary>
        /// Unused by Unity and VRChat
        /// </summary>
        [Tooltip("Unused by Unity and VRChat")]
        StereoLeft = 15,

        /// <summary>
        /// Unused by Unity and VRChat
        /// </summary>
        [Tooltip("Unused by Unity and VRChat")]
        StereoRight = 16,

        /// <summary>
        /// Colliders on this layer won't collide with players
        /// </summary>
        [Tooltip("Colliders on this layer won't collide with players")]
        Walkthrough = 17,

        /// <summary>
        /// - Local player
        /// </summary>
        /// <remarks>
        /// <para>Only layer that is not rendered by the main camera</para>
        /// <para>Colliders on this layer don't block VRChat's raycasts by default</para>
        /// </remarks>
        [Tooltip("Renders:\n- Local player\n\nNotes:\n- Only layer that is not rendered by the main camera\n- Colliders on this layer don't block VRChat's raycasts by default")]
        MirrorReflection = 18,

        /// <summary>
        /// <para>- HUD</para>
        /// <para>- Main menu</para>
        /// <para>- Camera UI</para>
        /// <para>- Camera lens</para>
        /// <para>- Tooltips</para>
        /// </summary>
        /// <remarks>
        /// Any GameObject on this layer will automatically be changed to Layer 0 (Default) on upload
        /// </remarks>
        [Tooltip("Renders:\n- HUD\n- Main menu\n- Camera UI\n- Camera lens\n- Tooltips\n\nNotes:\n- Any GameObject on this layer will automatically be changed to Layer 0 (Default) on upload")]
        reserved2 = 19,

        /// <summary>
        /// Reserved for use in the future by VRChat
        /// </summary>
        /// <remarks>
        /// Any GameObject on this layer will automatically be changed to Layer 0 (Default) on upload
        /// </remarks>
        [Tooltip("Reserved for use in the future by VRChat\n\nNotes:\n- Any GameObject on this layer will automatically be changed to Layer 0 (Default) on upload")]
        reserved3 = 20,

        /// <summary>
        /// Reserved for use in the future by VRChat
        /// </summary>
        /// <remarks>
        /// Any GameObject on this layer will automatically be changed to Layer 0 (Default) on upload
        /// </remarks>
        [Tooltip("Reserved for use in the future by VRChat\n\nNotes:\n- Any GameObject on this layer will automatically be changed to Layer 0 (Default) on upload")]
        reserved4 = 21
    }
}
