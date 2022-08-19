public sealed class ColorGrading : PostProcessEffectSettings // TypeDefIndex: 11777
{	// Fields
	[DisplayNameAttribute] // RVA: 0xECF00 Offset: 0xEC300 VA: 0x1800ECF00
	[TooltipAttribute] // RVA: 0xECF00 Offset: 0xEC300 VA: 0x1800ECF00
	public GradingModeParameter gradingMode; // 0x30
	[DisplayNameAttribute] // RVA: 0xED1C0 Offset: 0xEC5C0 VA: 0x1800ED1C0
	[TooltipAttribute] // RVA: 0xED1C0 Offset: 0xEC5C0 VA: 0x1800ED1C0
	public TextureParameter externalLut; // 0x38
	[DisplayNameAttribute] // RVA: 0xED3B0 Offset: 0xEC7B0 VA: 0x1800ED3B0
	[TooltipAttribute] // RVA: 0xED3B0 Offset: 0xEC7B0 VA: 0x1800ED3B0
	public TonemapperParameter tonemapper; // 0x40
	[DisplayNameAttribute] // RVA: 0xED4E0 Offset: 0xEC8E0 VA: 0x1800ED4E0
	[RangeAttribute] // RVA: 0xED4E0 Offset: 0xEC8E0 VA: 0x1800ED4E0
	[TooltipAttribute] // RVA: 0xED4E0 Offset: 0xEC8E0 VA: 0x1800ED4E0
	public FloatParameter toneCurveToeStrength; // 0x48
	[DisplayNameAttribute] // RVA: 0xED630 Offset: 0xECA30 VA: 0x1800ED630
	[RangeAttribute] // RVA: 0xED630 Offset: 0xECA30 VA: 0x1800ED630
	[TooltipAttribute] // RVA: 0xED630 Offset: 0xECA30 VA: 0x1800ED630
	public FloatParameter toneCurveToeLength; // 0x50
	[DisplayNameAttribute] // RVA: 0xED900 Offset: 0xECD00 VA: 0x1800ED900
	[RangeAttribute] // RVA: 0xED900 Offset: 0xECD00 VA: 0x1800ED900
	[TooltipAttribute] // RVA: 0xED900 Offset: 0xECD00 VA: 0x1800ED900
	public FloatParameter toneCurveShoulderStrength; // 0x58
	[DisplayNameAttribute] // RVA: 0xEDA90 Offset: 0xECE90 VA: 0x1800EDA90
	[MinAttribute] // RVA: 0xEDA90 Offset: 0xECE90 VA: 0x1800EDA90
	[TooltipAttribute] // RVA: 0xEDA90 Offset: 0xECE90 VA: 0x1800EDA90
	public FloatParameter toneCurveShoulderLength; // 0x60
	[DisplayNameAttribute] // RVA: 0xEDCB0 Offset: 0xED0B0 VA: 0x1800EDCB0
	[RangeAttribute] // RVA: 0xEDCB0 Offset: 0xED0B0 VA: 0x1800EDCB0
	[TooltipAttribute] // RVA: 0xEDCB0 Offset: 0xED0B0 VA: 0x1800EDCB0
	public FloatParameter toneCurveShoulderAngle; // 0x68
	[DisplayNameAttribute] // RVA: 0xEDE10 Offset: 0xED210 VA: 0x1800EDE10
	[MinAttribute] // RVA: 0xEDE10 Offset: 0xED210 VA: 0x1800EDE10
	[TooltipAttribute] // RVA: 0xEDE10 Offset: 0xED210 VA: 0x1800EDE10
	public FloatParameter toneCurveGamma; // 0x70
	[DisplayNameAttribute] // RVA: 0xEE0F0 Offset: 0xED4F0 VA: 0x1800EE0F0
	[TooltipAttribute] // RVA: 0xEE0F0 Offset: 0xED4F0 VA: 0x1800EE0F0
	public TextureParameter ldrLut; // 0x78
	[DisplayNameAttribute] // RVA: 0xEE360 Offset: 0xED760 VA: 0x1800EE360
	[RangeAttribute] // RVA: 0xEE360 Offset: 0xED760 VA: 0x1800EE360
	[TooltipAttribute] // RVA: 0xEE360 Offset: 0xED760 VA: 0x1800EE360
	public FloatParameter ldrLutContribution; // 0x80
	[DisplayNameAttribute] // RVA: 0xEE610 Offset: 0xEDA10 VA: 0x1800EE610
	[RangeAttribute] // RVA: 0xEE610 Offset: 0xEDA10 VA: 0x1800EE610
	[TooltipAttribute] // RVA: 0xEE610 Offset: 0xEDA10 VA: 0x1800EE610
	public FloatParameter temperature; // 0x88
	[DisplayNameAttribute] // RVA: 0xEE7B0 Offset: 0xEDBB0 VA: 0x1800EE7B0
	[RangeAttribute] // RVA: 0xEE7B0 Offset: 0xEDBB0 VA: 0x1800EE7B0
	[TooltipAttribute] // RVA: 0xEE7B0 Offset: 0xEDBB0 VA: 0x1800EE7B0
	public FloatParameter tint; // 0x90
	[DisplayNameAttribute] // RVA: 0xEEA20 Offset: 0xEDE20 VA: 0x1800EEA20
	[ColorUsageAttribute] // RVA: 0xEEA20 Offset: 0xEDE20 VA: 0x1800EEA20
	[TooltipAttribute] // RVA: 0xEEA20 Offset: 0xEDE20 VA: 0x1800EEA20
	public ColorParameter colorFilter; // 0x98
	[DisplayNameAttribute] // RVA: 0xEEC60 Offset: 0xEE060 VA: 0x1800EEC60
	[RangeAttribute] // RVA: 0xEEC60 Offset: 0xEE060 VA: 0x1800EEC60
	[TooltipAttribute] // RVA: 0xEEC60 Offset: 0xEE060 VA: 0x1800EEC60
	public FloatParameter hueShift; // 0xA0
	[DisplayNameAttribute] // RVA: 0xEEF40 Offset: 0xEE340 VA: 0x1800EEF40
	[RangeAttribute] // RVA: 0xEEF40 Offset: 0xEE340 VA: 0x1800EEF40
	[TooltipAttribute] // RVA: 0xEEF40 Offset: 0xEE340 VA: 0x1800EEF40
	public FloatParameter saturation; // 0xA8
	[DisplayNameAttribute] // RVA: 0xEF210 Offset: 0xEE610 VA: 0x1800EF210
	[RangeAttribute] // RVA: 0xEF210 Offset: 0xEE610 VA: 0x1800EF210
	[TooltipAttribute] // RVA: 0xEF210 Offset: 0xEE610 VA: 0x1800EF210
	public FloatParameter brightness; // 0xB0
	[DisplayNameAttribute] // RVA: 0xEF690 Offset: 0xEEA90 VA: 0x1800EF690
	[TooltipAttribute] // RVA: 0xEF690 Offset: 0xEEA90 VA: 0x1800EF690
	public FloatParameter postExposure; // 0xB8
	[DisplayNameAttribute] // RVA: 0xEF8E0 Offset: 0xEECE0 VA: 0x1800EF8E0
	[RangeAttribute] // RVA: 0xEF8E0 Offset: 0xEECE0 VA: 0x1800EF8E0
	[TooltipAttribute] // RVA: 0xEF8E0 Offset: 0xEECE0 VA: 0x1800EF8E0
	public FloatParameter contrast; // 0xC0
	[DisplayNameAttribute] // RVA: 0xEFAE0 Offset: 0xEEEE0 VA: 0x1800EFAE0
	[RangeAttribute] // RVA: 0xEFAE0 Offset: 0xEEEE0 VA: 0x1800EFAE0
	[TooltipAttribute] // RVA: 0xEFAE0 Offset: 0xEEEE0 VA: 0x1800EFAE0
	public FloatParameter mixerRedOutRedIn; // 0xC8
	[DisplayNameAttribute] // RVA: 0xEFD00 Offset: 0xEF100 VA: 0x1800EFD00
	[RangeAttribute] // RVA: 0xEFD00 Offset: 0xEF100 VA: 0x1800EFD00
	[TooltipAttribute] // RVA: 0xEFD00 Offset: 0xEF100 VA: 0x1800EFD00
	public FloatParameter mixerRedOutGreenIn; // 0xD0
	[DisplayNameAttribute] // RVA: 0xEFE50 Offset: 0xEF250 VA: 0x1800EFE50
	[RangeAttribute] // RVA: 0xEFE50 Offset: 0xEF250 VA: 0x1800EFE50
	[TooltipAttribute] // RVA: 0xEFE50 Offset: 0xEF250 VA: 0x1800EFE50
	public FloatParameter mixerRedOutBlueIn; // 0xD8
	[DisplayNameAttribute] // RVA: 0xEFAE0 Offset: 0xEEEE0 VA: 0x1800EFAE0
	[RangeAttribute] // RVA: 0xEFAE0 Offset: 0xEEEE0 VA: 0x1800EFAE0
	[TooltipAttribute] // RVA: 0xEFAE0 Offset: 0xEEEE0 VA: 0x1800EFAE0
	public FloatParameter mixerGreenOutRedIn; // 0xE0
	[DisplayNameAttribute] // RVA: 0xEFD00 Offset: 0xEF100 VA: 0x1800EFD00
	[RangeAttribute] // RVA: 0xEFD00 Offset: 0xEF100 VA: 0x1800EFD00
	[TooltipAttribute] // RVA: 0xEFD00 Offset: 0xEF100 VA: 0x1800EFD00
	public FloatParameter mixerGreenOutGreenIn; // 0xE8
	[DisplayNameAttribute] // RVA: 0xEFE50 Offset: 0xEF250 VA: 0x1800EFE50
	[RangeAttribute] // RVA: 0xEFE50 Offset: 0xEF250 VA: 0x1800EFE50
	[TooltipAttribute] // RVA: 0xEFE50 Offset: 0xEF250 VA: 0x1800EFE50
	public FloatParameter mixerGreenOutBlueIn; // 0xF0
	[DisplayNameAttribute] // RVA: 0xEFAE0 Offset: 0xEEEE0 VA: 0x1800EFAE0
	[RangeAttribute] // RVA: 0xEFAE0 Offset: 0xEEEE0 VA: 0x1800EFAE0
	[TooltipAttribute] // RVA: 0xEFAE0 Offset: 0xEEEE0 VA: 0x1800EFAE0
	public FloatParameter mixerBlueOutRedIn; // 0xF8
	[DisplayNameAttribute] // RVA: 0xEFD00 Offset: 0xEF100 VA: 0x1800EFD00
	[RangeAttribute] // RVA: 0xEFD00 Offset: 0xEF100 VA: 0x1800EFD00
	[TooltipAttribute] // RVA: 0xEFD00 Offset: 0xEF100 VA: 0x1800EFD00
	public FloatParameter mixerBlueOutGreenIn; // 0x100
	[DisplayNameAttribute] // RVA: 0xEFE50 Offset: 0xEF250 VA: 0x1800EFE50
	[RangeAttribute] // RVA: 0xEFE50 Offset: 0xEF250 VA: 0x1800EFE50
	[TooltipAttribute] // RVA: 0xEFE50 Offset: 0xEF250 VA: 0x1800EFE50
	public FloatParameter mixerBlueOutBlueIn; // 0x108
	[DisplayNameAttribute] // RVA: 0xF0800 Offset: 0xEFC00 VA: 0x1800F0800
	[TooltipAttribute] // RVA: 0xF0800 Offset: 0xEFC00 VA: 0x1800F0800
	[TrackballAttribute] // RVA: 0xF0800 Offset: 0xEFC00 VA: 0x1800F0800
	public Vector4Parameter lift; // 0x110
	[DisplayNameAttribute] // RVA: 0xF09E0 Offset: 0xEFDE0 VA: 0x1800F09E0
	[TooltipAttribute] // RVA: 0xF09E0 Offset: 0xEFDE0 VA: 0x1800F09E0
	[TrackballAttribute] // RVA: 0xF09E0 Offset: 0xEFDE0 VA: 0x1800F09E0
	public Vector4Parameter gamma; // 0x118
	[DisplayNameAttribute] // RVA: 0xF0D90 Offset: 0xF0190 VA: 0x1800F0D90
	[TooltipAttribute] // RVA: 0xF0D90 Offset: 0xF0190 VA: 0x1800F0D90
	[TrackballAttribute] // RVA: 0xF0D90 Offset: 0xF0190 VA: 0x1800F0D90
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

	// RVA: 0x9F6170 Offset: 0x9F4770 VA: 0x1809F6170 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x9F61C0 Offset: 0x9F47C0 VA: 0x1809F61C0
	public void .ctor() { }

}

