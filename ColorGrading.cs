public sealed class ColorGrading : PostProcessEffectSettings // TypeDefIndex: 11781
{	[DisplayNameAttribute] // RVA: 0xECC40 Offset: 0xEC040 VA: 0x1800ECC40
	[TooltipAttribute] // RVA: 0xECC40 Offset: 0xEC040 VA: 0x1800ECC40
	public GradingModeParameter gradingMode; // 0x30
	[DisplayNameAttribute] // RVA: 0xECE90 Offset: 0xEC290 VA: 0x1800ECE90
	[TooltipAttribute] // RVA: 0xECE90 Offset: 0xEC290 VA: 0x1800ECE90
	public TextureParameter externalLut; // 0x38
	[DisplayNameAttribute] // RVA: 0xECFC0 Offset: 0xEC3C0 VA: 0x1800ECFC0
	[TooltipAttribute] // RVA: 0xECFC0 Offset: 0xEC3C0 VA: 0x1800ECFC0
	public TonemapperParameter tonemapper; // 0x40
	[DisplayNameAttribute] // RVA: 0xED020 Offset: 0xEC420 VA: 0x1800ED020
	[RangeAttribute] // RVA: 0xED020 Offset: 0xEC420 VA: 0x1800ED020
	[TooltipAttribute] // RVA: 0xED020 Offset: 0xEC420 VA: 0x1800ED020
	public FloatParameter toneCurveToeStrength; // 0x48
	[DisplayNameAttribute] // RVA: 0xED3C0 Offset: 0xEC7C0 VA: 0x1800ED3C0
	[RangeAttribute] // RVA: 0xED3C0 Offset: 0xEC7C0 VA: 0x1800ED3C0
	[TooltipAttribute] // RVA: 0xED3C0 Offset: 0xEC7C0 VA: 0x1800ED3C0
	public FloatParameter toneCurveToeLength; // 0x50
	[DisplayNameAttribute] // RVA: 0xED5E0 Offset: 0xEC9E0 VA: 0x1800ED5E0
	[RangeAttribute] // RVA: 0xED5E0 Offset: 0xEC9E0 VA: 0x1800ED5E0
	[TooltipAttribute] // RVA: 0xED5E0 Offset: 0xEC9E0 VA: 0x1800ED5E0
	public FloatParameter toneCurveShoulderStrength; // 0x58
	[DisplayNameAttribute] // RVA: 0xED760 Offset: 0xECB60 VA: 0x1800ED760
	[MinAttribute] // RVA: 0xED760 Offset: 0xECB60 VA: 0x1800ED760
	[TooltipAttribute] // RVA: 0xED760 Offset: 0xECB60 VA: 0x1800ED760
	public FloatParameter toneCurveShoulderLength; // 0x60
	[DisplayNameAttribute] // RVA: 0xED9B0 Offset: 0xECDB0 VA: 0x1800ED9B0
	[RangeAttribute] // RVA: 0xED9B0 Offset: 0xECDB0 VA: 0x1800ED9B0
	[TooltipAttribute] // RVA: 0xED9B0 Offset: 0xECDB0 VA: 0x1800ED9B0
	public FloatParameter toneCurveShoulderAngle; // 0x68
	[DisplayNameAttribute] // RVA: 0xEDB90 Offset: 0xECF90 VA: 0x1800EDB90
	[MinAttribute] // RVA: 0xEDB90 Offset: 0xECF90 VA: 0x1800EDB90
	[TooltipAttribute] // RVA: 0xEDB90 Offset: 0xECF90 VA: 0x1800EDB90
	public FloatParameter toneCurveGamma; // 0x70
	[DisplayNameAttribute] // RVA: 0xEDD50 Offset: 0xED150 VA: 0x1800EDD50
	[TooltipAttribute] // RVA: 0xEDD50 Offset: 0xED150 VA: 0x1800EDD50
	public TextureParameter ldrLut; // 0x78
	[DisplayNameAttribute] // RVA: 0xEDEC0 Offset: 0xED2C0 VA: 0x1800EDEC0
	[RangeAttribute] // RVA: 0xEDEC0 Offset: 0xED2C0 VA: 0x1800EDEC0
	[TooltipAttribute] // RVA: 0xEDEC0 Offset: 0xED2C0 VA: 0x1800EDEC0
	public FloatParameter ldrLutContribution; // 0x80
	[DisplayNameAttribute] // RVA: 0xEE020 Offset: 0xED420 VA: 0x1800EE020
	[RangeAttribute] // RVA: 0xEE020 Offset: 0xED420 VA: 0x1800EE020
	[TooltipAttribute] // RVA: 0xEE020 Offset: 0xED420 VA: 0x1800EE020
	public FloatParameter temperature; // 0x88
	[DisplayNameAttribute] // RVA: 0xEE300 Offset: 0xED700 VA: 0x1800EE300
	[RangeAttribute] // RVA: 0xEE300 Offset: 0xED700 VA: 0x1800EE300
	[TooltipAttribute] // RVA: 0xEE300 Offset: 0xED700 VA: 0x1800EE300
	public FloatParameter tint; // 0x90
	[DisplayNameAttribute] // RVA: 0xEE5E0 Offset: 0xED9E0 VA: 0x1800EE5E0
	[ColorUsageAttribute] // RVA: 0xEE5E0 Offset: 0xED9E0 VA: 0x1800EE5E0
	[TooltipAttribute] // RVA: 0xEE5E0 Offset: 0xED9E0 VA: 0x1800EE5E0
	public ColorParameter colorFilter; // 0x98
	[DisplayNameAttribute] // RVA: 0xEE810 Offset: 0xEDC10 VA: 0x1800EE810
	[RangeAttribute] // RVA: 0xEE810 Offset: 0xEDC10 VA: 0x1800EE810
	[TooltipAttribute] // RVA: 0xEE810 Offset: 0xEDC10 VA: 0x1800EE810
	public FloatParameter hueShift; // 0xA0
	[DisplayNameAttribute] // RVA: 0xEEA70 Offset: 0xEDE70 VA: 0x1800EEA70
	[RangeAttribute] // RVA: 0xEEA70 Offset: 0xEDE70 VA: 0x1800EEA70
	[TooltipAttribute] // RVA: 0xEEA70 Offset: 0xEDE70 VA: 0x1800EEA70
	public FloatParameter saturation; // 0xA8
	[DisplayNameAttribute] // RVA: 0xEED00 Offset: 0xEE100 VA: 0x1800EED00
	[RangeAttribute] // RVA: 0xEED00 Offset: 0xEE100 VA: 0x1800EED00
	[TooltipAttribute] // RVA: 0xEED00 Offset: 0xEE100 VA: 0x1800EED00
	public FloatParameter brightness; // 0xB0
	[DisplayNameAttribute] // RVA: 0xEF090 Offset: 0xEE490 VA: 0x1800EF090
	[TooltipAttribute] // RVA: 0xEF090 Offset: 0xEE490 VA: 0x1800EF090
	public FloatParameter postExposure; // 0xB8
	[DisplayNameAttribute] // RVA: 0xEF280 Offset: 0xEE680 VA: 0x1800EF280
	[RangeAttribute] // RVA: 0xEF280 Offset: 0xEE680 VA: 0x1800EF280
	[TooltipAttribute] // RVA: 0xEF280 Offset: 0xEE680 VA: 0x1800EF280
	public FloatParameter contrast; // 0xC0
	[DisplayNameAttribute] // RVA: 0xEF510 Offset: 0xEE910 VA: 0x1800EF510
	[RangeAttribute] // RVA: 0xEF510 Offset: 0xEE910 VA: 0x1800EF510
	[TooltipAttribute] // RVA: 0xEF510 Offset: 0xEE910 VA: 0x1800EF510
	public FloatParameter mixerRedOutRedIn; // 0xC8
	[DisplayNameAttribute] // RVA: 0xEF9C0 Offset: 0xEEDC0 VA: 0x1800EF9C0
	[RangeAttribute] // RVA: 0xEF9C0 Offset: 0xEEDC0 VA: 0x1800EF9C0
	[TooltipAttribute] // RVA: 0xEF9C0 Offset: 0xEEDC0 VA: 0x1800EF9C0
	public FloatParameter mixerRedOutGreenIn; // 0xD0
	[DisplayNameAttribute] // RVA: 0xEFC10 Offset: 0xEF010 VA: 0x1800EFC10
	[RangeAttribute] // RVA: 0xEFC10 Offset: 0xEF010 VA: 0x1800EFC10
	[TooltipAttribute] // RVA: 0xEFC10 Offset: 0xEF010 VA: 0x1800EFC10
	public FloatParameter mixerRedOutBlueIn; // 0xD8
	[DisplayNameAttribute] // RVA: 0xEF510 Offset: 0xEE910 VA: 0x1800EF510
	[RangeAttribute] // RVA: 0xEF510 Offset: 0xEE910 VA: 0x1800EF510
	[TooltipAttribute] // RVA: 0xEF510 Offset: 0xEE910 VA: 0x1800EF510
	public FloatParameter mixerGreenOutRedIn; // 0xE0
	[DisplayNameAttribute] // RVA: 0xEF9C0 Offset: 0xEEDC0 VA: 0x1800EF9C0
	[RangeAttribute] // RVA: 0xEF9C0 Offset: 0xEEDC0 VA: 0x1800EF9C0
	[TooltipAttribute] // RVA: 0xEF9C0 Offset: 0xEEDC0 VA: 0x1800EF9C0
	public FloatParameter mixerGreenOutGreenIn; // 0xE8
	[DisplayNameAttribute] // RVA: 0xEFC10 Offset: 0xEF010 VA: 0x1800EFC10
	[RangeAttribute] // RVA: 0xEFC10 Offset: 0xEF010 VA: 0x1800EFC10
	[TooltipAttribute] // RVA: 0xEFC10 Offset: 0xEF010 VA: 0x1800EFC10
	public FloatParameter mixerGreenOutBlueIn; // 0xF0
	[DisplayNameAttribute] // RVA: 0xEF510 Offset: 0xEE910 VA: 0x1800EF510
	[RangeAttribute] // RVA: 0xEF510 Offset: 0xEE910 VA: 0x1800EF510
	[TooltipAttribute] // RVA: 0xEF510 Offset: 0xEE910 VA: 0x1800EF510
	public FloatParameter mixerBlueOutRedIn; // 0xF8
	[DisplayNameAttribute] // RVA: 0xEF9C0 Offset: 0xEEDC0 VA: 0x1800EF9C0
	[RangeAttribute] // RVA: 0xEF9C0 Offset: 0xEEDC0 VA: 0x1800EF9C0
	[TooltipAttribute] // RVA: 0xEF9C0 Offset: 0xEEDC0 VA: 0x1800EF9C0
	public FloatParameter mixerBlueOutGreenIn; // 0x100
	[DisplayNameAttribute] // RVA: 0xEFC10 Offset: 0xEF010 VA: 0x1800EFC10
	[RangeAttribute] // RVA: 0xEFC10 Offset: 0xEF010 VA: 0x1800EFC10
	[TooltipAttribute] // RVA: 0xEFC10 Offset: 0xEF010 VA: 0x1800EFC10
	public FloatParameter mixerBlueOutBlueIn; // 0x108
	[DisplayNameAttribute] // RVA: 0xF03A0 Offset: 0xEF7A0 VA: 0x1800F03A0
	[TooltipAttribute] // RVA: 0xF03A0 Offset: 0xEF7A0 VA: 0x1800F03A0
	[TrackballAttribute] // RVA: 0xF03A0 Offset: 0xEF7A0 VA: 0x1800F03A0
	public Vector4Parameter lift; // 0x110
	[DisplayNameAttribute] // RVA: 0xF05F0 Offset: 0xEF9F0 VA: 0x1800F05F0
	[TooltipAttribute] // RVA: 0xF05F0 Offset: 0xEF9F0 VA: 0x1800F05F0
	[TrackballAttribute] // RVA: 0xF05F0 Offset: 0xEF9F0 VA: 0x1800F05F0
	public Vector4Parameter gamma; // 0x118
	[DisplayNameAttribute] // RVA: 0xF0810 Offset: 0xEFC10 VA: 0x1800F0810
	[TooltipAttribute] // RVA: 0xF0810 Offset: 0xEFC10 VA: 0x1800F0810
	[TrackballAttribute] // RVA: 0xF0810 Offset: 0xEFC10 VA: 0x1800F0810
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

