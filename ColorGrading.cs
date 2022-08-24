public sealed class ColorGrading : PostProcessEffectSettings // TypeDefIndex: 11781
{	[DisplayNameAttribute] // RVA: 0xED3C0 Offset: 0xEC7C0 VA: 0x1800ED3C0
	[TooltipAttribute] // RVA: 0xED3C0 Offset: 0xEC7C0 VA: 0x1800ED3C0
	public GradingModeParameter gradingMode; // 0x30
	[DisplayNameAttribute] // RVA: 0xED520 Offset: 0xEC920 VA: 0x1800ED520
	[TooltipAttribute] // RVA: 0xED520 Offset: 0xEC920 VA: 0x1800ED520
	public TextureParameter externalLut; // 0x38
	[DisplayNameAttribute] // RVA: 0xED630 Offset: 0xECA30 VA: 0x1800ED630
	[TooltipAttribute] // RVA: 0xED630 Offset: 0xECA30 VA: 0x1800ED630
	public TonemapperParameter tonemapper; // 0x40
	[DisplayNameAttribute] // RVA: 0xED770 Offset: 0xECB70 VA: 0x1800ED770
	[RangeAttribute] // RVA: 0xED770 Offset: 0xECB70 VA: 0x1800ED770
	[TooltipAttribute] // RVA: 0xED770 Offset: 0xECB70 VA: 0x1800ED770
	public FloatParameter toneCurveToeStrength; // 0x48
	[DisplayNameAttribute] // RVA: 0xED9A0 Offset: 0xECDA0 VA: 0x1800ED9A0
	[RangeAttribute] // RVA: 0xED9A0 Offset: 0xECDA0 VA: 0x1800ED9A0
	[TooltipAttribute] // RVA: 0xED9A0 Offset: 0xECDA0 VA: 0x1800ED9A0
	public FloatParameter toneCurveToeLength; // 0x50
	[DisplayNameAttribute] // RVA: 0xEDC50 Offset: 0xED050 VA: 0x1800EDC50
	[RangeAttribute] // RVA: 0xEDC50 Offset: 0xED050 VA: 0x1800EDC50
	[TooltipAttribute] // RVA: 0xEDC50 Offset: 0xED050 VA: 0x1800EDC50
	public FloatParameter toneCurveShoulderStrength; // 0x58
	[DisplayNameAttribute] // RVA: 0xEDDC0 Offset: 0xED1C0 VA: 0x1800EDDC0
	[MinAttribute] // RVA: 0xEDDC0 Offset: 0xED1C0 VA: 0x1800EDDC0
	[TooltipAttribute] // RVA: 0xEDDC0 Offset: 0xED1C0 VA: 0x1800EDDC0
	public FloatParameter toneCurveShoulderLength; // 0x60
	[DisplayNameAttribute] // RVA: 0xEDF10 Offset: 0xED310 VA: 0x1800EDF10
	[RangeAttribute] // RVA: 0xEDF10 Offset: 0xED310 VA: 0x1800EDF10
	[TooltipAttribute] // RVA: 0xEDF10 Offset: 0xED310 VA: 0x1800EDF10
	public FloatParameter toneCurveShoulderAngle; // 0x68
	[DisplayNameAttribute] // RVA: 0xEE1F0 Offset: 0xED5F0 VA: 0x1800EE1F0
	[MinAttribute] // RVA: 0xEE1F0 Offset: 0xED5F0 VA: 0x1800EE1F0
	[TooltipAttribute] // RVA: 0xEE1F0 Offset: 0xED5F0 VA: 0x1800EE1F0
	public FloatParameter toneCurveGamma; // 0x70
	[DisplayNameAttribute] // RVA: 0xEE5F0 Offset: 0xED9F0 VA: 0x1800EE5F0
	[TooltipAttribute] // RVA: 0xEE5F0 Offset: 0xED9F0 VA: 0x1800EE5F0
	public TextureParameter ldrLut; // 0x78
	[DisplayNameAttribute] // RVA: 0xEE750 Offset: 0xEDB50 VA: 0x1800EE750
	[RangeAttribute] // RVA: 0xEE750 Offset: 0xEDB50 VA: 0x1800EE750
	[TooltipAttribute] // RVA: 0xEE750 Offset: 0xEDB50 VA: 0x1800EE750
	public FloatParameter ldrLutContribution; // 0x80
	[DisplayNameAttribute] // RVA: 0xEE920 Offset: 0xEDD20 VA: 0x1800EE920
	[RangeAttribute] // RVA: 0xEE920 Offset: 0xEDD20 VA: 0x1800EE920
	[TooltipAttribute] // RVA: 0xEE920 Offset: 0xEDD20 VA: 0x1800EE920
	public FloatParameter temperature; // 0x88
	[DisplayNameAttribute] // RVA: 0xEEB50 Offset: 0xEDF50 VA: 0x1800EEB50
	[RangeAttribute] // RVA: 0xEEB50 Offset: 0xEDF50 VA: 0x1800EEB50
	[TooltipAttribute] // RVA: 0xEEB50 Offset: 0xEDF50 VA: 0x1800EEB50
	public FloatParameter tint; // 0x90
	[DisplayNameAttribute] // RVA: 0xEEE80 Offset: 0xEE280 VA: 0x1800EEE80
	[ColorUsageAttribute] // RVA: 0xEEE80 Offset: 0xEE280 VA: 0x1800EEE80
	[TooltipAttribute] // RVA: 0xEEE80 Offset: 0xEE280 VA: 0x1800EEE80
	public ColorParameter colorFilter; // 0x98
	[DisplayNameAttribute] // RVA: 0xEF0C0 Offset: 0xEE4C0 VA: 0x1800EF0C0
	[RangeAttribute] // RVA: 0xEF0C0 Offset: 0xEE4C0 VA: 0x1800EF0C0
	[TooltipAttribute] // RVA: 0xEF0C0 Offset: 0xEE4C0 VA: 0x1800EF0C0
	public FloatParameter hueShift; // 0xA0
	[DisplayNameAttribute] // RVA: 0xEF3C0 Offset: 0xEE7C0 VA: 0x1800EF3C0
	[RangeAttribute] // RVA: 0xEF3C0 Offset: 0xEE7C0 VA: 0x1800EF3C0
	[TooltipAttribute] // RVA: 0xEF3C0 Offset: 0xEE7C0 VA: 0x1800EF3C0
	public FloatParameter saturation; // 0xA8
	[DisplayNameAttribute] // RVA: 0xEF7B0 Offset: 0xEEBB0 VA: 0x1800EF7B0
	[RangeAttribute] // RVA: 0xEF7B0 Offset: 0xEEBB0 VA: 0x1800EF7B0
	[TooltipAttribute] // RVA: 0xEF7B0 Offset: 0xEEBB0 VA: 0x1800EF7B0
	public FloatParameter brightness; // 0xB0
	[DisplayNameAttribute] // RVA: 0xEFA70 Offset: 0xEEE70 VA: 0x1800EFA70
	[TooltipAttribute] // RVA: 0xEFA70 Offset: 0xEEE70 VA: 0x1800EFA70
	public FloatParameter postExposure; // 0xB8
	[DisplayNameAttribute] // RVA: 0xEFC90 Offset: 0xEF090 VA: 0x1800EFC90
	[RangeAttribute] // RVA: 0xEFC90 Offset: 0xEF090 VA: 0x1800EFC90
	[TooltipAttribute] // RVA: 0xEFC90 Offset: 0xEF090 VA: 0x1800EFC90
	public FloatParameter contrast; // 0xC0
	[DisplayNameAttribute] // RVA: 0xEFE20 Offset: 0xEF220 VA: 0x1800EFE20
	[RangeAttribute] // RVA: 0xEFE20 Offset: 0xEF220 VA: 0x1800EFE20
	[TooltipAttribute] // RVA: 0xEFE20 Offset: 0xEF220 VA: 0x1800EFE20
	public FloatParameter mixerRedOutRedIn; // 0xC8
	[DisplayNameAttribute] // RVA: 0xEFF40 Offset: 0xEF340 VA: 0x1800EFF40
	[RangeAttribute] // RVA: 0xEFF40 Offset: 0xEF340 VA: 0x1800EFF40
	[TooltipAttribute] // RVA: 0xEFF40 Offset: 0xEF340 VA: 0x1800EFF40
	public FloatParameter mixerRedOutGreenIn; // 0xD0
	[DisplayNameAttribute] // RVA: 0xF0160 Offset: 0xEF560 VA: 0x1800F0160
	[RangeAttribute] // RVA: 0xF0160 Offset: 0xEF560 VA: 0x1800F0160
	[TooltipAttribute] // RVA: 0xF0160 Offset: 0xEF560 VA: 0x1800F0160
	public FloatParameter mixerRedOutBlueIn; // 0xD8
	[DisplayNameAttribute] // RVA: 0xEFE20 Offset: 0xEF220 VA: 0x1800EFE20
	[RangeAttribute] // RVA: 0xEFE20 Offset: 0xEF220 VA: 0x1800EFE20
	[TooltipAttribute] // RVA: 0xEFE20 Offset: 0xEF220 VA: 0x1800EFE20
	public FloatParameter mixerGreenOutRedIn; // 0xE0
	[DisplayNameAttribute] // RVA: 0xEFF40 Offset: 0xEF340 VA: 0x1800EFF40
	[RangeAttribute] // RVA: 0xEFF40 Offset: 0xEF340 VA: 0x1800EFF40
	[TooltipAttribute] // RVA: 0xEFF40 Offset: 0xEF340 VA: 0x1800EFF40
	public FloatParameter mixerGreenOutGreenIn; // 0xE8
	[DisplayNameAttribute] // RVA: 0xF0160 Offset: 0xEF560 VA: 0x1800F0160
	[RangeAttribute] // RVA: 0xF0160 Offset: 0xEF560 VA: 0x1800F0160
	[TooltipAttribute] // RVA: 0xF0160 Offset: 0xEF560 VA: 0x1800F0160
	public FloatParameter mixerGreenOutBlueIn; // 0xF0
	[DisplayNameAttribute] // RVA: 0xEFE20 Offset: 0xEF220 VA: 0x1800EFE20
	[RangeAttribute] // RVA: 0xEFE20 Offset: 0xEF220 VA: 0x1800EFE20
	[TooltipAttribute] // RVA: 0xEFE20 Offset: 0xEF220 VA: 0x1800EFE20
	public FloatParameter mixerBlueOutRedIn; // 0xF8
	[DisplayNameAttribute] // RVA: 0xEFF40 Offset: 0xEF340 VA: 0x1800EFF40
	[RangeAttribute] // RVA: 0xEFF40 Offset: 0xEF340 VA: 0x1800EFF40
	[TooltipAttribute] // RVA: 0xEFF40 Offset: 0xEF340 VA: 0x1800EFF40
	public FloatParameter mixerBlueOutGreenIn; // 0x100
	[DisplayNameAttribute] // RVA: 0xF0160 Offset: 0xEF560 VA: 0x1800F0160
	[RangeAttribute] // RVA: 0xF0160 Offset: 0xEF560 VA: 0x1800F0160
	[TooltipAttribute] // RVA: 0xF0160 Offset: 0xEF560 VA: 0x1800F0160
	public FloatParameter mixerBlueOutBlueIn; // 0x108
	[DisplayNameAttribute] // RVA: 0xF0BC0 Offset: 0xEFFC0 VA: 0x1800F0BC0
	[TooltipAttribute] // RVA: 0xF0BC0 Offset: 0xEFFC0 VA: 0x1800F0BC0
	[TrackballAttribute] // RVA: 0xF0BC0 Offset: 0xEFFC0 VA: 0x1800F0BC0
	public Vector4Parameter lift; // 0x110
	[DisplayNameAttribute] // RVA: 0xF0F80 Offset: 0xF0380 VA: 0x1800F0F80
	[TooltipAttribute] // RVA: 0xF0F80 Offset: 0xF0380 VA: 0x1800F0F80
	[TrackballAttribute] // RVA: 0xF0F80 Offset: 0xF0380 VA: 0x1800F0F80
	public Vector4Parameter gamma; // 0x118
	[DisplayNameAttribute] // RVA: 0x6F550 Offset: 0x6E950 VA: 0x18006F550
	[TooltipAttribute] // RVA: 0x6F550 Offset: 0x6E950 VA: 0x18006F550
	[TrackballAttribute] // RVA: 0x6F550 Offset: 0x6E950 VA: 0x18006F550
	public Vector4Parameter gain; // 0x120
	public SplineParameter masterCurve; // 0x128
	public SplineParameter redCurve; // 0x130
	public SplineParameter greenCurve; // 0x138
	public SplineParameter blueCurve; // 0x140
	public SplineParameter hueVsHueCurve; // 0x148
	public SplineParameter hueVsSatCurve; // 0x150
	public SplineParameter satVsSatCurve; // 0x158
	public SplineParameter lumVsSatCurve; // 0x160


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

