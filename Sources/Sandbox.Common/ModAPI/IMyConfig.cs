﻿using System;
using VRage;
using VRage.Serialization;
using VRageRender;
using VRage.Utils;

namespace Sandbox.ModAPI
{
    public interface IMyConfig
    {
        MyTextureAnisoFiltering? AnisotropicFiltering { get; }
        MyAntialiasingMode? AntialiasingMode { get; }
        bool CompressSaveGames { get; }
        SerializableDictionary<string, object> ControlsButtons { get; }
        SerializableDictionary<string, object> ControlsGeneral { get; }
        bool ControlsHints { get; }
        int CubeBuilderBuildingMode { get; }
        bool CubeBuilderUseSymmetry { get; }
        SerializableDictionary<string, object> DebugInputComponents { get; }
        bool DisableHeadbob { get; }
        bool EnableDamageEffects { get; }
        float FieldOfView { get; }
        MyFoliageDetails? FoliageDetails { get; }
        float GameVolume { get; }
        bool HardwareCursor { get; }
        bool HudWarnings { get; }
        MyLanguagesEnum Language { get; }
        bool MemoryLimits { get; }
        bool MinimalHud { get; }
        bool? MultithreadedRendering { get; }
        float MusicVolume { get; }
        bool NeedShowTutorialQuestion { get; }
        int RefreshRate { get; }
        bool RenderInterpolation { get; }
        MyRenderQualityEnum? RenderQuality { get; }
        MyGraphicsRenderer GraphicsRenderer { get; }
        bool RotationHints { get; }
        int? ScreenHeight { get; }
        int? ScreenWidth { get; }
        MyShadowsQuality? ShadowQuality { get; }
        bool ShowCrosshair { get; }
        bool ShowPlayerNamesOnHud { get; }
        MyTextureQuality? TextureQuality { get; }
        bool VerticalSync { get; }
        int VideoAdapter { get; }
        MyWindowModeEnum WindowMode { get; }
    }
}
