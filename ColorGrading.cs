public sealed class ColorGrading : PostProcessEffectSettings // TypeDefIndex: 11777
{	// Fields
	[DisplayNameAttribute] // RVA: 0xED130 Offset: 0xEC530 VA: 0x1800ED130
	[TooltipAttribute] // RVA: 0xED130 Offset: 0xEC530 VA: 0x1800ED130
	public GradingModeParameter gradingMode; // 0x30
	[DisplayNameAttribute] // RVA: 0xED2F0 Offset: 0xEC6F0 VA: 0x1800ED2F0
	[TooltipAttribute] // RVA: 0xED2F0 Offset: 0xEC6F0 VA: 0x1800ED2F0
	public TextureParameter externalLut; // 0x38
	[DisplayNameAttribute] // RVA: 0xED450 Offset: 0xEC850 VA: 0x1800ED450
	[TooltipAttribute] // RVA: 0xED450 Offset: 0xEC850 VA: 0x1800ED450
	public TonemapperParameter tonemapper; // 0x40
	[DisplayNameAttribute] // RVA: 0xED560 Offset: 0xEC960 VA: 0x1800ED560
	[RangeAttribute] // RVA: 0xED560 Offset: 0xEC960 VA: 0x1800ED560
	[TooltipAttribute] // RVA: 0xED560 Offset: 0xEC960 VA: 0x1800ED560
	public FloatParameter toneCurveToeStrength; // 0x48
	[DisplayNameAttribute] // RVA: 0xED7E0 Offset: 0xECBE0 VA: 0x1800ED7E0
	[RangeAttribute] // RVA: 0xED7E0 Offset: 0xECBE0 VA: 0x1800ED7E0
	[TooltipAttribute] // RVA: 0xED7E0 Offset: 0xECBE0 VA: 0x1800ED7E0
	public FloatParameter toneCurveToeLength; // 0x50
	[DisplayNameAttribute] // RVA: 0xEDA20 Offset: 0xECE20 VA: 0x1800EDA20
	[RangeAttribute] // RVA: 0xEDA20 Offset: 0xECE20 VA: 0x1800EDA20
	[TooltipAttribute] // RVA: 0xEDA20 Offset: 0xECE20 VA: 0x1800EDA20
	public FloatParameter toneCurveShoulderStrength; // 0x58
	[DisplayNameAttribute] // RVA: 0xEDBA0 Offset: 0xECFA0 VA: 0x1800EDBA0
	[MinAttribute] // RVA: 0xEDBA0 Offset: 0xECFA0 VA: 0x1800EDBA0
	[TooltipAttribute] // RVA: 0xEDBA0 Offset: 0xECFA0 VA: 0x1800EDBA0
	public FloatParameter toneCurveShoulderLength; // 0x60
	[DisplayNameAttribute] // RVA: 0xEDD60 Offset: 0xED160 VA: 0x1800EDD60
	[RangeAttribute] // RVA: 0xEDD60 Offset: 0xED160 VA: 0x1800EDD60
	[TooltipAttribute] // RVA: 0xEDD60 Offset: 0xED160 VA: 0x1800EDD60
	public FloatParameter toneCurveShoulderAngle; // 0x68
	[DisplayNameAttribute] // RVA: 0xEDEB0 Offset: 0xED2B0 VA: 0x1800EDEB0
	[MinAttribute] // RVA: 0xEDEB0 Offset: 0xED2B0 VA: 0x1800EDEB0
	[TooltipAttribute] // RVA: 0xEDEB0 Offset: 0xED2B0 VA: 0x1800EDEB0
	public FloatParameter toneCurveGamma; // 0x70
	[DisplayNameAttribute] // RVA: 0xEE140 Offset: 0xED540 VA: 0x1800EE140
	[TooltipAttribute] // RVA: 0xEE140 Offset: 0xED540 VA: 0x1800EE140
	public TextureParameter ldrLut; // 0x78
	[DisplayNameAttribute] // RVA: 0xEE460 Offset: 0xED860 VA: 0x1800EE460
	[RangeAttribute] // RVA: 0xEE460 Offset: 0xED860 VA: 0x1800EE460
	[TooltipAttribute] // RVA: 0xEE460 Offset: 0xED860 VA: 0x1800EE460
	public FloatParameter ldrLutContribution; // 0x80
	[DisplayNameAttribute] // RVA: 0xEE6D0 Offset: 0xEDAD0 VA: 0x1800EE6D0
	[RangeAttribute] // RVA: 0xEE6D0 Offset: 0xEDAD0 VA: 0x1800EE6D0
	[TooltipAttribute] // RVA: 0xEE6D0 Offset: 0xEDAD0 VA: 0x1800EE6D0
	public FloatParameter temperature; // 0x88
	[DisplayNameAttribute] // RVA: 0xEE870 Offset: 0xEDC70 VA: 0x1800EE870
	[RangeAttribute] // RVA: 0xEE870 Offset: 0xEDC70 VA: 0x1800EE870
	[TooltipAttribute] // RVA: 0xEE870 Offset: 0xEDC70 VA: 0x1800EE870
	public FloatParameter tint; // 0x90
	[DisplayNameAttribute] // RVA: 0xEEAA0 Offset: 0xEDEA0 VA: 0x1800EEAA0
	[ColorUsageAttribute] // RVA: 0xEEAA0 Offset: 0xEDEA0 VA: 0x1800EEAA0
	[TooltipAttribute] // RVA: 0xEEAA0 Offset: 0xEDEA0 VA: 0x1800EEAA0
	public ColorParameter colorFilter; // 0x98
	[DisplayNameAttribute] // RVA: 0xEEDC0 Offset: 0xEE1C0 VA: 0x1800EEDC0
	[RangeAttribute] // RVA: 0xEEDC0 Offset: 0xEE1C0 VA: 0x1800EEDC0
	[TooltipAttribute] // RVA: 0xEEDC0 Offset: 0xEE1C0 VA: 0x1800EEDC0
	public FloatParameter hueShift; // 0xA0
	[DisplayNameAttribute] // RVA: 0xEF0A0 Offset: 0xEE4A0 VA: 0x1800EF0A0
	[RangeAttribute] // RVA: 0xEF0A0 Offset: 0xEE4A0 VA: 0x1800EF0A0
	[TooltipAttribute] // RVA: 0xEF0A0 Offset: 0xEE4A0 VA: 0x1800EF0A0
	public FloatParameter saturation; // 0xA8
	[DisplayNameAttribute] // RVA: 0xEF370 Offset: 0xEE770 VA: 0x1800EF370
	[RangeAttribute] // RVA: 0xEF370 Offset: 0xEE770 VA: 0x1800EF370
	[TooltipAttribute] // RVA: 0xEF370 Offset: 0xEE770 VA: 0x1800EF370
	public FloatParameter brightness; // 0xB0
	[DisplayNameAttribute] // RVA: 0xEF760 Offset: 0xEEB60 VA: 0x1800EF760
	[TooltipAttribute] // RVA: 0xEF760 Offset: 0xEEB60 VA: 0x1800EF760
	public FloatParameter postExposure; // 0xB8
	[DisplayNameAttribute] // RVA: 0xEF9B0 Offset: 0xEEDB0 VA: 0x1800EF9B0
	[RangeAttribute] // RVA: 0xEF9B0 Offset: 0xEEDB0 VA: 0x1800EF9B0
	[TooltipAttribute] // RVA: 0xEF9B0 Offset: 0xEEDB0 VA: 0x1800EF9B0
	public FloatParameter contrast; // 0xC0
	[DisplayNameAttribute] // RVA: 0xEFC40 Offset: 0xEF040 VA: 0x1800EFC40
	[RangeAttribute] // RVA: 0xEFC40 Offset: 0xEF040 VA: 0x1800EFC40
	[TooltipAttribute] // RVA: 0xEFC40 Offset: 0xEF040 VA: 0x1800EFC40
	public FloatParameter mixerRedOutRedIn; // 0xC8
	[DisplayNameAttribute] // RVA: 0xEFDB0 Offset: 0xEF1B0 VA: 0x1800EFDB0
	[RangeAttribute] // RVA: 0xEFDB0 Offset: 0xEF1B0 VA: 0x1800EFDB0
	[TooltipAttribute] // RVA: 0xEFDB0 Offset: 0xEF1B0 VA: 0x1800EFDB0
	public FloatParameter mixerRedOutGreenIn; // 0xD0
	[DisplayNameAttribute] // RVA: 0xEFED0 Offset: 0xEF2D0 VA: 0x1800EFED0
	[RangeAttribute] // RVA: 0xEFED0 Offset: 0xEF2D0 VA: 0x1800EFED0
	[TooltipAttribute] // RVA: 0xEFED0 Offset: 0xEF2D0 VA: 0x1800EFED0
	public FloatParameter mixerRedOutBlueIn; // 0xD8
	[DisplayNameAttribute] // RVA: 0xEFC40 Offset: 0xEF040 VA: 0x1800EFC40
	[RangeAttribute] // RVA: 0xEFC40 Offset: 0xEF040 VA: 0x1800EFC40
	[TooltipAttribute] // RVA: 0xEFC40 Offset: 0xEF040 VA: 0x1800EFC40
	public FloatParameter mixerGreenOutRedIn; // 0xE0
	[DisplayNameAttribute] // RVA: 0xEFDB0 Offset: 0xEF1B0 VA: 0x1800EFDB0
	[RangeAttribute] // RVA: 0xEFDB0 Offset: 0xEF1B0 VA: 0x1800EFDB0
	[TooltipAttribute] // RVA: 0xEFDB0 Offset: 0xEF1B0 VA: 0x1800EFDB0
	public FloatParameter mixerGreenOutGreenIn; // 0xE8
	[DisplayNameAttribute] // RVA: 0xEFED0 Offset: 0xEF2D0 VA: 0x1800EFED0
	[RangeAttribute] // RVA: 0xEFED0 Offset: 0xEF2D0 VA: 0x1800EFED0
	[TooltipAttribute] // RVA: 0xEFED0 Offset: 0xEF2D0 VA: 0x1800EFED0
	public FloatParameter mixerGreenOutBlueIn; // 0xF0
	[DisplayNameAttribute] // RVA: 0xEFC40 Offset: 0xEF040 VA: 0x1800EFC40
	[RangeAttribute] // RVA: 0xEFC40 Offset: 0xEF040 VA: 0x1800EFC40
	[TooltipAttribute] // RVA: 0xEFC40 Offset: 0xEF040 VA: 0x1800EFC40
	public FloatParameter mixerBlueOutRedIn; // 0xF8
	[DisplayNameAttribute] // RVA: 0xEFDB0 Offset: 0xEF1B0 VA: 0x1800EFDB0
	[RangeAttribute] // RVA: 0xEFDB0 Offset: 0xEF1B0 VA: 0x1800EFDB0
	[TooltipAttribute] // RVA: 0xEFDB0 Offset: 0xEF1B0 VA: 0x1800EFDB0
	public FloatParameter mixerBlueOutGreenIn; // 0x100
	[DisplayNameAttribute] // RVA: 0xEFED0 Offset: 0xEF2D0 VA: 0x1800EFED0
	[RangeAttribute] // RVA: 0xEFED0 Offset: 0xEF2D0 VA: 0x1800EFED0
	[TooltipAttribute] // RVA: 0xEFED0 Offset: 0xEF2D0 VA: 0x1800EFED0
	public FloatParameter mixerBlueOutBlueIn; // 0x108
	[DisplayNameAttribute] // RVA: 0xF0890 Offset: 0xEFC90 VA: 0x1800F0890
	[TooltipAttribute] // RVA: 0xF0890 Offset: 0xEFC90 VA: 0x1800F0890
	[TrackballAttribute] // RVA: 0xF0890 Offset: 0xEFC90 VA: 0x1800F0890
	public Vector4Parameter lift; // 0x110
	[DisplayNameAttribute] // RVA: 0xF0B80 Offset: 0xEFF80 VA: 0x1800F0B80
	[TooltipAttribute] // RVA: 0xF0B80 Offset: 0xEFF80 VA: 0x1800F0B80
	[TrackballAttribute] // RVA: 0xF0B80 Offset: 0xEFF80 VA: 0x1800F0B80
	public Vector4Parameter gamma; // 0x118
	[DisplayNameAttribute] // RVA: 0xF0EC0 Offset: 0xF02C0 VA: 0x1800F0EC0
	[TooltipAttribute] // RVA: 0xF0EC0 Offset: 0xF02C0 VA: 0x1800F0EC0
	[TrackballAttribute] // RVA: 0xF0EC0 Offset: 0xF02C0 VA: 0x1800F0EC0
	public Vector4Parameter gain; // 0x120
	public SplineParameter masterCurve; // 0x128
	public SplineParameter redCurve; // 0x130
	public SplineParameter greenCurve; // 0x138
	public SplineParameter blueCurve; // 0x140
	public SplineParameter hueVsHueCurve; // 0x148
	public SplineParameter hueVsSatCurve; // 0x150
	public SplineParameter satVsSatCurve; // 0x158
	public SplineParameter lumVsSatCurve; // 0x160

	// Methods

	// RVA: 0x9F6920 Offset: 0x9F4F20 VA: 0x1809F6920 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x9F6970 Offset: 0x9F4F70 VA: 0x1809F6970
	public void .ctor() { }

}

