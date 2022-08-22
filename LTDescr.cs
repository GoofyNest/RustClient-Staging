public class LTDescr // TypeDefIndex: 5569
{	// Fields
	public bool toggle; // 0x10
	public bool useEstimatedTime; // 0x11
	public bool useFrames; // 0x12
	public bool useManualTime; // 0x13
	public bool usesNormalDt; // 0x14
	public bool hasInitiliazed; // 0x15
	public bool hasExtraOnCompletes; // 0x16
	public bool hasPhysics; // 0x17
	public bool onCompleteOnRepeat; // 0x18
	public bool onCompleteOnStart; // 0x19
	public bool useRecursion; // 0x1A
	public float ratioPassed; // 0x1C
	public float passed; // 0x20
	public float delay; // 0x24
	public float time; // 0x28
	public float speed; // 0x2C
	public float lastVal; // 0x30
	private uint _id; // 0x34
	public int loopCount; // 0x38
	public uint counter; // 0x3C
	public float direction; // 0x40
	public float directionLast; // 0x44
	public float overshoot; // 0x48
	public float period; // 0x4C
	public float scale; // 0x50
	public bool destroyOnComplete; // 0x54
	public Transform trans; // 0x58
	public LTRect ltRect; // 0x60
	internal Vector3 fromInternal; // 0x68
	internal Vector3 toInternal; // 0x74
	internal Vector3 diff; // 0x80
	internal Vector3 diffDiv2; // 0x8C
	public TweenAction type; // 0x98
	private LeanTweenType easeType; // 0x9C
	public LeanTweenType loopType; // 0xA0
	public bool hasUpdateCallback; // 0xA4
	public LTDescr.EaseTypeDelegate easeMethod; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private LTDescr.ActionMethodDelegate <easeInternal>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private LTDescr.ActionMethodDelegate <initInternal>k__BackingField; // 0xB8
	public SpriteRenderer spriteRen; // 0xC0
	public RectTransform rectTransform; // 0xC8
	public Text uiText; // 0xD0
	public Image uiImage; // 0xD8
	public RawImage rawImage; // 0xE0
	public Sprite[] sprites; // 0xE8
	public LTDescrOptional _optional; // 0xF0
	public static float val; // 0x0
	public static float dt; // 0x4
	public static Vector3 newVect; // 0x8

	// Properties
	public Vector3 from { get; set; }
	public Vector3 to { get; set; }
	public LTDescr.ActionMethodDelegate easeInternal { get; set; }
	public LTDescr.ActionMethodDelegate initInternal { get; set; }
	public int uniqueId { get; }
	public int id { get; }
	public LTDescrOptional optional { get; set; }

	// Methods

	// RVA: 0x1998FC0 Offset: 0x19975C0 VA: 0x181998FC0
	public Vector3 get_from() { }

	// RVA: 0x199F040 Offset: 0x199D640 VA: 0x18199F040
	public void set_from(Vector3 value) { }

	// RVA: 0x1998FF0 Offset: 0x19975F0 VA: 0x181998FF0
	public Vector3 get_to() { }

	// RVA: 0x199F060 Offset: 0x199D660 VA: 0x18199F060
	public void set_to(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9922B0 Offset: 0x9908B0 VA: 0x1809922B0
	public LTDescr.ActionMethodDelegate get_easeInternal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D4E0 Offset: 0xA4BAE0 VA: 0x180A4D4E0
	public void set_easeInternal(LTDescr.ActionMethodDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7AD080 Offset: 0x7AB680 VA: 0x1807AD080
	public LTDescr.ActionMethodDelegate get_initInternal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D4F0 Offset: 0xA4BAF0 VA: 0x180A4D4F0
	public void set_initInternal(LTDescr.ActionMethodDelegate value) { }

	// RVA: 0x198E220 Offset: 0x198C820 VA: 0x18198E220 Slot: 3
	public override string ToString() { }

	// RVA: 0x1994AF0 Offset: 0x19930F0 VA: 0x181994AF0
	public void .ctor() { }

	[ObsoleteAttribute] // RVA: 0xA8020 Offset: 0xA7420 VA: 0x1800A8020
	// RVA: 0x19956D0 Offset: 0x1993CD0 VA: 0x1819956D0
	public LTDescr cancel(GameObject gameObject) { }

	// RVA: 0x1998FE0 Offset: 0x19975E0 VA: 0x181998FE0
	public int get_uniqueId() { }

	// RVA: 0x1998FE0 Offset: 0x19975E0 VA: 0x181998FE0
	public int get_id() { }

	// RVA: 0xC73E20 Offset: 0xC72420 VA: 0x180C73E20
	public LTDescrOptional get_optional() { }

	// RVA: 0x199F050 Offset: 0x199D650 VA: 0x18199F050
	public void set_optional(LTDescrOptional value) { }

	// RVA: 0x1999400 Offset: 0x1997A00 VA: 0x181999400
	public void reset() { }

	// RVA: 0x199D610 Offset: 0x199BC10 VA: 0x18199D610
	public LTDescr setMoveX() { }

	// RVA: 0x199D6E0 Offset: 0x199BCE0 VA: 0x18199D6E0
	public LTDescr setMoveY() { }

	// RVA: 0x199D7B0 Offset: 0x199BDB0 VA: 0x18199D7B0
	public LTDescr setMoveZ() { }

	// RVA: 0x199D060 Offset: 0x199B660 VA: 0x18199D060
	public LTDescr setMoveLocalX() { }

	// RVA: 0x199D130 Offset: 0x199B730 VA: 0x18199D130
	public LTDescr setMoveLocalY() { }

	// RVA: 0x199D200 Offset: 0x199B800 VA: 0x18199D200
	public LTDescr setMoveLocalZ() { }

	// RVA: 0x1999060 Offset: 0x1997660 VA: 0x181999060
	private void initFromInternal() { }

	// RVA: 0x199CF90 Offset: 0x199B590 VA: 0x18199CF90
	public LTDescr setMoveCurved() { }

	// RVA: 0x199CEC0 Offset: 0x199B4C0 VA: 0x18199CEC0
	public LTDescr setMoveCurvedLocal() { }

	// RVA: 0x199D470 Offset: 0x199BA70 VA: 0x18199D470
	public LTDescr setMoveSpline() { }

	// RVA: 0x199D3A0 Offset: 0x199B9A0 VA: 0x18199D3A0
	public LTDescr setMoveSplineLocal() { }

	// RVA: 0x199E850 Offset: 0x199CE50 VA: 0x18199E850
	public LTDescr setScaleX() { }

	// RVA: 0x199E920 Offset: 0x199CF20 VA: 0x18199E920
	public LTDescr setScaleY() { }

	// RVA: 0x199E9F0 Offset: 0x199CFF0 VA: 0x18199E9F0
	public LTDescr setScaleZ() { }

	// RVA: 0x199E510 Offset: 0x199CB10 VA: 0x18199E510
	public LTDescr setRotateX() { }

	// RVA: 0x199E5E0 Offset: 0x199CBE0 VA: 0x18199E5E0
	public LTDescr setRotateY() { }

	// RVA: 0x199E6B0 Offset: 0x199CCB0 VA: 0x18199E6B0
	public LTDescr setRotateZ() { }

	// RVA: 0x199E370 Offset: 0x199C970 VA: 0x18199E370
	public LTDescr setRotateAround() { }

	// RVA: 0x199E2A0 Offset: 0x199C8A0 VA: 0x18199E2A0
	public LTDescr setRotateAroundLocal() { }

	// RVA: 0x1999770 Offset: 0x1997D70 VA: 0x181999770
	public LTDescr setAlpha() { }

	// RVA: 0x199EC00 Offset: 0x199D200 VA: 0x18199EC00
	public LTDescr setTextAlpha() { }

	// RVA: 0x19996A0 Offset: 0x1997CA0 VA: 0x1819996A0
	public LTDescr setAlphaVertex() { }

	// RVA: 0x199A490 Offset: 0x1998A90 VA: 0x18199A490
	public LTDescr setColor() { }

	// RVA: 0x19998B0 Offset: 0x1997EB0 VA: 0x1819998B0
	public LTDescr setCallbackColor() { }

	// RVA: 0x199ECD0 Offset: 0x199D2D0 VA: 0x18199ECD0
	public LTDescr setTextColor() { }

	// RVA: 0x1999AD0 Offset: 0x19980D0 VA: 0x181999AD0
	public LTDescr setCanvasAlpha() { }

	// RVA: 0x1999C70 Offset: 0x1998270 VA: 0x181999C70
	public LTDescr setCanvasGroupAlpha() { }

	// RVA: 0x1999BA0 Offset: 0x19981A0 VA: 0x181999BA0
	public LTDescr setCanvasColor() { }

	// RVA: 0x1999D40 Offset: 0x1998340 VA: 0x181999D40
	public LTDescr setCanvasMoveX() { }

	// RVA: 0x1999E10 Offset: 0x1998410 VA: 0x181999E10
	public LTDescr setCanvasMoveY() { }

	// RVA: 0x1999EE0 Offset: 0x19984E0 VA: 0x181999EE0
	public LTDescr setCanvasMoveZ() { }

	// RVA: 0x1999010 Offset: 0x1997610 VA: 0x181999010
	private void initCanvasRotateAround() { }

	// RVA: 0x199A220 Offset: 0x1998820 VA: 0x18199A220
	public LTDescr setCanvasRotateAround() { }

	// RVA: 0x199A150 Offset: 0x1998750 VA: 0x18199A150
	public LTDescr setCanvasRotateAroundLocal() { }

	// RVA: 0x199A080 Offset: 0x1998680 VA: 0x18199A080
	public LTDescr setCanvasPlaySprite() { }

	// RVA: 0x1999FB0 Offset: 0x19985B0 VA: 0x181999FB0
	public LTDescr setCanvasMove() { }

	// RVA: 0x199A2F0 Offset: 0x19988F0 VA: 0x18199A2F0
	public LTDescr setCanvasScale() { }

	// RVA: 0x199A3C0 Offset: 0x19989C0 VA: 0x18199A3C0
	public LTDescr setCanvasSizeDelta() { }

	// RVA: 0x1995650 Offset: 0x1993C50 VA: 0x181995650
	private void callback() { }

	// RVA: 0x1999980 Offset: 0x1997F80 VA: 0x181999980
	public LTDescr setCallback() { }

	// RVA: 0x199EEF0 Offset: 0x199D4F0 VA: 0x18199EEF0
	public LTDescr setValue3() { }

	// RVA: 0x199D880 Offset: 0x199BE80 VA: 0x18199D880
	public LTDescr setMove() { }

	// RVA: 0x199D2D0 Offset: 0x199B8D0 VA: 0x18199D2D0
	public LTDescr setMoveLocal() { }

	// RVA: 0x199D540 Offset: 0x199BB40 VA: 0x18199D540
	public LTDescr setMoveToTransform() { }

	// RVA: 0x199E780 Offset: 0x199CD80 VA: 0x18199E780
	public LTDescr setRotate() { }

	// RVA: 0x199E440 Offset: 0x199CA40 VA: 0x18199E440
	public LTDescr setRotateLocal() { }

	// RVA: 0x199EAD0 Offset: 0x199D0D0 VA: 0x18199EAD0
	public LTDescr setScale() { }

	// RVA: 0x199CB80 Offset: 0x199B180 VA: 0x18199CB80
	public LTDescr setGUIMove() { }

	// RVA: 0x199CAB0 Offset: 0x199B0B0 VA: 0x18199CAB0
	public LTDescr setGUIMoveMargin() { }

	// RVA: 0x199CD20 Offset: 0x199B320 VA: 0x18199CD20
	public LTDescr setGUIScale() { }

	// RVA: 0x199C9E0 Offset: 0x199AFE0 VA: 0x18199C9E0
	public LTDescr setGUIAlpha() { }

	// RVA: 0x199CC50 Offset: 0x199B250 VA: 0x18199CC50
	public LTDescr setGUIRotate() { }

	// RVA: 0x199A570 Offset: 0x1998B70 VA: 0x18199A570
	public LTDescr setDelayedSound() { }

	// RVA: 0x19991E0 Offset: 0x19977E0 VA: 0x1819991E0
	private void init() { }

	// RVA: 0x1999070 Offset: 0x1997670 VA: 0x181999070
	private void initSpeed() { }

	// RVA: 0x199FFD0 Offset: 0x199E5D0 VA: 0x18199FFD0
	public LTDescr updateNow() { }

	// RVA: 0x199FAE0 Offset: 0x199E0E0 VA: 0x18199FAE0
	public bool updateInternal() { }

	// RVA: 0x1995530 Offset: 0x1993B30 VA: 0x181995530
	public void callOnCompletes() { }

	// RVA: 0x199C630 Offset: 0x199AC30 VA: 0x18199C630
	public LTDescr setFromColor(Color col) { }

	// RVA: 0x19950E0 Offset: 0x19936E0 VA: 0x1819950E0
	private static void alphaRecursive(Transform transform, float val, bool useRecursion = True) { }

	// RVA: 0x1995A40 Offset: 0x1994040 VA: 0x181995A40
	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = True) { }

	// RVA: 0x1994E00 Offset: 0x1993400 VA: 0x181994E00
	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0) { }

	// RVA: 0x1994B60 Offset: 0x1993160 VA: 0x181994B60
	private static void alphaRecursiveSprite(Transform transform, float val) { }

	// RVA: 0x19957A0 Offset: 0x1993DA0 VA: 0x1819957A0
	private static void colorRecursiveSprite(Transform transform, Color toColor) { }

	// RVA: 0x1995D30 Offset: 0x1994330 VA: 0x181995D30
	private static void colorRecursive(RectTransform rectTransform, Color toColor) { }

	// RVA: 0x199F070 Offset: 0x199D670 VA: 0x18199F070
	private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = True) { }

	// RVA: 0x199F2E0 Offset: 0x199D8E0 VA: 0x18199F2E0
	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = True) { }

	// RVA: 0x199F590 Offset: 0x199DB90 VA: 0x18199F590
	private static void textColorRecursive(Transform trans, Color toColor) { }

	// RVA: 0x199F7C0 Offset: 0x199DDC0 VA: 0x18199F7C0
	private static Color tweenColor(LTDescr tween, float val) { }

	// RVA: 0x19993E0 Offset: 0x19979E0 VA: 0x1819993E0
	public LTDescr pause() { }

	// RVA: 0x1999690 Offset: 0x1997C90 VA: 0x181999690
	public LTDescr resume() { }

	// RVA: 0x1999880 Offset: 0x1997E80 VA: 0x181999880
	public LTDescr setAxis(Vector3 axis) { }

	// RVA: 0x199A560 Offset: 0x1998B60 VA: 0x18199A560
	public LTDescr setDelay(float delay) { }

	// RVA: 0x199BCA0 Offset: 0x199A2A0 VA: 0x18199BCA0
	public LTDescr setEase(LeanTweenType easeType) { }

	// RVA: 0x199B370 Offset: 0x1999970 VA: 0x18199B370
	public LTDescr setEaseLinear() { }

	// RVA: 0x199BB60 Offset: 0x199A160 VA: 0x18199BB60
	public LTDescr setEaseSpring() { }

	// RVA: 0x199B130 Offset: 0x1999730 VA: 0x18199B130
	public LTDescr setEaseInQuad() { }

	// RVA: 0x199B760 Offset: 0x1999D60 VA: 0x18199B760
	public LTDescr setEaseOutQuad() { }

	// RVA: 0x199AEF0 Offset: 0x19994F0 VA: 0x18199AEF0
	public LTDescr setEaseInOutQuad() { }

	// RVA: 0x199A9E0 Offset: 0x1998FE0 VA: 0x18199A9E0
	public LTDescr setEaseInCubic() { }

	// RVA: 0x199B5B0 Offset: 0x1999BB0 VA: 0x18199B5B0
	public LTDescr setEaseOutCubic() { }

	// RVA: 0x199AD40 Offset: 0x1999340 VA: 0x18199AD40
	public LTDescr setEaseInOutCubic() { }

	// RVA: 0x199B1C0 Offset: 0x19997C0 VA: 0x18199B1C0
	public LTDescr setEaseInQuart() { }

	// RVA: 0x199B7F0 Offset: 0x1999DF0 VA: 0x18199B7F0
	public LTDescr setEaseOutQuart() { }

	// RVA: 0x199AF80 Offset: 0x1999580 VA: 0x18199AF80
	public LTDescr setEaseInOutQuart() { }

	// RVA: 0x199B250 Offset: 0x1999850 VA: 0x18199B250
	public LTDescr setEaseInQuint() { }

	// RVA: 0x199B880 Offset: 0x1999E80 VA: 0x18199B880
	public LTDescr setEaseOutQuint() { }

	// RVA: 0x199B010 Offset: 0x1999610 VA: 0x18199B010
	public LTDescr setEaseInOutQuint() { }

	// RVA: 0x199B2E0 Offset: 0x19998E0 VA: 0x18199B2E0
	public LTDescr setEaseInSine() { }

	// RVA: 0x199B910 Offset: 0x1999F10 VA: 0x18199B910
	public LTDescr setEaseOutSine() { }

	// RVA: 0x199B0A0 Offset: 0x19996A0 VA: 0x18199B0A0
	public LTDescr setEaseInOutSine() { }

	// RVA: 0x199AB00 Offset: 0x1999100 VA: 0x18199AB00
	public LTDescr setEaseInExpo() { }

	// RVA: 0x199B6D0 Offset: 0x1999CD0 VA: 0x18199B6D0
	public LTDescr setEaseOutExpo() { }

	// RVA: 0x199AE60 Offset: 0x1999460 VA: 0x18199AE60
	public LTDescr setEaseInOutExpo() { }

	// RVA: 0x199A950 Offset: 0x1998F50 VA: 0x18199A950
	public LTDescr setEaseInCirc() { }

	// RVA: 0x199B520 Offset: 0x1999B20 VA: 0x18199B520
	public LTDescr setEaseOutCirc() { }

	// RVA: 0x199ACB0 Offset: 0x19992B0 VA: 0x18199ACB0
	public LTDescr setEaseInOutCirc() { }

	// RVA: 0x199A8C0 Offset: 0x1998EC0 VA: 0x18199A8C0
	public LTDescr setEaseInBounce() { }

	// RVA: 0x199B490 Offset: 0x1999A90 VA: 0x18199B490
	public LTDescr setEaseOutBounce() { }

	// RVA: 0x199AC20 Offset: 0x1999220 VA: 0x18199AC20
	public LTDescr setEaseInOutBounce() { }

	// RVA: 0x199A830 Offset: 0x1998E30 VA: 0x18199A830
	public LTDescr setEaseInBack() { }

	// RVA: 0x199B400 Offset: 0x1999A00 VA: 0x18199B400
	public LTDescr setEaseOutBack() { }

	// RVA: 0x199AB90 Offset: 0x1999190 VA: 0x18199AB90
	public LTDescr setEaseInOutBack() { }

	// RVA: 0x199AA70 Offset: 0x1999070 VA: 0x18199AA70
	public LTDescr setEaseInElastic() { }

	// RVA: 0x199B640 Offset: 0x1999C40 VA: 0x18199B640
	public LTDescr setEaseOutElastic() { }

	// RVA: 0x199ADD0 Offset: 0x19993D0 VA: 0x18199ADD0
	public LTDescr setEaseInOutElastic() { }

	// RVA: 0x199B9A0 Offset: 0x1999FA0 VA: 0x18199B9A0
	public LTDescr setEasePunch() { }

	// RVA: 0x199BA80 Offset: 0x199A080 VA: 0x18199BA80
	public LTDescr setEaseShake() { }

	// RVA: 0x199F980 Offset: 0x199DF80 VA: 0x18199F980
	private Vector3 tweenOnCurve() { }

	// RVA: 0x1997450 Offset: 0x1995A50 VA: 0x181997450
	private Vector3 easeInOutQuad() { }

	// RVA: 0x1997A50 Offset: 0x1996050 VA: 0x181997A50
	private Vector3 easeInQuad() { }

	// RVA: 0x19988F0 Offset: 0x1996EF0 VA: 0x1819988F0
	private Vector3 easeOutQuad() { }

	// RVA: 0x1997EF0 Offset: 0x19964F0 VA: 0x181997EF0
	private Vector3 easeLinear() { }

	// RVA: 0x1998DE0 Offset: 0x19973E0 VA: 0x181998DE0
	private Vector3 easeSpring() { }

	// RVA: 0x1996450 Offset: 0x1994A50 VA: 0x181996450
	private Vector3 easeInCubic() { }

	// RVA: 0x1998510 Offset: 0x1996B10 VA: 0x181998510
	private Vector3 easeOutCubic() { }

	// RVA: 0x1996F20 Offset: 0x1995520 VA: 0x181996F20
	private Vector3 easeInOutCubic() { }

	// RVA: 0x1997B50 Offset: 0x1996150 VA: 0x181997B50
	private Vector3 easeInQuart() { }

	// RVA: 0x1998A20 Offset: 0x1997020 VA: 0x181998A20
	private Vector3 easeOutQuart() { }

	// RVA: 0x1997580 Offset: 0x1995B80 VA: 0x181997580
	private Vector3 easeInOutQuart() { }

	// RVA: 0x1997C70 Offset: 0x1996270 VA: 0x181997C70
	private Vector3 easeInQuint() { }

	// RVA: 0x1998B50 Offset: 0x1997150 VA: 0x181998B50
	private Vector3 easeOutQuint() { }

	// RVA: 0x19977B0 Offset: 0x1995DB0 VA: 0x1819977B0
	private Vector3 easeInOutQuint() { }

	// RVA: 0x1997D80 Offset: 0x1996380 VA: 0x181997D80
	private Vector3 easeInSine() { }

	// RVA: 0x1998C80 Offset: 0x1997280 VA: 0x181998C80
	private Vector3 easeOutSine() { }

	// RVA: 0x1997910 Offset: 0x1995F10 VA: 0x181997910
	private Vector3 easeInOutSine() { }

	// RVA: 0x19966D0 Offset: 0x1994CD0 VA: 0x1819966D0
	private Vector3 easeInExpo() { }

	// RVA: 0x19987B0 Offset: 0x1996DB0 VA: 0x1819987B0
	private Vector3 easeOutExpo() { }

	// RVA: 0x19971F0 Offset: 0x19957F0 VA: 0x1819971F0
	private Vector3 easeInOutExpo() { }

	// RVA: 0x1996310 Offset: 0x1994910 VA: 0x181996310
	private Vector3 easeInCirc() { }

	// RVA: 0x19983C0 Offset: 0x19969C0 VA: 0x1819983C0
	private Vector3 easeOutCirc() { }

	// RVA: 0x1996D60 Offset: 0x1995360 VA: 0x181996D60
	private Vector3 easeInOutCirc() { }

	// RVA: 0x1996150 Offset: 0x1994750 VA: 0x181996150
	private Vector3 easeInBounce() { }

	// RVA: 0x1998130 Offset: 0x1996730 VA: 0x181998130
	private Vector3 easeOutBounce() { }

	// RVA: 0x1996A70 Offset: 0x1995070 VA: 0x181996A70
	private Vector3 easeInOutBounce() { }

	// RVA: 0x1995FA0 Offset: 0x19945A0 VA: 0x181995FA0
	private Vector3 easeInBack() { }

	// RVA: 0x1997FD0 Offset: 0x19965D0 VA: 0x181997FD0
	private Vector3 easeOutBack() { }

	// RVA: 0x1996810 Offset: 0x1994E10 VA: 0x181996810
	private Vector3 easeInOutBack() { }

	// RVA: 0x1996550 Offset: 0x1994B50 VA: 0x181996550
	private Vector3 easeInElastic() { }

	// RVA: 0x1998630 Offset: 0x1996C30 VA: 0x181998630
	private Vector3 easeOutElastic() { }

	// RVA: 0x1997070 Offset: 0x1995670 VA: 0x181997070
	private Vector3 easeInOutElastic() { }

	// RVA: 0x199E0C0 Offset: 0x199C6C0 VA: 0x18199E0C0
	public LTDescr setOvershoot(float overshoot) { }

	// RVA: 0x199E110 Offset: 0x199C710 VA: 0x18199E110
	public LTDescr setPeriod(float period) { }

	// RVA: 0x199EAC0 Offset: 0x199D0C0 VA: 0x18199EAC0
	public LTDescr setScale(float scale) { }

	// RVA: 0x199BBF0 Offset: 0x199A1F0 VA: 0x18199BBF0
	public LTDescr setEase(AnimationCurve easeCurve) { }

	// RVA: 0x199EDC0 Offset: 0x199D3C0 VA: 0x18199EDC0
	public LTDescr setTo(Vector3 to) { }

	// RVA: 0x199EEA0 Offset: 0x199D4A0 VA: 0x18199EEA0
	public LTDescr setTo(Transform to) { }

	// RVA: 0x199C720 Offset: 0x199AD20 VA: 0x18199C720
	public LTDescr setFrom(Vector3 from) { }

	// RVA: 0x199C870 Offset: 0x199AE70 VA: 0x18199C870
	public LTDescr setFrom(float from) { }

	// RVA: 0x199A650 Offset: 0x1998C50 VA: 0x18199A650
	public LTDescr setDiff(Vector3 diff) { }

	// RVA: 0x199CDF0 Offset: 0x199B3F0 VA: 0x18199CDF0
	public LTDescr setHasInitialized(bool has) { }

	// RVA: 0x199CE00 Offset: 0x199B400 VA: 0x18199CE00
	public LTDescr setId(uint id, uint global_counter) { }

	// RVA: 0x199E0D0 Offset: 0x199C6D0 VA: 0x18199E0D0
	public LTDescr setPassed(float passed) { }

	// RVA: 0x199EDA0 Offset: 0x199D3A0 VA: 0x18199EDA0
	public LTDescr setTime(float time) { }

	// RVA: 0x199EBA0 Offset: 0x199D1A0 VA: 0x18199EBA0
	public LTDescr setSpeed(float speed) { }

	// RVA: 0x199E260 Offset: 0x199C860 VA: 0x18199E260
	public LTDescr setRepeat(int repeat) { }

	// RVA: 0x199CEB0 Offset: 0x199B4B0 VA: 0x18199CEB0
	public LTDescr setLoopType(LeanTweenType loopType) { }

	// RVA: 0x199CE10 Offset: 0x199B410 VA: 0x18199CE10
	public LTDescr setUseEstimatedTime(bool useEstimatedTime) { }

	// RVA: 0x199CE10 Offset: 0x199B410 VA: 0x18199CE10
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime) { }

	// RVA: 0x199EED0 Offset: 0x199D4D0 VA: 0x18199EED0
	public LTDescr setUseFrames(bool useFrames) { }

	// RVA: 0x199EEE0 Offset: 0x199D4E0 VA: 0x18199EEE0
	public LTDescr setUseManualTime(bool useManualTime) { }

	// RVA: 0x199CE40 Offset: 0x199B440 VA: 0x18199CE40
	public LTDescr setLoopCount(int loopCount) { }

	// RVA: 0x199CE60 Offset: 0x199B460 VA: 0x18199CE60
	public LTDescr setLoopOnce() { }

	// RVA: 0x199CE20 Offset: 0x199B420 VA: 0x18199CE20
	public LTDescr setLoopClamp() { }

	// RVA: 0xE724A0 Offset: 0xE70AA0 VA: 0x180E724A0
	public LTDescr setLoopClamp(int loops) { }

	// RVA: 0x199CE70 Offset: 0x199B470 VA: 0x18199CE70
	public LTDescr setLoopPingPong() { }

	// RVA: 0x199CE90 Offset: 0x199B490 VA: 0x18199CE90
	public LTDescr setLoopPingPong(int loops) { }

	// RVA: 0x199DA20 Offset: 0x199C020 VA: 0x18199DA20
	public LTDescr setOnComplete(Action onComplete) { }

	// RVA: 0x199DA60 Offset: 0x199C060 VA: 0x18199DA60
	public LTDescr setOnComplete(Action<object> onComplete) { }

	// RVA: 0x199D9B0 Offset: 0x199BFB0 VA: 0x18199D9B0
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam) { }

	// RVA: 0x199D970 Offset: 0x199BF70 VA: 0x18199D970
	public LTDescr setOnCompleteParam(object onCompleteParam) { }

	// RVA: 0x199DD10 Offset: 0x199C310 VA: 0x18199DD10
	public LTDescr setOnUpdate(Action<float> onUpdate) { }

	// RVA: 0x199DBE0 Offset: 0x199C1E0 VA: 0x18199DBE0
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate) { }

	// RVA: 0x199DB60 Offset: 0x199C160 VA: 0x18199DB60
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate) { }

	// RVA: 0x199DC20 Offset: 0x199C220 VA: 0x18199DC20
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate) { }

	// RVA: 0x199DC60 Offset: 0x199C260 VA: 0x18199DC60
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate) { }

	// RVA: 0x199DAE0 Offset: 0x199C0E0 VA: 0x18199DAE0
	public LTDescr setOnUpdateColor(Action<Color> onUpdate) { }

	// RVA: 0x199DB20 Offset: 0x199C120 VA: 0x18199DB20
	public LTDescr setOnUpdateColor(Action<Color, object> onUpdate) { }

	// RVA: 0x199DAE0 Offset: 0x199C0E0 VA: 0x18199DAE0
	public LTDescr setOnUpdate(Action<Color> onUpdate) { }

	// RVA: 0x199DB20 Offset: 0x199C120 VA: 0x18199DB20
	public LTDescr setOnUpdate(Action<Color, object> onUpdate) { }

	// RVA: 0x199DD50 Offset: 0x199C350 VA: 0x18199DD50
	public LTDescr setOnUpdate(Action<float, object> onUpdate, object onUpdateParam) { }

	// RVA: 0x199DCA0 Offset: 0x199C2A0 VA: 0x18199DCA0
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, object onUpdateParam) { }

	// RVA: 0x199DDC0 Offset: 0x199C3C0 VA: 0x18199DDC0
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, object onUpdateParam) { }

	// RVA: 0x199DE30 Offset: 0x199C430 VA: 0x18199DE30
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, object onUpdateParam) { }

	// RVA: 0x199DBA0 Offset: 0x199C1A0 VA: 0x18199DBA0
	public LTDescr setOnUpdateParam(object onUpdateParam) { }

	// RVA: 0x199DFD0 Offset: 0x199C5D0 VA: 0x18199DFD0
	public LTDescr setOrientToPath(bool doesOrient) { }

	// RVA: 0x199DEA0 Offset: 0x199C4A0 VA: 0x18199DEA0
	public LTDescr setOrientToPath2d(bool doesOrient2d) { }

	// RVA: 0x199E150 Offset: 0x199C750 VA: 0x18199E150
	public LTDescr setRect(LTRect rect) { }

	// RVA: 0x199E1B0 Offset: 0x199C7B0 VA: 0x18199E1B0
	public LTDescr setRect(Rect rect) { }

	// RVA: 0x199E0E0 Offset: 0x199C6E0 VA: 0x18199E0E0
	public LTDescr setPath(LTBezierPath path) { }

	// RVA: 0x199E120 Offset: 0x199C720 VA: 0x18199E120
	public LTDescr setPoint(Vector3 point) { }

	// RVA: 0x199A640 Offset: 0x1998C40 VA: 0x18199A640
	public LTDescr setDestroyOnComplete(bool doesDestroy) { }

	// RVA: 0x1999840 Offset: 0x1997E40 VA: 0x181999840
	public LTDescr setAudio(object audio) { }

	// RVA: 0x199D950 Offset: 0x199BF50 VA: 0x18199D950
	public LTDescr setOnCompleteOnRepeat(bool isOn) { }

	// RVA: 0x199D960 Offset: 0x199BF60 VA: 0x18199D960
	public LTDescr setOnCompleteOnStart(bool isOn) { }

	// RVA: 0x199E180 Offset: 0x199C780 VA: 0x18199E180
	public LTDescr setRect(RectTransform rect) { }

	// RVA: 0x199EBD0 Offset: 0x199D1D0 VA: 0x18199EBD0
	public LTDescr setSprites(Sprite[] sprites) { }

	// RVA: 0x199C600 Offset: 0x199AC00 VA: 0x18199C600
	public LTDescr setFrameRate(float frameRate) { }

	// RVA: 0x199DAA0 Offset: 0x199C0A0 VA: 0x18199DAA0
	public LTDescr setOnStart(Action onStart) { }

	// RVA: 0x199A670 Offset: 0x1998C70 VA: 0x18199A670
	public LTDescr setDirection(float direction) { }

	// RVA: 0x199E250 Offset: 0x199C850 VA: 0x18199E250
	public LTDescr setRecursive(bool useRecursion) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992FB0 Offset: 0x19915B0 VA: 0x181992FB0
	private void <setMoveX>b__71_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992FE0 Offset: 0x19915E0 VA: 0x181992FE0
	private void <setMoveX>b__71_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19930D0 Offset: 0x19916D0 VA: 0x1819930D0
	private void <setMoveY>b__72_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993110 Offset: 0x1991710 VA: 0x181993110
	private void <setMoveY>b__72_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993210 Offset: 0x1991810 VA: 0x181993210
	private void <setMoveZ>b__73_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993250 Offset: 0x1991850 VA: 0x181993250
	private void <setMoveZ>b__73_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992790 Offset: 0x1990D90 VA: 0x181992790
	private void <setMoveLocalX>b__74_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19927C0 Offset: 0x1990DC0 VA: 0x1819927C0
	private void <setMoveLocalX>b__74_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19928B0 Offset: 0x1990EB0 VA: 0x1819928B0
	private void <setMoveLocalY>b__75_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19928F0 Offset: 0x1990EF0 VA: 0x1819928F0
	private void <setMoveLocalY>b__75_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19929F0 Offset: 0x1990FF0 VA: 0x1819929F0
	private void <setMoveLocalZ>b__76_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992A30 Offset: 0x1991030 VA: 0x181992A30
	private void <setMoveLocalZ>b__76_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992320 Offset: 0x1990920 VA: 0x181992320
	private void <setMoveCurved>b__78_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991EF0 Offset: 0x19904F0 VA: 0x181991EF0
	private void <setMoveCurvedLocal>b__79_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992C10 Offset: 0x1991210 VA: 0x181992C10
	private void <setMoveSpline>b__80_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992B10 Offset: 0x1991110 VA: 0x181992B10
	private void <setMoveSplineLocal>b__81_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19943E0 Offset: 0x19929E0 VA: 0x1819943E0
	private void <setScaleX>b__82_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994410 Offset: 0x1992A10 VA: 0x181994410
	private void <setScaleX>b__82_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994500 Offset: 0x1992B00 VA: 0x181994500
	private void <setScaleY>b__83_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994540 Offset: 0x1992B40 VA: 0x181994540
	private void <setScaleY>b__83_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994640 Offset: 0x1992C40 VA: 0x181994640
	private void <setScaleZ>b__84_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994680 Offset: 0x1992C80 VA: 0x181994680
	private void <setScaleZ>b__84_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993E40 Offset: 0x1992440 VA: 0x181993E40
	private void <setRotateX>b__85_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993EE0 Offset: 0x19924E0 VA: 0x181993EE0
	private void <setRotateX>b__85_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993FD0 Offset: 0x19925D0 VA: 0x181993FD0
	private void <setRotateY>b__86_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994070 Offset: 0x1992670 VA: 0x181994070
	private void <setRotateY>b__86_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994170 Offset: 0x1992770 VA: 0x181994170
	private void <setRotateZ>b__87_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994220 Offset: 0x1992820 VA: 0x181994220
	private void <setRotateZ>b__87_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993720 Offset: 0x1991D20 VA: 0x181993720
	private void <setRotateAround>b__88_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993770 Offset: 0x1991D70 VA: 0x181993770
	private void <setRotateAround>b__88_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993330 Offset: 0x1991930 VA: 0x181993330
	private void <setRotateAroundLocal>b__89_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993380 Offset: 0x1991980 VA: 0x181993380
	private void <setRotateAroundLocal>b__89_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198EE80 Offset: 0x198D480 VA: 0x18198EE80
	private void <setAlpha>b__90_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198F580 Offset: 0x198DB80 VA: 0x18198F580
	private void <setAlpha>b__90_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198F390 Offset: 0x198D990 VA: 0x18198F390
	private void <setAlpha>b__90_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994760 Offset: 0x1992D60 VA: 0x181994760
	private void <setTextAlpha>b__91_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994850 Offset: 0x1992E50 VA: 0x181994850
	private void <setTextAlpha>b__91_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198F750 Offset: 0x198DD50 VA: 0x18198F750
	private void <setAlphaVertex>b__92_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198F7E0 Offset: 0x198DDE0 VA: 0x18198F7E0
	private void <setAlphaVertex>b__92_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19911E0 Offset: 0x198F7E0 VA: 0x1819911E0
	private void <setColor>b__93_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19916C0 Offset: 0x198FCC0 VA: 0x1819916C0
	private void <setColor>b__93_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198FA60 Offset: 0x198E060 VA: 0x18198FA60
	private void <setCallbackColor>b__94_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198FAB0 Offset: 0x198E0B0 VA: 0x18198FAB0
	private void <setCallbackColor>b__94_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19948A0 Offset: 0x1992EA0 VA: 0x1819948A0
	private void <setTextColor>b__95_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19949A0 Offset: 0x1992FA0 VA: 0x1819949A0
	private void <setTextColor>b__95_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198FC80 Offset: 0x198E280 VA: 0x18198FC80
	private void <setCanvasAlpha>b__96_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198FDE0 Offset: 0x198E3E0 VA: 0x18198FDE0
	private void <setCanvasAlpha>b__96_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990350 Offset: 0x198E950 VA: 0x181990350
	private void <setCanvasGroupAlpha>b__97_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19903B0 Offset: 0x198E9B0 VA: 0x1819903B0
	private void <setCanvasGroupAlpha>b__97_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198FFF0 Offset: 0x198E5F0 VA: 0x18198FFF0
	private void <setCanvasColor>b__98_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990190 Offset: 0x198E790 VA: 0x181990190
	private void <setCanvasColor>b__98_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19904D0 Offset: 0x198EAD0 VA: 0x1819904D0
	private void <setCanvasMoveX>b__99_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990510 Offset: 0x198EB10 VA: 0x181990510
	private void <setCanvasMoveX>b__99_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19905D0 Offset: 0x198EBD0 VA: 0x1819905D0
	private void <setCanvasMoveY>b__100_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990610 Offset: 0x198EC10 VA: 0x181990610
	private void <setCanvasMoveY>b__100_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19906D0 Offset: 0x198ECD0 VA: 0x1819906D0
	private void <setCanvasMoveZ>b__101_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990710 Offset: 0x198ED10 VA: 0x181990710
	private void <setCanvasMoveZ>b__101_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990D00 Offset: 0x198F300 VA: 0x181990D00
	private void <setCanvasRotateAround>b__103_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19909D0 Offset: 0x198EFD0 VA: 0x1819909D0
	private void <setCanvasRotateAroundLocal>b__104_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19907E0 Offset: 0x198EDE0 VA: 0x1819907E0
	private void <setCanvasPlaySprite>b__105_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990840 Offset: 0x198EE40 VA: 0x181990840
	private void <setCanvasPlaySprite>b__105_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990430 Offset: 0x198EA30 VA: 0x181990430
	private void <setCanvasMove>b__106_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990470 Offset: 0x198EA70 VA: 0x181990470
	private void <setCanvasMove>b__106_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990FF0 Offset: 0x198F5F0 VA: 0x181990FF0
	private void <setCanvasScale>b__107_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991030 Offset: 0x198F630 VA: 0x181991030
	private void <setCanvasScale>b__107_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991090 Offset: 0x198F690 VA: 0x181991090
	private void <setCanvasSizeDelta>b__108_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991130 Offset: 0x198F730 VA: 0x181991130
	private void <setCanvasSizeDelta>b__108_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992D10 Offset: 0x1991310 VA: 0x181992D10
	private void <setMove>b__112_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992F10 Offset: 0x1991510 VA: 0x181992F10
	private void <setMove>b__112_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19926B0 Offset: 0x1990CB0 VA: 0x1819926B0
	private void <setMoveLocal>b__113_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19926F0 Offset: 0x1990CF0 VA: 0x1819926F0
	private void <setMoveLocal>b__113_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992D10 Offset: 0x1991310 VA: 0x181992D10
	private void <setMoveToTransform>b__114_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992D50 Offset: 0x1991350 VA: 0x181992D50
	private void <setMoveToTransform>b__114_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993C70 Offset: 0x1992270 VA: 0x181993C70
	private void <setRotate>b__115_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993DA0 Offset: 0x19923A0 VA: 0x181993DA0
	private void <setRotate>b__115_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993AA0 Offset: 0x19920A0 VA: 0x181993AA0
	private void <setRotateLocal>b__116_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993BD0 Offset: 0x19921D0 VA: 0x181993BD0
	private void <setRotateLocal>b__116_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994300 Offset: 0x1992900 VA: 0x181994300
	private void <setScale>b__117_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994340 Offset: 0x1992940 VA: 0x181994340
	private void <setScale>b__117_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991A60 Offset: 0x1990060 VA: 0x181991A60
	private void <setGUIMove>b__118_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991B30 Offset: 0x1990130 VA: 0x181991B30
	private void <setGUIMove>b__118_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991920 Offset: 0x198FF20 VA: 0x181991920
	private void <setGUIMoveMargin>b__119_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19919D0 Offset: 0x198FFD0 VA: 0x1819919D0
	private void <setGUIMoveMargin>b__119_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991D10 Offset: 0x1990310 VA: 0x181991D10
	private void <setGUIScale>b__120_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991DE0 Offset: 0x19903E0 VA: 0x181991DE0
	private void <setGUIScale>b__120_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19918A0 Offset: 0x198FEA0 VA: 0x1819918A0
	private void <setGUIAlpha>b__121_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19918D0 Offset: 0x198FED0 VA: 0x1819918D0
	private void <setGUIAlpha>b__121_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991C50 Offset: 0x1990250 VA: 0x181991C50
	private void <setGUIRotate>b__122_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991CC0 Offset: 0x19902C0 VA: 0x181991CC0
	private void <setGUIRotate>b__122_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991890 Offset: 0x198FE90 VA: 0x181991890
	private void <setDelayedSound>b__123_0() { }

}

public sealed class LTDescr.EaseTypeDelegate : MulticastDelegate // TypeDefIndex: 5570
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x198AA10 Offset: 0x1989010 VA: 0x18198AA10 Slot: 12
	public virtual Vector3 Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x198A9D0 Offset: 0x1988FD0 VA: 0x18198A9D0 Slot: 14
	public virtual Vector3 EndInvoke(IAsyncResult result) { }

}

public sealed class LTDescr.ActionMethodDelegate : MulticastDelegate // TypeDefIndex: 5571
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14647E0 Offset: 0x1462DE0 VA: 0x1814647E0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class LTDescr.<>c // TypeDefIndex: 5572
{	// Fields
	public static readonly LTDescr.<>c <>9; // 0x0
	public static LTDescr.ActionMethodDelegate <>9__110_0; // 0x8
	public static LTDescr.ActionMethodDelegate <>9__111_0; // 0x10

	// Methods

	// RVA: 0x19A4E00 Offset: 0x19A3400 VA: 0x1819A4E00
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <setCallback>b__110_0() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <setValue3>b__111_0() { }

}

