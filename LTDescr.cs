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

	// RVA: 0x1998D00 Offset: 0x1997300 VA: 0x181998D00
	public Vector3 get_from() { }

	// RVA: 0x199ED80 Offset: 0x199D380 VA: 0x18199ED80
	public void set_from(Vector3 value) { }

	// RVA: 0x1998D30 Offset: 0x1997330 VA: 0x181998D30
	public Vector3 get_to() { }

	// RVA: 0x199EDA0 Offset: 0x199D3A0 VA: 0x18199EDA0
	public void set_to(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9921A0 Offset: 0x9907A0 VA: 0x1809921A0
	public LTDescr.ActionMethodDelegate get_easeInternal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D220 Offset: 0xA4B820 VA: 0x180A4D220
	public void set_easeInternal(LTDescr.ActionMethodDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7ACF70 Offset: 0x7AB570 VA: 0x1807ACF70
	public LTDescr.ActionMethodDelegate get_initInternal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D230 Offset: 0xA4B830 VA: 0x180A4D230
	public void set_initInternal(LTDescr.ActionMethodDelegate value) { }

	// RVA: 0x198DF60 Offset: 0x198C560 VA: 0x18198DF60 Slot: 3
	public override string ToString() { }

	// RVA: 0x1994830 Offset: 0x1992E30 VA: 0x181994830
	public void .ctor() { }

	[ObsoleteAttribute] // RVA: 0xA8020 Offset: 0xA7420 VA: 0x1800A8020
	// RVA: 0x1995410 Offset: 0x1993A10 VA: 0x181995410
	public LTDescr cancel(GameObject gameObject) { }

	// RVA: 0x1998D20 Offset: 0x1997320 VA: 0x181998D20
	public int get_uniqueId() { }

	// RVA: 0x1998D20 Offset: 0x1997320 VA: 0x181998D20
	public int get_id() { }

	// RVA: 0xC73B60 Offset: 0xC72160 VA: 0x180C73B60
	public LTDescrOptional get_optional() { }

	// RVA: 0x199ED90 Offset: 0x199D390 VA: 0x18199ED90
	public void set_optional(LTDescrOptional value) { }

	// RVA: 0x1999140 Offset: 0x1997740 VA: 0x181999140
	public void reset() { }

	// RVA: 0x199D350 Offset: 0x199B950 VA: 0x18199D350
	public LTDescr setMoveX() { }

	// RVA: 0x199D420 Offset: 0x199BA20 VA: 0x18199D420
	public LTDescr setMoveY() { }

	// RVA: 0x199D4F0 Offset: 0x199BAF0 VA: 0x18199D4F0
	public LTDescr setMoveZ() { }

	// RVA: 0x199CDA0 Offset: 0x199B3A0 VA: 0x18199CDA0
	public LTDescr setMoveLocalX() { }

	// RVA: 0x199CE70 Offset: 0x199B470 VA: 0x18199CE70
	public LTDescr setMoveLocalY() { }

	// RVA: 0x199CF40 Offset: 0x199B540 VA: 0x18199CF40
	public LTDescr setMoveLocalZ() { }

	// RVA: 0x1998DA0 Offset: 0x19973A0 VA: 0x181998DA0
	private void initFromInternal() { }

	// RVA: 0x199CCD0 Offset: 0x199B2D0 VA: 0x18199CCD0
	public LTDescr setMoveCurved() { }

	// RVA: 0x199CC00 Offset: 0x199B200 VA: 0x18199CC00
	public LTDescr setMoveCurvedLocal() { }

	// RVA: 0x199D1B0 Offset: 0x199B7B0 VA: 0x18199D1B0
	public LTDescr setMoveSpline() { }

	// RVA: 0x199D0E0 Offset: 0x199B6E0 VA: 0x18199D0E0
	public LTDescr setMoveSplineLocal() { }

	// RVA: 0x199E590 Offset: 0x199CB90 VA: 0x18199E590
	public LTDescr setScaleX() { }

	// RVA: 0x199E660 Offset: 0x199CC60 VA: 0x18199E660
	public LTDescr setScaleY() { }

	// RVA: 0x199E730 Offset: 0x199CD30 VA: 0x18199E730
	public LTDescr setScaleZ() { }

	// RVA: 0x199E250 Offset: 0x199C850 VA: 0x18199E250
	public LTDescr setRotateX() { }

	// RVA: 0x199E320 Offset: 0x199C920 VA: 0x18199E320
	public LTDescr setRotateY() { }

	// RVA: 0x199E3F0 Offset: 0x199C9F0 VA: 0x18199E3F0
	public LTDescr setRotateZ() { }

	// RVA: 0x199E0B0 Offset: 0x199C6B0 VA: 0x18199E0B0
	public LTDescr setRotateAround() { }

	// RVA: 0x199DFE0 Offset: 0x199C5E0 VA: 0x18199DFE0
	public LTDescr setRotateAroundLocal() { }

	// RVA: 0x19994B0 Offset: 0x1997AB0 VA: 0x1819994B0
	public LTDescr setAlpha() { }

	// RVA: 0x199E940 Offset: 0x199CF40 VA: 0x18199E940
	public LTDescr setTextAlpha() { }

	// RVA: 0x19993E0 Offset: 0x19979E0 VA: 0x1819993E0
	public LTDescr setAlphaVertex() { }

	// RVA: 0x199A1D0 Offset: 0x19987D0 VA: 0x18199A1D0
	public LTDescr setColor() { }

	// RVA: 0x19995F0 Offset: 0x1997BF0 VA: 0x1819995F0
	public LTDescr setCallbackColor() { }

	// RVA: 0x199EA10 Offset: 0x199D010 VA: 0x18199EA10
	public LTDescr setTextColor() { }

	// RVA: 0x1999810 Offset: 0x1997E10 VA: 0x181999810
	public LTDescr setCanvasAlpha() { }

	// RVA: 0x19999B0 Offset: 0x1997FB0 VA: 0x1819999B0
	public LTDescr setCanvasGroupAlpha() { }

	// RVA: 0x19998E0 Offset: 0x1997EE0 VA: 0x1819998E0
	public LTDescr setCanvasColor() { }

	// RVA: 0x1999A80 Offset: 0x1998080 VA: 0x181999A80
	public LTDescr setCanvasMoveX() { }

	// RVA: 0x1999B50 Offset: 0x1998150 VA: 0x181999B50
	public LTDescr setCanvasMoveY() { }

	// RVA: 0x1999C20 Offset: 0x1998220 VA: 0x181999C20
	public LTDescr setCanvasMoveZ() { }

	// RVA: 0x1998D50 Offset: 0x1997350 VA: 0x181998D50
	private void initCanvasRotateAround() { }

	// RVA: 0x1999F60 Offset: 0x1998560 VA: 0x181999F60
	public LTDescr setCanvasRotateAround() { }

	// RVA: 0x1999E90 Offset: 0x1998490 VA: 0x181999E90
	public LTDescr setCanvasRotateAroundLocal() { }

	// RVA: 0x1999DC0 Offset: 0x19983C0 VA: 0x181999DC0
	public LTDescr setCanvasPlaySprite() { }

	// RVA: 0x1999CF0 Offset: 0x19982F0 VA: 0x181999CF0
	public LTDescr setCanvasMove() { }

	// RVA: 0x199A030 Offset: 0x1998630 VA: 0x18199A030
	public LTDescr setCanvasScale() { }

	// RVA: 0x199A100 Offset: 0x1998700 VA: 0x18199A100
	public LTDescr setCanvasSizeDelta() { }

	// RVA: 0x1995390 Offset: 0x1993990 VA: 0x181995390
	private void callback() { }

	// RVA: 0x19996C0 Offset: 0x1997CC0 VA: 0x1819996C0
	public LTDescr setCallback() { }

	// RVA: 0x199EC30 Offset: 0x199D230 VA: 0x18199EC30
	public LTDescr setValue3() { }

	// RVA: 0x199D5C0 Offset: 0x199BBC0 VA: 0x18199D5C0
	public LTDescr setMove() { }

	// RVA: 0x199D010 Offset: 0x199B610 VA: 0x18199D010
	public LTDescr setMoveLocal() { }

	// RVA: 0x199D280 Offset: 0x199B880 VA: 0x18199D280
	public LTDescr setMoveToTransform() { }

	// RVA: 0x199E4C0 Offset: 0x199CAC0 VA: 0x18199E4C0
	public LTDescr setRotate() { }

	// RVA: 0x199E180 Offset: 0x199C780 VA: 0x18199E180
	public LTDescr setRotateLocal() { }

	// RVA: 0x199E810 Offset: 0x199CE10 VA: 0x18199E810
	public LTDescr setScale() { }

	// RVA: 0x199C8C0 Offset: 0x199AEC0 VA: 0x18199C8C0
	public LTDescr setGUIMove() { }

	// RVA: 0x199C7F0 Offset: 0x199ADF0 VA: 0x18199C7F0
	public LTDescr setGUIMoveMargin() { }

	// RVA: 0x199CA60 Offset: 0x199B060 VA: 0x18199CA60
	public LTDescr setGUIScale() { }

	// RVA: 0x199C720 Offset: 0x199AD20 VA: 0x18199C720
	public LTDescr setGUIAlpha() { }

	// RVA: 0x199C990 Offset: 0x199AF90 VA: 0x18199C990
	public LTDescr setGUIRotate() { }

	// RVA: 0x199A2B0 Offset: 0x19988B0 VA: 0x18199A2B0
	public LTDescr setDelayedSound() { }

	// RVA: 0x1998F20 Offset: 0x1997520 VA: 0x181998F20
	private void init() { }

	// RVA: 0x1998DB0 Offset: 0x19973B0 VA: 0x181998DB0
	private void initSpeed() { }

	// RVA: 0x199FD10 Offset: 0x199E310 VA: 0x18199FD10
	public LTDescr updateNow() { }

	// RVA: 0x199F820 Offset: 0x199DE20 VA: 0x18199F820
	public bool updateInternal() { }

	// RVA: 0x1995270 Offset: 0x1993870 VA: 0x181995270
	public void callOnCompletes() { }

	// RVA: 0x199C370 Offset: 0x199A970 VA: 0x18199C370
	public LTDescr setFromColor(Color col) { }

	// RVA: 0x1994E20 Offset: 0x1993420 VA: 0x181994E20
	private static void alphaRecursive(Transform transform, float val, bool useRecursion = True) { }

	// RVA: 0x1995780 Offset: 0x1993D80 VA: 0x181995780
	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = True) { }

	// RVA: 0x1994B40 Offset: 0x1993140 VA: 0x181994B40
	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0) { }

	// RVA: 0x19948A0 Offset: 0x1992EA0 VA: 0x1819948A0
	private static void alphaRecursiveSprite(Transform transform, float val) { }

	// RVA: 0x19954E0 Offset: 0x1993AE0 VA: 0x1819954E0
	private static void colorRecursiveSprite(Transform transform, Color toColor) { }

	// RVA: 0x1995A70 Offset: 0x1994070 VA: 0x181995A70
	private static void colorRecursive(RectTransform rectTransform, Color toColor) { }

	// RVA: 0x199EDB0 Offset: 0x199D3B0 VA: 0x18199EDB0
	private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = True) { }

	// RVA: 0x199F020 Offset: 0x199D620 VA: 0x18199F020
	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = True) { }

	// RVA: 0x199F2D0 Offset: 0x199D8D0 VA: 0x18199F2D0
	private static void textColorRecursive(Transform trans, Color toColor) { }

	// RVA: 0x199F500 Offset: 0x199DB00 VA: 0x18199F500
	private static Color tweenColor(LTDescr tween, float val) { }

	// RVA: 0x1999120 Offset: 0x1997720 VA: 0x181999120
	public LTDescr pause() { }

	// RVA: 0x19993D0 Offset: 0x19979D0 VA: 0x1819993D0
	public LTDescr resume() { }

	// RVA: 0x19995C0 Offset: 0x1997BC0 VA: 0x1819995C0
	public LTDescr setAxis(Vector3 axis) { }

	// RVA: 0x199A2A0 Offset: 0x19988A0 VA: 0x18199A2A0
	public LTDescr setDelay(float delay) { }

	// RVA: 0x199B9E0 Offset: 0x1999FE0 VA: 0x18199B9E0
	public LTDescr setEase(LeanTweenType easeType) { }

	// RVA: 0x199B0B0 Offset: 0x19996B0 VA: 0x18199B0B0
	public LTDescr setEaseLinear() { }

	// RVA: 0x199B8A0 Offset: 0x1999EA0 VA: 0x18199B8A0
	public LTDescr setEaseSpring() { }

	// RVA: 0x199AE70 Offset: 0x1999470 VA: 0x18199AE70
	public LTDescr setEaseInQuad() { }

	// RVA: 0x199B4A0 Offset: 0x1999AA0 VA: 0x18199B4A0
	public LTDescr setEaseOutQuad() { }

	// RVA: 0x199AC30 Offset: 0x1999230 VA: 0x18199AC30
	public LTDescr setEaseInOutQuad() { }

	// RVA: 0x199A720 Offset: 0x1998D20 VA: 0x18199A720
	public LTDescr setEaseInCubic() { }

	// RVA: 0x199B2F0 Offset: 0x19998F0 VA: 0x18199B2F0
	public LTDescr setEaseOutCubic() { }

	// RVA: 0x199AA80 Offset: 0x1999080 VA: 0x18199AA80
	public LTDescr setEaseInOutCubic() { }

	// RVA: 0x199AF00 Offset: 0x1999500 VA: 0x18199AF00
	public LTDescr setEaseInQuart() { }

	// RVA: 0x199B530 Offset: 0x1999B30 VA: 0x18199B530
	public LTDescr setEaseOutQuart() { }

	// RVA: 0x199ACC0 Offset: 0x19992C0 VA: 0x18199ACC0
	public LTDescr setEaseInOutQuart() { }

	// RVA: 0x199AF90 Offset: 0x1999590 VA: 0x18199AF90
	public LTDescr setEaseInQuint() { }

	// RVA: 0x199B5C0 Offset: 0x1999BC0 VA: 0x18199B5C0
	public LTDescr setEaseOutQuint() { }

	// RVA: 0x199AD50 Offset: 0x1999350 VA: 0x18199AD50
	public LTDescr setEaseInOutQuint() { }

	// RVA: 0x199B020 Offset: 0x1999620 VA: 0x18199B020
	public LTDescr setEaseInSine() { }

	// RVA: 0x199B650 Offset: 0x1999C50 VA: 0x18199B650
	public LTDescr setEaseOutSine() { }

	// RVA: 0x199ADE0 Offset: 0x19993E0 VA: 0x18199ADE0
	public LTDescr setEaseInOutSine() { }

	// RVA: 0x199A840 Offset: 0x1998E40 VA: 0x18199A840
	public LTDescr setEaseInExpo() { }

	// RVA: 0x199B410 Offset: 0x1999A10 VA: 0x18199B410
	public LTDescr setEaseOutExpo() { }

	// RVA: 0x199ABA0 Offset: 0x19991A0 VA: 0x18199ABA0
	public LTDescr setEaseInOutExpo() { }

	// RVA: 0x199A690 Offset: 0x1998C90 VA: 0x18199A690
	public LTDescr setEaseInCirc() { }

	// RVA: 0x199B260 Offset: 0x1999860 VA: 0x18199B260
	public LTDescr setEaseOutCirc() { }

	// RVA: 0x199A9F0 Offset: 0x1998FF0 VA: 0x18199A9F0
	public LTDescr setEaseInOutCirc() { }

	// RVA: 0x199A600 Offset: 0x1998C00 VA: 0x18199A600
	public LTDescr setEaseInBounce() { }

	// RVA: 0x199B1D0 Offset: 0x19997D0 VA: 0x18199B1D0
	public LTDescr setEaseOutBounce() { }

	// RVA: 0x199A960 Offset: 0x1998F60 VA: 0x18199A960
	public LTDescr setEaseInOutBounce() { }

	// RVA: 0x199A570 Offset: 0x1998B70 VA: 0x18199A570
	public LTDescr setEaseInBack() { }

	// RVA: 0x199B140 Offset: 0x1999740 VA: 0x18199B140
	public LTDescr setEaseOutBack() { }

	// RVA: 0x199A8D0 Offset: 0x1998ED0 VA: 0x18199A8D0
	public LTDescr setEaseInOutBack() { }

	// RVA: 0x199A7B0 Offset: 0x1998DB0 VA: 0x18199A7B0
	public LTDescr setEaseInElastic() { }

	// RVA: 0x199B380 Offset: 0x1999980 VA: 0x18199B380
	public LTDescr setEaseOutElastic() { }

	// RVA: 0x199AB10 Offset: 0x1999110 VA: 0x18199AB10
	public LTDescr setEaseInOutElastic() { }

	// RVA: 0x199B6E0 Offset: 0x1999CE0 VA: 0x18199B6E0
	public LTDescr setEasePunch() { }

	// RVA: 0x199B7C0 Offset: 0x1999DC0 VA: 0x18199B7C0
	public LTDescr setEaseShake() { }

	// RVA: 0x199F6C0 Offset: 0x199DCC0 VA: 0x18199F6C0
	private Vector3 tweenOnCurve() { }

	// RVA: 0x1997190 Offset: 0x1995790 VA: 0x181997190
	private Vector3 easeInOutQuad() { }

	// RVA: 0x1997790 Offset: 0x1995D90 VA: 0x181997790
	private Vector3 easeInQuad() { }

	// RVA: 0x1998630 Offset: 0x1996C30 VA: 0x181998630
	private Vector3 easeOutQuad() { }

	// RVA: 0x1997C30 Offset: 0x1996230 VA: 0x181997C30
	private Vector3 easeLinear() { }

	// RVA: 0x1998B20 Offset: 0x1997120 VA: 0x181998B20
	private Vector3 easeSpring() { }

	// RVA: 0x1996190 Offset: 0x1994790 VA: 0x181996190
	private Vector3 easeInCubic() { }

	// RVA: 0x1998250 Offset: 0x1996850 VA: 0x181998250
	private Vector3 easeOutCubic() { }

	// RVA: 0x1996C60 Offset: 0x1995260 VA: 0x181996C60
	private Vector3 easeInOutCubic() { }

	// RVA: 0x1997890 Offset: 0x1995E90 VA: 0x181997890
	private Vector3 easeInQuart() { }

	// RVA: 0x1998760 Offset: 0x1996D60 VA: 0x181998760
	private Vector3 easeOutQuart() { }

	// RVA: 0x19972C0 Offset: 0x19958C0 VA: 0x1819972C0
	private Vector3 easeInOutQuart() { }

	// RVA: 0x19979B0 Offset: 0x1995FB0 VA: 0x1819979B0
	private Vector3 easeInQuint() { }

	// RVA: 0x1998890 Offset: 0x1996E90 VA: 0x181998890
	private Vector3 easeOutQuint() { }

	// RVA: 0x19974F0 Offset: 0x1995AF0 VA: 0x1819974F0
	private Vector3 easeInOutQuint() { }

	// RVA: 0x1997AC0 Offset: 0x19960C0 VA: 0x181997AC0
	private Vector3 easeInSine() { }

	// RVA: 0x19989C0 Offset: 0x1996FC0 VA: 0x1819989C0
	private Vector3 easeOutSine() { }

	// RVA: 0x1997650 Offset: 0x1995C50 VA: 0x181997650
	private Vector3 easeInOutSine() { }

	// RVA: 0x1996410 Offset: 0x1994A10 VA: 0x181996410
	private Vector3 easeInExpo() { }

	// RVA: 0x19984F0 Offset: 0x1996AF0 VA: 0x1819984F0
	private Vector3 easeOutExpo() { }

	// RVA: 0x1996F30 Offset: 0x1995530 VA: 0x181996F30
	private Vector3 easeInOutExpo() { }

	// RVA: 0x1996050 Offset: 0x1994650 VA: 0x181996050
	private Vector3 easeInCirc() { }

	// RVA: 0x1998100 Offset: 0x1996700 VA: 0x181998100
	private Vector3 easeOutCirc() { }

	// RVA: 0x1996AA0 Offset: 0x19950A0 VA: 0x181996AA0
	private Vector3 easeInOutCirc() { }

	// RVA: 0x1995E90 Offset: 0x1994490 VA: 0x181995E90
	private Vector3 easeInBounce() { }

	// RVA: 0x1997E70 Offset: 0x1996470 VA: 0x181997E70
	private Vector3 easeOutBounce() { }

	// RVA: 0x19967B0 Offset: 0x1994DB0 VA: 0x1819967B0
	private Vector3 easeInOutBounce() { }

	// RVA: 0x1995CE0 Offset: 0x19942E0 VA: 0x181995CE0
	private Vector3 easeInBack() { }

	// RVA: 0x1997D10 Offset: 0x1996310 VA: 0x181997D10
	private Vector3 easeOutBack() { }

	// RVA: 0x1996550 Offset: 0x1994B50 VA: 0x181996550
	private Vector3 easeInOutBack() { }

	// RVA: 0x1996290 Offset: 0x1994890 VA: 0x181996290
	private Vector3 easeInElastic() { }

	// RVA: 0x1998370 Offset: 0x1996970 VA: 0x181998370
	private Vector3 easeOutElastic() { }

	// RVA: 0x1996DB0 Offset: 0x19953B0 VA: 0x181996DB0
	private Vector3 easeInOutElastic() { }

	// RVA: 0x199DE00 Offset: 0x199C400 VA: 0x18199DE00
	public LTDescr setOvershoot(float overshoot) { }

	// RVA: 0x199DE50 Offset: 0x199C450 VA: 0x18199DE50
	public LTDescr setPeriod(float period) { }

	// RVA: 0x199E800 Offset: 0x199CE00 VA: 0x18199E800
	public LTDescr setScale(float scale) { }

	// RVA: 0x199B930 Offset: 0x1999F30 VA: 0x18199B930
	public LTDescr setEase(AnimationCurve easeCurve) { }

	// RVA: 0x199EB00 Offset: 0x199D100 VA: 0x18199EB00
	public LTDescr setTo(Vector3 to) { }

	// RVA: 0x199EBE0 Offset: 0x199D1E0 VA: 0x18199EBE0
	public LTDescr setTo(Transform to) { }

	// RVA: 0x199C460 Offset: 0x199AA60 VA: 0x18199C460
	public LTDescr setFrom(Vector3 from) { }

	// RVA: 0x199C5B0 Offset: 0x199ABB0 VA: 0x18199C5B0
	public LTDescr setFrom(float from) { }

	// RVA: 0x199A390 Offset: 0x1998990 VA: 0x18199A390
	public LTDescr setDiff(Vector3 diff) { }

	// RVA: 0x199CB30 Offset: 0x199B130 VA: 0x18199CB30
	public LTDescr setHasInitialized(bool has) { }

	// RVA: 0x199CB40 Offset: 0x199B140 VA: 0x18199CB40
	public LTDescr setId(uint id, uint global_counter) { }

	// RVA: 0x199DE10 Offset: 0x199C410 VA: 0x18199DE10
	public LTDescr setPassed(float passed) { }

	// RVA: 0x199EAE0 Offset: 0x199D0E0 VA: 0x18199EAE0
	public LTDescr setTime(float time) { }

	// RVA: 0x199E8E0 Offset: 0x199CEE0 VA: 0x18199E8E0
	public LTDescr setSpeed(float speed) { }

	// RVA: 0x199DFA0 Offset: 0x199C5A0 VA: 0x18199DFA0
	public LTDescr setRepeat(int repeat) { }

	// RVA: 0x199CBF0 Offset: 0x199B1F0 VA: 0x18199CBF0
	public LTDescr setLoopType(LeanTweenType loopType) { }

	// RVA: 0x199CB50 Offset: 0x199B150 VA: 0x18199CB50
	public LTDescr setUseEstimatedTime(bool useEstimatedTime) { }

	// RVA: 0x199CB50 Offset: 0x199B150 VA: 0x18199CB50
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime) { }

	// RVA: 0x199EC10 Offset: 0x199D210 VA: 0x18199EC10
	public LTDescr setUseFrames(bool useFrames) { }

	// RVA: 0x199EC20 Offset: 0x199D220 VA: 0x18199EC20
	public LTDescr setUseManualTime(bool useManualTime) { }

	// RVA: 0x199CB80 Offset: 0x199B180 VA: 0x18199CB80
	public LTDescr setLoopCount(int loopCount) { }

	// RVA: 0x199CBA0 Offset: 0x199B1A0 VA: 0x18199CBA0
	public LTDescr setLoopOnce() { }

	// RVA: 0x199CB60 Offset: 0x199B160 VA: 0x18199CB60
	public LTDescr setLoopClamp() { }

	// RVA: 0xE721E0 Offset: 0xE707E0 VA: 0x180E721E0
	public LTDescr setLoopClamp(int loops) { }

	// RVA: 0x199CBB0 Offset: 0x199B1B0 VA: 0x18199CBB0
	public LTDescr setLoopPingPong() { }

	// RVA: 0x199CBD0 Offset: 0x199B1D0 VA: 0x18199CBD0
	public LTDescr setLoopPingPong(int loops) { }

	// RVA: 0x199D760 Offset: 0x199BD60 VA: 0x18199D760
	public LTDescr setOnComplete(Action onComplete) { }

	// RVA: 0x199D7A0 Offset: 0x199BDA0 VA: 0x18199D7A0
	public LTDescr setOnComplete(Action<object> onComplete) { }

	// RVA: 0x199D6F0 Offset: 0x199BCF0 VA: 0x18199D6F0
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam) { }

	// RVA: 0x199D6B0 Offset: 0x199BCB0 VA: 0x18199D6B0
	public LTDescr setOnCompleteParam(object onCompleteParam) { }

	// RVA: 0x199DA50 Offset: 0x199C050 VA: 0x18199DA50
	public LTDescr setOnUpdate(Action<float> onUpdate) { }

	// RVA: 0x199D920 Offset: 0x199BF20 VA: 0x18199D920
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate) { }

	// RVA: 0x199D8A0 Offset: 0x199BEA0 VA: 0x18199D8A0
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate) { }

	// RVA: 0x199D960 Offset: 0x199BF60 VA: 0x18199D960
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate) { }

	// RVA: 0x199D9A0 Offset: 0x199BFA0 VA: 0x18199D9A0
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate) { }

	// RVA: 0x199D820 Offset: 0x199BE20 VA: 0x18199D820
	public LTDescr setOnUpdateColor(Action<Color> onUpdate) { }

	// RVA: 0x199D860 Offset: 0x199BE60 VA: 0x18199D860
	public LTDescr setOnUpdateColor(Action<Color, object> onUpdate) { }

	// RVA: 0x199D820 Offset: 0x199BE20 VA: 0x18199D820
	public LTDescr setOnUpdate(Action<Color> onUpdate) { }

	// RVA: 0x199D860 Offset: 0x199BE60 VA: 0x18199D860
	public LTDescr setOnUpdate(Action<Color, object> onUpdate) { }

	// RVA: 0x199DA90 Offset: 0x199C090 VA: 0x18199DA90
	public LTDescr setOnUpdate(Action<float, object> onUpdate, object onUpdateParam) { }

	// RVA: 0x199D9E0 Offset: 0x199BFE0 VA: 0x18199D9E0
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, object onUpdateParam) { }

	// RVA: 0x199DB00 Offset: 0x199C100 VA: 0x18199DB00
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, object onUpdateParam) { }

	// RVA: 0x199DB70 Offset: 0x199C170 VA: 0x18199DB70
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, object onUpdateParam) { }

	// RVA: 0x199D8E0 Offset: 0x199BEE0 VA: 0x18199D8E0
	public LTDescr setOnUpdateParam(object onUpdateParam) { }

	// RVA: 0x199DD10 Offset: 0x199C310 VA: 0x18199DD10
	public LTDescr setOrientToPath(bool doesOrient) { }

	// RVA: 0x199DBE0 Offset: 0x199C1E0 VA: 0x18199DBE0
	public LTDescr setOrientToPath2d(bool doesOrient2d) { }

	// RVA: 0x199DE90 Offset: 0x199C490 VA: 0x18199DE90
	public LTDescr setRect(LTRect rect) { }

	// RVA: 0x199DEF0 Offset: 0x199C4F0 VA: 0x18199DEF0
	public LTDescr setRect(Rect rect) { }

	// RVA: 0x199DE20 Offset: 0x199C420 VA: 0x18199DE20
	public LTDescr setPath(LTBezierPath path) { }

	// RVA: 0x199DE60 Offset: 0x199C460 VA: 0x18199DE60
	public LTDescr setPoint(Vector3 point) { }

	// RVA: 0x199A380 Offset: 0x1998980 VA: 0x18199A380
	public LTDescr setDestroyOnComplete(bool doesDestroy) { }

	// RVA: 0x1999580 Offset: 0x1997B80 VA: 0x181999580
	public LTDescr setAudio(object audio) { }

	// RVA: 0x199D690 Offset: 0x199BC90 VA: 0x18199D690
	public LTDescr setOnCompleteOnRepeat(bool isOn) { }

	// RVA: 0x199D6A0 Offset: 0x199BCA0 VA: 0x18199D6A0
	public LTDescr setOnCompleteOnStart(bool isOn) { }

	// RVA: 0x199DEC0 Offset: 0x199C4C0 VA: 0x18199DEC0
	public LTDescr setRect(RectTransform rect) { }

	// RVA: 0x199E910 Offset: 0x199CF10 VA: 0x18199E910
	public LTDescr setSprites(Sprite[] sprites) { }

	// RVA: 0x199C340 Offset: 0x199A940 VA: 0x18199C340
	public LTDescr setFrameRate(float frameRate) { }

	// RVA: 0x199D7E0 Offset: 0x199BDE0 VA: 0x18199D7E0
	public LTDescr setOnStart(Action onStart) { }

	// RVA: 0x199A3B0 Offset: 0x19989B0 VA: 0x18199A3B0
	public LTDescr setDirection(float direction) { }

	// RVA: 0x199DF90 Offset: 0x199C590 VA: 0x18199DF90
	public LTDescr setRecursive(bool useRecursion) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992CF0 Offset: 0x19912F0 VA: 0x181992CF0
	private void <setMoveX>b__71_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992D20 Offset: 0x1991320 VA: 0x181992D20
	private void <setMoveX>b__71_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992E10 Offset: 0x1991410 VA: 0x181992E10
	private void <setMoveY>b__72_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992E50 Offset: 0x1991450 VA: 0x181992E50
	private void <setMoveY>b__72_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992F50 Offset: 0x1991550 VA: 0x181992F50
	private void <setMoveZ>b__73_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992F90 Offset: 0x1991590 VA: 0x181992F90
	private void <setMoveZ>b__73_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19924D0 Offset: 0x1990AD0 VA: 0x1819924D0
	private void <setMoveLocalX>b__74_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992500 Offset: 0x1990B00 VA: 0x181992500
	private void <setMoveLocalX>b__74_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19925F0 Offset: 0x1990BF0 VA: 0x1819925F0
	private void <setMoveLocalY>b__75_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992630 Offset: 0x1990C30 VA: 0x181992630
	private void <setMoveLocalY>b__75_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992730 Offset: 0x1990D30 VA: 0x181992730
	private void <setMoveLocalZ>b__76_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992770 Offset: 0x1990D70 VA: 0x181992770
	private void <setMoveLocalZ>b__76_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992060 Offset: 0x1990660 VA: 0x181992060
	private void <setMoveCurved>b__78_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991C30 Offset: 0x1990230 VA: 0x181991C30
	private void <setMoveCurvedLocal>b__79_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992950 Offset: 0x1990F50 VA: 0x181992950
	private void <setMoveSpline>b__80_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992850 Offset: 0x1990E50 VA: 0x181992850
	private void <setMoveSplineLocal>b__81_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994120 Offset: 0x1992720 VA: 0x181994120
	private void <setScaleX>b__82_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994150 Offset: 0x1992750 VA: 0x181994150
	private void <setScaleX>b__82_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994240 Offset: 0x1992840 VA: 0x181994240
	private void <setScaleY>b__83_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994280 Offset: 0x1992880 VA: 0x181994280
	private void <setScaleY>b__83_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994380 Offset: 0x1992980 VA: 0x181994380
	private void <setScaleZ>b__84_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19943C0 Offset: 0x19929C0 VA: 0x1819943C0
	private void <setScaleZ>b__84_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993B80 Offset: 0x1992180 VA: 0x181993B80
	private void <setRotateX>b__85_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993C20 Offset: 0x1992220 VA: 0x181993C20
	private void <setRotateX>b__85_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993D10 Offset: 0x1992310 VA: 0x181993D10
	private void <setRotateY>b__86_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993DB0 Offset: 0x19923B0 VA: 0x181993DB0
	private void <setRotateY>b__86_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993EB0 Offset: 0x19924B0 VA: 0x181993EB0
	private void <setRotateZ>b__87_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993F60 Offset: 0x1992560 VA: 0x181993F60
	private void <setRotateZ>b__87_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993460 Offset: 0x1991A60 VA: 0x181993460
	private void <setRotateAround>b__88_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19934B0 Offset: 0x1991AB0 VA: 0x1819934B0
	private void <setRotateAround>b__88_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993070 Offset: 0x1991670 VA: 0x181993070
	private void <setRotateAroundLocal>b__89_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19930C0 Offset: 0x19916C0 VA: 0x1819930C0
	private void <setRotateAroundLocal>b__89_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198EBC0 Offset: 0x198D1C0 VA: 0x18198EBC0
	private void <setAlpha>b__90_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198F2C0 Offset: 0x198D8C0 VA: 0x18198F2C0
	private void <setAlpha>b__90_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198F0D0 Offset: 0x198D6D0 VA: 0x18198F0D0
	private void <setAlpha>b__90_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19944A0 Offset: 0x1992AA0 VA: 0x1819944A0
	private void <setTextAlpha>b__91_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994590 Offset: 0x1992B90 VA: 0x181994590
	private void <setTextAlpha>b__91_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198F490 Offset: 0x198DA90 VA: 0x18198F490
	private void <setAlphaVertex>b__92_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198F520 Offset: 0x198DB20 VA: 0x18198F520
	private void <setAlphaVertex>b__92_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990F20 Offset: 0x198F520 VA: 0x181990F20
	private void <setColor>b__93_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991400 Offset: 0x198FA00 VA: 0x181991400
	private void <setColor>b__93_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198F7A0 Offset: 0x198DDA0 VA: 0x18198F7A0
	private void <setCallbackColor>b__94_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198F7F0 Offset: 0x198DDF0 VA: 0x18198F7F0
	private void <setCallbackColor>b__94_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19945E0 Offset: 0x1992BE0 VA: 0x1819945E0
	private void <setTextColor>b__95_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19946E0 Offset: 0x1992CE0 VA: 0x1819946E0
	private void <setTextColor>b__95_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198F9C0 Offset: 0x198DFC0 VA: 0x18198F9C0
	private void <setCanvasAlpha>b__96_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198FB20 Offset: 0x198E120 VA: 0x18198FB20
	private void <setCanvasAlpha>b__96_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990090 Offset: 0x198E690 VA: 0x181990090
	private void <setCanvasGroupAlpha>b__97_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19900F0 Offset: 0x198E6F0 VA: 0x1819900F0
	private void <setCanvasGroupAlpha>b__97_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198FD30 Offset: 0x198E330 VA: 0x18198FD30
	private void <setCanvasColor>b__98_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x198FED0 Offset: 0x198E4D0 VA: 0x18198FED0
	private void <setCanvasColor>b__98_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990210 Offset: 0x198E810 VA: 0x181990210
	private void <setCanvasMoveX>b__99_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990250 Offset: 0x198E850 VA: 0x181990250
	private void <setCanvasMoveX>b__99_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990310 Offset: 0x198E910 VA: 0x181990310
	private void <setCanvasMoveY>b__100_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990350 Offset: 0x198E950 VA: 0x181990350
	private void <setCanvasMoveY>b__100_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990410 Offset: 0x198EA10 VA: 0x181990410
	private void <setCanvasMoveZ>b__101_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990450 Offset: 0x198EA50 VA: 0x181990450
	private void <setCanvasMoveZ>b__101_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990A40 Offset: 0x198F040 VA: 0x181990A40
	private void <setCanvasRotateAround>b__103_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990710 Offset: 0x198ED10 VA: 0x181990710
	private void <setCanvasRotateAroundLocal>b__104_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990520 Offset: 0x198EB20 VA: 0x181990520
	private void <setCanvasPlaySprite>b__105_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990580 Offset: 0x198EB80 VA: 0x181990580
	private void <setCanvasPlaySprite>b__105_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990170 Offset: 0x198E770 VA: 0x181990170
	private void <setCanvasMove>b__106_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19901B0 Offset: 0x198E7B0 VA: 0x1819901B0
	private void <setCanvasMove>b__106_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990D30 Offset: 0x198F330 VA: 0x181990D30
	private void <setCanvasScale>b__107_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990D70 Offset: 0x198F370 VA: 0x181990D70
	private void <setCanvasScale>b__107_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990DD0 Offset: 0x198F3D0 VA: 0x181990DD0
	private void <setCanvasSizeDelta>b__108_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1990E70 Offset: 0x198F470 VA: 0x181990E70
	private void <setCanvasSizeDelta>b__108_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992A50 Offset: 0x1991050 VA: 0x181992A50
	private void <setMove>b__112_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992C50 Offset: 0x1991250 VA: 0x181992C50
	private void <setMove>b__112_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19923F0 Offset: 0x19909F0 VA: 0x1819923F0
	private void <setMoveLocal>b__113_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992430 Offset: 0x1990A30 VA: 0x181992430
	private void <setMoveLocal>b__113_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992A50 Offset: 0x1991050 VA: 0x181992A50
	private void <setMoveToTransform>b__114_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1992A90 Offset: 0x1991090 VA: 0x181992A90
	private void <setMoveToTransform>b__114_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19939B0 Offset: 0x1991FB0 VA: 0x1819939B0
	private void <setRotate>b__115_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993AE0 Offset: 0x19920E0 VA: 0x181993AE0
	private void <setRotate>b__115_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19937E0 Offset: 0x1991DE0 VA: 0x1819937E0
	private void <setRotateLocal>b__116_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1993910 Offset: 0x1991F10 VA: 0x181993910
	private void <setRotateLocal>b__116_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994040 Offset: 0x1992640 VA: 0x181994040
	private void <setScale>b__117_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1994080 Offset: 0x1992680 VA: 0x181994080
	private void <setScale>b__117_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19917A0 Offset: 0x198FDA0 VA: 0x1819917A0
	private void <setGUIMove>b__118_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991870 Offset: 0x198FE70 VA: 0x181991870
	private void <setGUIMove>b__118_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991660 Offset: 0x198FC60 VA: 0x181991660
	private void <setGUIMoveMargin>b__119_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991710 Offset: 0x198FD10 VA: 0x181991710
	private void <setGUIMoveMargin>b__119_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991A50 Offset: 0x1990050 VA: 0x181991A50
	private void <setGUIScale>b__120_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991B20 Offset: 0x1990120 VA: 0x181991B20
	private void <setGUIScale>b__120_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19915E0 Offset: 0x198FBE0 VA: 0x1819915E0
	private void <setGUIAlpha>b__121_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991610 Offset: 0x198FC10 VA: 0x181991610
	private void <setGUIAlpha>b__121_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991990 Offset: 0x198FF90 VA: 0x181991990
	private void <setGUIRotate>b__122_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1991A00 Offset: 0x1990000 VA: 0x181991A00
	private void <setGUIRotate>b__122_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19915D0 Offset: 0x198FBD0 VA: 0x1819915D0
	private void <setDelayedSound>b__123_0() { }

}

public sealed class LTDescr.EaseTypeDelegate : MulticastDelegate // TypeDefIndex: 5570
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x198A750 Offset: 0x1988D50 VA: 0x18198A750 Slot: 12
	public virtual Vector3 Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x198A710 Offset: 0x1988D10 VA: 0x18198A710 Slot: 14
	public virtual Vector3 EndInvoke(IAsyncResult result) { }

}

public sealed class LTDescr.ActionMethodDelegate : MulticastDelegate // TypeDefIndex: 5571
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1464520 Offset: 0x1462B20 VA: 0x181464520 Slot: 12
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

	// RVA: 0x19A4B40 Offset: 0x19A3140 VA: 0x1819A4B40
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <setCallback>b__110_0() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <setValue3>b__111_0() { }

}

