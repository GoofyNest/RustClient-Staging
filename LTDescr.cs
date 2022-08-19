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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private LTDescr.ActionMethodDelegate <easeInternal>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x1998D40 Offset: 0x1997340 VA: 0x181998D40
	public Vector3 get_from() { }

	// RVA: 0x199EDC0 Offset: 0x199D3C0 VA: 0x18199EDC0
	public void set_from(Vector3 value) { }

	// RVA: 0x1998D70 Offset: 0x1997370 VA: 0x181998D70
	public Vector3 get_to() { }

	// RVA: 0x199EDE0 Offset: 0x199D3E0 VA: 0x18199EDE0
	public void set_to(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x9921A0 Offset: 0x9907A0 VA: 0x1809921A0
	public LTDescr.ActionMethodDelegate get_easeInternal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA4D220 Offset: 0xA4B820 VA: 0x180A4D220
	public void set_easeInternal(LTDescr.ActionMethodDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7ACF70 Offset: 0x7AB570 VA: 0x1807ACF70
	public LTDescr.ActionMethodDelegate get_initInternal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA4D230 Offset: 0xA4B830 VA: 0x180A4D230
	public void set_initInternal(LTDescr.ActionMethodDelegate value) { }

	// RVA: 0x198DFA0 Offset: 0x198C5A0 VA: 0x18198DFA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1994870 Offset: 0x1992E70 VA: 0x181994870
	public void .ctor() { }

	[ObsoleteAttribute] // RVA: 0xA7F90 Offset: 0xA7390 VA: 0x1800A7F90
	// RVA: 0x1995450 Offset: 0x1993A50 VA: 0x181995450
	public LTDescr cancel(GameObject gameObject) { }

	// RVA: 0x1998D60 Offset: 0x1997360 VA: 0x181998D60
	public int get_uniqueId() { }

	// RVA: 0x1998D60 Offset: 0x1997360 VA: 0x181998D60
	public int get_id() { }

	// RVA: 0xC73B60 Offset: 0xC72160 VA: 0x180C73B60
	public LTDescrOptional get_optional() { }

	// RVA: 0x199EDD0 Offset: 0x199D3D0 VA: 0x18199EDD0
	public void set_optional(LTDescrOptional value) { }

	// RVA: 0x1999180 Offset: 0x1997780 VA: 0x181999180
	public void reset() { }

	// RVA: 0x199D390 Offset: 0x199B990 VA: 0x18199D390
	public LTDescr setMoveX() { }

	// RVA: 0x199D460 Offset: 0x199BA60 VA: 0x18199D460
	public LTDescr setMoveY() { }

	// RVA: 0x199D530 Offset: 0x199BB30 VA: 0x18199D530
	public LTDescr setMoveZ() { }

	// RVA: 0x199CDE0 Offset: 0x199B3E0 VA: 0x18199CDE0
	public LTDescr setMoveLocalX() { }

	// RVA: 0x199CEB0 Offset: 0x199B4B0 VA: 0x18199CEB0
	public LTDescr setMoveLocalY() { }

	// RVA: 0x199CF80 Offset: 0x199B580 VA: 0x18199CF80
	public LTDescr setMoveLocalZ() { }

	// RVA: 0x1998DE0 Offset: 0x19973E0 VA: 0x181998DE0
	private void initFromInternal() { }

	// RVA: 0x199CD10 Offset: 0x199B310 VA: 0x18199CD10
	public LTDescr setMoveCurved() { }

	// RVA: 0x199CC40 Offset: 0x199B240 VA: 0x18199CC40
	public LTDescr setMoveCurvedLocal() { }

	// RVA: 0x199D1F0 Offset: 0x199B7F0 VA: 0x18199D1F0
	public LTDescr setMoveSpline() { }

	// RVA: 0x199D120 Offset: 0x199B720 VA: 0x18199D120
	public LTDescr setMoveSplineLocal() { }

	// RVA: 0x199E5D0 Offset: 0x199CBD0 VA: 0x18199E5D0
	public LTDescr setScaleX() { }

	// RVA: 0x199E6A0 Offset: 0x199CCA0 VA: 0x18199E6A0
	public LTDescr setScaleY() { }

	// RVA: 0x199E770 Offset: 0x199CD70 VA: 0x18199E770
	public LTDescr setScaleZ() { }

	// RVA: 0x199E290 Offset: 0x199C890 VA: 0x18199E290
	public LTDescr setRotateX() { }

	// RVA: 0x199E360 Offset: 0x199C960 VA: 0x18199E360
	public LTDescr setRotateY() { }

	// RVA: 0x199E430 Offset: 0x199CA30 VA: 0x18199E430
	public LTDescr setRotateZ() { }

	// RVA: 0x199E0F0 Offset: 0x199C6F0 VA: 0x18199E0F0
	public LTDescr setRotateAround() { }

	// RVA: 0x199E020 Offset: 0x199C620 VA: 0x18199E020
	public LTDescr setRotateAroundLocal() { }

	// RVA: 0x19994F0 Offset: 0x1997AF0 VA: 0x1819994F0
	public LTDescr setAlpha() { }

	// RVA: 0x199E980 Offset: 0x199CF80 VA: 0x18199E980
	public LTDescr setTextAlpha() { }

	// RVA: 0x1999420 Offset: 0x1997A20 VA: 0x181999420
	public LTDescr setAlphaVertex() { }

	// RVA: 0x199A210 Offset: 0x1998810 VA: 0x18199A210
	public LTDescr setColor() { }

	// RVA: 0x1999630 Offset: 0x1997C30 VA: 0x181999630
	public LTDescr setCallbackColor() { }

	// RVA: 0x199EA50 Offset: 0x199D050 VA: 0x18199EA50
	public LTDescr setTextColor() { }

	// RVA: 0x1999850 Offset: 0x1997E50 VA: 0x181999850
	public LTDescr setCanvasAlpha() { }

	// RVA: 0x19999F0 Offset: 0x1997FF0 VA: 0x1819999F0
	public LTDescr setCanvasGroupAlpha() { }

	// RVA: 0x1999920 Offset: 0x1997F20 VA: 0x181999920
	public LTDescr setCanvasColor() { }

	// RVA: 0x1999AC0 Offset: 0x19980C0 VA: 0x181999AC0
	public LTDescr setCanvasMoveX() { }

	// RVA: 0x1999B90 Offset: 0x1998190 VA: 0x181999B90
	public LTDescr setCanvasMoveY() { }

	// RVA: 0x1999C60 Offset: 0x1998260 VA: 0x181999C60
	public LTDescr setCanvasMoveZ() { }

	// RVA: 0x1998D90 Offset: 0x1997390 VA: 0x181998D90
	private void initCanvasRotateAround() { }

	// RVA: 0x1999FA0 Offset: 0x19985A0 VA: 0x181999FA0
	public LTDescr setCanvasRotateAround() { }

	// RVA: 0x1999ED0 Offset: 0x19984D0 VA: 0x181999ED0
	public LTDescr setCanvasRotateAroundLocal() { }

	// RVA: 0x1999E00 Offset: 0x1998400 VA: 0x181999E00
	public LTDescr setCanvasPlaySprite() { }

	// RVA: 0x1999D30 Offset: 0x1998330 VA: 0x181999D30
	public LTDescr setCanvasMove() { }

	// RVA: 0x199A070 Offset: 0x1998670 VA: 0x18199A070
	public LTDescr setCanvasScale() { }

	// RVA: 0x199A140 Offset: 0x1998740 VA: 0x18199A140
	public LTDescr setCanvasSizeDelta() { }

	// RVA: 0x19953D0 Offset: 0x19939D0 VA: 0x1819953D0
	private void callback() { }

	// RVA: 0x1999700 Offset: 0x1997D00 VA: 0x181999700
	public LTDescr setCallback() { }

	// RVA: 0x199EC70 Offset: 0x199D270 VA: 0x18199EC70
	public LTDescr setValue3() { }

	// RVA: 0x199D600 Offset: 0x199BC00 VA: 0x18199D600
	public LTDescr setMove() { }

	// RVA: 0x199D050 Offset: 0x199B650 VA: 0x18199D050
	public LTDescr setMoveLocal() { }

	// RVA: 0x199D2C0 Offset: 0x199B8C0 VA: 0x18199D2C0
	public LTDescr setMoveToTransform() { }

	// RVA: 0x199E500 Offset: 0x199CB00 VA: 0x18199E500
	public LTDescr setRotate() { }

	// RVA: 0x199E1C0 Offset: 0x199C7C0 VA: 0x18199E1C0
	public LTDescr setRotateLocal() { }

	// RVA: 0x199E850 Offset: 0x199CE50 VA: 0x18199E850
	public LTDescr setScale() { }

	// RVA: 0x199C900 Offset: 0x199AF00 VA: 0x18199C900
	public LTDescr setGUIMove() { }

	// RVA: 0x199C830 Offset: 0x199AE30 VA: 0x18199C830
	public LTDescr setGUIMoveMargin() { }

	// RVA: 0x199CAA0 Offset: 0x199B0A0 VA: 0x18199CAA0
	public LTDescr setGUIScale() { }

	// RVA: 0x199C760 Offset: 0x199AD60 VA: 0x18199C760
	public LTDescr setGUIAlpha() { }

	// RVA: 0x199C9D0 Offset: 0x199AFD0 VA: 0x18199C9D0
	public LTDescr setGUIRotate() { }

	// RVA: 0x199A2F0 Offset: 0x19988F0 VA: 0x18199A2F0
	public LTDescr setDelayedSound() { }

	// RVA: 0x1998F60 Offset: 0x1997560 VA: 0x181998F60
	private void init() { }

	// RVA: 0x1998DF0 Offset: 0x19973F0 VA: 0x181998DF0
	private void initSpeed() { }

	// RVA: 0x199FD50 Offset: 0x199E350 VA: 0x18199FD50
	public LTDescr updateNow() { }

	// RVA: 0x199F860 Offset: 0x199DE60 VA: 0x18199F860
	public bool updateInternal() { }

	// RVA: 0x19952B0 Offset: 0x19938B0 VA: 0x1819952B0
	public void callOnCompletes() { }

	// RVA: 0x199C3B0 Offset: 0x199A9B0 VA: 0x18199C3B0
	public LTDescr setFromColor(Color col) { }

	// RVA: 0x1994E60 Offset: 0x1993460 VA: 0x181994E60
	private static void alphaRecursive(Transform transform, float val, bool useRecursion = True) { }

	// RVA: 0x19957C0 Offset: 0x1993DC0 VA: 0x1819957C0
	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = True) { }

	// RVA: 0x1994B80 Offset: 0x1993180 VA: 0x181994B80
	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0) { }

	// RVA: 0x19948E0 Offset: 0x1992EE0 VA: 0x1819948E0
	private static void alphaRecursiveSprite(Transform transform, float val) { }

	// RVA: 0x1995520 Offset: 0x1993B20 VA: 0x181995520
	private static void colorRecursiveSprite(Transform transform, Color toColor) { }

	// RVA: 0x1995AB0 Offset: 0x19940B0 VA: 0x181995AB0
	private static void colorRecursive(RectTransform rectTransform, Color toColor) { }

	// RVA: 0x199EDF0 Offset: 0x199D3F0 VA: 0x18199EDF0
	private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = True) { }

	// RVA: 0x199F060 Offset: 0x199D660 VA: 0x18199F060
	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = True) { }

	// RVA: 0x199F310 Offset: 0x199D910 VA: 0x18199F310
	private static void textColorRecursive(Transform trans, Color toColor) { }

	// RVA: 0x199F540 Offset: 0x199DB40 VA: 0x18199F540
	private static Color tweenColor(LTDescr tween, float val) { }

	// RVA: 0x1999160 Offset: 0x1997760 VA: 0x181999160
	public LTDescr pause() { }

	// RVA: 0x1999410 Offset: 0x1997A10 VA: 0x181999410
	public LTDescr resume() { }

	// RVA: 0x1999600 Offset: 0x1997C00 VA: 0x181999600
	public LTDescr setAxis(Vector3 axis) { }

	// RVA: 0x199A2E0 Offset: 0x19988E0 VA: 0x18199A2E0
	public LTDescr setDelay(float delay) { }

	// RVA: 0x199BA20 Offset: 0x199A020 VA: 0x18199BA20
	public LTDescr setEase(LeanTweenType easeType) { }

	// RVA: 0x199B0F0 Offset: 0x19996F0 VA: 0x18199B0F0
	public LTDescr setEaseLinear() { }

	// RVA: 0x199B8E0 Offset: 0x1999EE0 VA: 0x18199B8E0
	public LTDescr setEaseSpring() { }

	// RVA: 0x199AEB0 Offset: 0x19994B0 VA: 0x18199AEB0
	public LTDescr setEaseInQuad() { }

	// RVA: 0x199B4E0 Offset: 0x1999AE0 VA: 0x18199B4E0
	public LTDescr setEaseOutQuad() { }

	// RVA: 0x199AC70 Offset: 0x1999270 VA: 0x18199AC70
	public LTDescr setEaseInOutQuad() { }

	// RVA: 0x199A760 Offset: 0x1998D60 VA: 0x18199A760
	public LTDescr setEaseInCubic() { }

	// RVA: 0x199B330 Offset: 0x1999930 VA: 0x18199B330
	public LTDescr setEaseOutCubic() { }

	// RVA: 0x199AAC0 Offset: 0x19990C0 VA: 0x18199AAC0
	public LTDescr setEaseInOutCubic() { }

	// RVA: 0x199AF40 Offset: 0x1999540 VA: 0x18199AF40
	public LTDescr setEaseInQuart() { }

	// RVA: 0x199B570 Offset: 0x1999B70 VA: 0x18199B570
	public LTDescr setEaseOutQuart() { }

	// RVA: 0x199AD00 Offset: 0x1999300 VA: 0x18199AD00
	public LTDescr setEaseInOutQuart() { }

	// RVA: 0x199AFD0 Offset: 0x19995D0 VA: 0x18199AFD0
	public LTDescr setEaseInQuint() { }

	// RVA: 0x199B600 Offset: 0x1999C00 VA: 0x18199B600
	public LTDescr setEaseOutQuint() { }

	// RVA: 0x199AD90 Offset: 0x1999390 VA: 0x18199AD90
	public LTDescr setEaseInOutQuint() { }

	// RVA: 0x199B060 Offset: 0x1999660 VA: 0x18199B060
	public LTDescr setEaseInSine() { }

	// RVA: 0x199B690 Offset: 0x1999C90 VA: 0x18199B690
	public LTDescr setEaseOutSine() { }

	// RVA: 0x199AE20 Offset: 0x1999420 VA: 0x18199AE20
	public LTDescr setEaseInOutSine() { }

	// RVA: 0x199A880 Offset: 0x1998E80 VA: 0x18199A880
	public LTDescr setEaseInExpo() { }

	// RVA: 0x199B450 Offset: 0x1999A50 VA: 0x18199B450
	public LTDescr setEaseOutExpo() { }

	// RVA: 0x199ABE0 Offset: 0x19991E0 VA: 0x18199ABE0
	public LTDescr setEaseInOutExpo() { }

	// RVA: 0x199A6D0 Offset: 0x1998CD0 VA: 0x18199A6D0
	public LTDescr setEaseInCirc() { }

	// RVA: 0x199B2A0 Offset: 0x19998A0 VA: 0x18199B2A0
	public LTDescr setEaseOutCirc() { }

	// RVA: 0x199AA30 Offset: 0x1999030 VA: 0x18199AA30
	public LTDescr setEaseInOutCirc() { }

	// RVA: 0x199A640 Offset: 0x1998C40 VA: 0x18199A640
	public LTDescr setEaseInBounce() { }

	// RVA: 0x199B210 Offset: 0x1999810 VA: 0x18199B210
	public LTDescr setEaseOutBounce() { }

	// RVA: 0x199A9A0 Offset: 0x1998FA0 VA: 0x18199A9A0
	public LTDescr setEaseInOutBounce() { }

	// RVA: 0x199A5B0 Offset: 0x1998BB0 VA: 0x18199A5B0
	public LTDescr setEaseInBack() { }

	// RVA: 0x199B180 Offset: 0x1999780 VA: 0x18199B180
	public LTDescr setEaseOutBack() { }

	// RVA: 0x199A910 Offset: 0x1998F10 VA: 0x18199A910
	public LTDescr setEaseInOutBack() { }

	// RVA: 0x199A7F0 Offset: 0x1998DF0 VA: 0x18199A7F0
	public LTDescr setEaseInElastic() { }

	// RVA: 0x199B3C0 Offset: 0x19999C0 VA: 0x18199B3C0
	public LTDescr setEaseOutElastic() { }

	// RVA: 0x199AB50 Offset: 0x1999150 VA: 0x18199AB50
	public LTDescr setEaseInOutElastic() { }

	// RVA: 0x199B720 Offset: 0x1999D20 VA: 0x18199B720
	public LTDescr setEasePunch() { }

	// RVA: 0x199B800 Offset: 0x1999E00 VA: 0x18199B800
	public LTDescr setEaseShake() { }

	// RVA: 0x199F700 Offset: 0x199DD00 VA: 0x18199F700
	private Vector3 tweenOnCurve() { }

	// RVA: 0x19971D0 Offset: 0x19957D0 VA: 0x1819971D0
	private Vector3 easeInOutQuad() { }

	// RVA: 0x19977D0 Offset: 0x1995DD0 VA: 0x1819977D0
	private Vector3 easeInQuad() { }

	// RVA: 0x1998670 Offset: 0x1996C70 VA: 0x181998670
	private Vector3 easeOutQuad() { }

	// RVA: 0x1997C70 Offset: 0x1996270 VA: 0x181997C70
	private Vector3 easeLinear() { }

	// RVA: 0x1998B60 Offset: 0x1997160 VA: 0x181998B60
	private Vector3 easeSpring() { }

	// RVA: 0x19961D0 Offset: 0x19947D0 VA: 0x1819961D0
	private Vector3 easeInCubic() { }

	// RVA: 0x1998290 Offset: 0x1996890 VA: 0x181998290
	private Vector3 easeOutCubic() { }

	// RVA: 0x1996CA0 Offset: 0x19952A0 VA: 0x181996CA0
	private Vector3 easeInOutCubic() { }

	// RVA: 0x19978D0 Offset: 0x1995ED0 VA: 0x1819978D0
	private Vector3 easeInQuart() { }

	// RVA: 0x19987A0 Offset: 0x1996DA0 VA: 0x1819987A0
	private Vector3 easeOutQuart() { }

	// RVA: 0x1997300 Offset: 0x1995900 VA: 0x181997300
	private Vector3 easeInOutQuart() { }

	// RVA: 0x19979F0 Offset: 0x1995FF0 VA: 0x1819979F0
	private Vector3 easeInQuint() { }

	// RVA: 0x19988D0 Offset: 0x1996ED0 VA: 0x1819988D0
	private Vector3 easeOutQuint() { }

	// RVA: 0x1997530 Offset: 0x1995B30 VA: 0x181997530
	private Vector3 easeInOutQuint() { }

	// RVA: 0x1997B00 Offset: 0x1996100 VA: 0x181997B00
	private Vector3 easeInSine() { }

	// RVA: 0x1998A00 Offset: 0x1997000 VA: 0x181998A00
	private Vector3 easeOutSine() { }

	// RVA: 0x1997690 Offset: 0x1995C90 VA: 0x181997690
	private Vector3 easeInOutSine() { }

	// RVA: 0x1996450 Offset: 0x1994A50 VA: 0x181996450
	private Vector3 easeInExpo() { }

	// RVA: 0x1998530 Offset: 0x1996B30 VA: 0x181998530
	private Vector3 easeOutExpo() { }

	// RVA: 0x1996F70 Offset: 0x1995570 VA: 0x181996F70
	private Vector3 easeInOutExpo() { }

	// RVA: 0x1996090 Offset: 0x1994690 VA: 0x181996090
	private Vector3 easeInCirc() { }

	// RVA: 0x1998140 Offset: 0x1996740 VA: 0x181998140
	private Vector3 easeOutCirc() { }

	// RVA: 0x1996AE0 Offset: 0x19950E0 VA: 0x181996AE0
	private Vector3 easeInOutCirc() { }

	// RVA: 0x1995ED0 Offset: 0x19944D0 VA: 0x181995ED0
	private Vector3 easeInBounce() { }

	// RVA: 0x1997EB0 Offset: 0x19964B0 VA: 0x181997EB0
	private Vector3 easeOutBounce() { }

	// RVA: 0x19967F0 Offset: 0x1994DF0 VA: 0x1819967F0
	private Vector3 easeInOutBounce() { }

	// RVA: 0x1995D20 Offset: 0x1994320 VA: 0x181995D20
	private Vector3 easeInBack() { }

	// RVA: 0x1997D50 Offset: 0x1996350 VA: 0x181997D50
	private Vector3 easeOutBack() { }

	// RVA: 0x1996590 Offset: 0x1994B90 VA: 0x181996590
	private Vector3 easeInOutBack() { }

	// RVA: 0x19962D0 Offset: 0x19948D0 VA: 0x1819962D0
	private Vector3 easeInElastic() { }

	// RVA: 0x19983B0 Offset: 0x19969B0 VA: 0x1819983B0
	private Vector3 easeOutElastic() { }

	// RVA: 0x1996DF0 Offset: 0x19953F0 VA: 0x181996DF0
	private Vector3 easeInOutElastic() { }

	// RVA: 0x199DE40 Offset: 0x199C440 VA: 0x18199DE40
	public LTDescr setOvershoot(float overshoot) { }

	// RVA: 0x199DE90 Offset: 0x199C490 VA: 0x18199DE90
	public LTDescr setPeriod(float period) { }

	// RVA: 0x199E840 Offset: 0x199CE40 VA: 0x18199E840
	public LTDescr setScale(float scale) { }

	// RVA: 0x199B970 Offset: 0x1999F70 VA: 0x18199B970
	public LTDescr setEase(AnimationCurve easeCurve) { }

	// RVA: 0x199EB40 Offset: 0x199D140 VA: 0x18199EB40
	public LTDescr setTo(Vector3 to) { }

	// RVA: 0x199EC20 Offset: 0x199D220 VA: 0x18199EC20
	public LTDescr setTo(Transform to) { }

	// RVA: 0x199C4A0 Offset: 0x199AAA0 VA: 0x18199C4A0
	public LTDescr setFrom(Vector3 from) { }

	// RVA: 0x199C5F0 Offset: 0x199ABF0 VA: 0x18199C5F0
	public LTDescr setFrom(float from) { }

	// RVA: 0x199A3D0 Offset: 0x19989D0 VA: 0x18199A3D0
	public LTDescr setDiff(Vector3 diff) { }

	// RVA: 0x199CB70 Offset: 0x199B170 VA: 0x18199CB70
	public LTDescr setHasInitialized(bool has) { }

	// RVA: 0x199CB80 Offset: 0x199B180 VA: 0x18199CB80
	public LTDescr setId(uint id, uint global_counter) { }

	// RVA: 0x199DE50 Offset: 0x199C450 VA: 0x18199DE50
	public LTDescr setPassed(float passed) { }

	// RVA: 0x199EB20 Offset: 0x199D120 VA: 0x18199EB20
	public LTDescr setTime(float time) { }

	// RVA: 0x199E920 Offset: 0x199CF20 VA: 0x18199E920
	public LTDescr setSpeed(float speed) { }

	// RVA: 0x199DFE0 Offset: 0x199C5E0 VA: 0x18199DFE0
	public LTDescr setRepeat(int repeat) { }

	// RVA: 0x199CC30 Offset: 0x199B230 VA: 0x18199CC30
	public LTDescr setLoopType(LeanTweenType loopType) { }

	// RVA: 0x199CB90 Offset: 0x199B190 VA: 0x18199CB90
	public LTDescr setUseEstimatedTime(bool useEstimatedTime) { }

	// RVA: 0x199CB90 Offset: 0x199B190 VA: 0x18199CB90
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime) { }

	// RVA: 0x199EC50 Offset: 0x199D250 VA: 0x18199EC50
	public LTDescr setUseFrames(bool useFrames) { }

	// RVA: 0x199EC60 Offset: 0x199D260 VA: 0x18199EC60
	public LTDescr setUseManualTime(bool useManualTime) { }

	// RVA: 0x199CBC0 Offset: 0x199B1C0 VA: 0x18199CBC0
	public LTDescr setLoopCount(int loopCount) { }

	// RVA: 0x199CBE0 Offset: 0x199B1E0 VA: 0x18199CBE0
	public LTDescr setLoopOnce() { }

	// RVA: 0x199CBA0 Offset: 0x199B1A0 VA: 0x18199CBA0
	public LTDescr setLoopClamp() { }

	// RVA: 0xE721E0 Offset: 0xE707E0 VA: 0x180E721E0
	public LTDescr setLoopClamp(int loops) { }

	// RVA: 0x199CBF0 Offset: 0x199B1F0 VA: 0x18199CBF0
	public LTDescr setLoopPingPong() { }

	// RVA: 0x199CC10 Offset: 0x199B210 VA: 0x18199CC10
	public LTDescr setLoopPingPong(int loops) { }

	// RVA: 0x199D7A0 Offset: 0x199BDA0 VA: 0x18199D7A0
	public LTDescr setOnComplete(Action onComplete) { }

	// RVA: 0x199D7E0 Offset: 0x199BDE0 VA: 0x18199D7E0
	public LTDescr setOnComplete(Action<object> onComplete) { }

	// RVA: 0x199D730 Offset: 0x199BD30 VA: 0x18199D730
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam) { }

	// RVA: 0x199D6F0 Offset: 0x199BCF0 VA: 0x18199D6F0
	public LTDescr setOnCompleteParam(object onCompleteParam) { }

	// RVA: 0x199DA90 Offset: 0x199C090 VA: 0x18199DA90
	public LTDescr setOnUpdate(Action<float> onUpdate) { }

	// RVA: 0x199D960 Offset: 0x199BF60 VA: 0x18199D960
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate) { }

	// RVA: 0x199D8E0 Offset: 0x199BEE0 VA: 0x18199D8E0
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate) { }

	// RVA: 0x199D9A0 Offset: 0x199BFA0 VA: 0x18199D9A0
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate) { }

	// RVA: 0x199D9E0 Offset: 0x199BFE0 VA: 0x18199D9E0
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate) { }

	// RVA: 0x199D860 Offset: 0x199BE60 VA: 0x18199D860
	public LTDescr setOnUpdateColor(Action<Color> onUpdate) { }

	// RVA: 0x199D8A0 Offset: 0x199BEA0 VA: 0x18199D8A0
	public LTDescr setOnUpdateColor(Action<Color, object> onUpdate) { }

	// RVA: 0x199D860 Offset: 0x199BE60 VA: 0x18199D860
	public LTDescr setOnUpdate(Action<Color> onUpdate) { }

	// RVA: 0x199D8A0 Offset: 0x199BEA0 VA: 0x18199D8A0
	public LTDescr setOnUpdate(Action<Color, object> onUpdate) { }

	// RVA: 0x199DAD0 Offset: 0x199C0D0 VA: 0x18199DAD0
	public LTDescr setOnUpdate(Action<float, object> onUpdate, object onUpdateParam) { }

	// RVA: 0x199DA20 Offset: 0x199C020 VA: 0x18199DA20
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, object onUpdateParam) { }

	// RVA: 0x199DB40 Offset: 0x199C140 VA: 0x18199DB40
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, object onUpdateParam) { }

	// RVA: 0x199DBB0 Offset: 0x199C1B0 VA: 0x18199DBB0
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, object onUpdateParam) { }

	// RVA: 0x199D920 Offset: 0x199BF20 VA: 0x18199D920
	public LTDescr setOnUpdateParam(object onUpdateParam) { }

	// RVA: 0x199DD50 Offset: 0x199C350 VA: 0x18199DD50
	public LTDescr setOrientToPath(bool doesOrient) { }

	// RVA: 0x199DC20 Offset: 0x199C220 VA: 0x18199DC20
	public LTDescr setOrientToPath2d(bool doesOrient2d) { }

	// RVA: 0x199DED0 Offset: 0x199C4D0 VA: 0x18199DED0
	public LTDescr setRect(LTRect rect) { }

	// RVA: 0x199DF30 Offset: 0x199C530 VA: 0x18199DF30
	public LTDescr setRect(Rect rect) { }

	// RVA: 0x199DE60 Offset: 0x199C460 VA: 0x18199DE60
	public LTDescr setPath(LTBezierPath path) { }

	// RVA: 0x199DEA0 Offset: 0x199C4A0 VA: 0x18199DEA0
	public LTDescr setPoint(Vector3 point) { }

	// RVA: 0x199A3C0 Offset: 0x19989C0 VA: 0x18199A3C0
	public LTDescr setDestroyOnComplete(bool doesDestroy) { }

	// RVA: 0x19995C0 Offset: 0x1997BC0 VA: 0x1819995C0
	public LTDescr setAudio(object audio) { }

	// RVA: 0x199D6D0 Offset: 0x199BCD0 VA: 0x18199D6D0
	public LTDescr setOnCompleteOnRepeat(bool isOn) { }

	// RVA: 0x199D6E0 Offset: 0x199BCE0 VA: 0x18199D6E0
	public LTDescr setOnCompleteOnStart(bool isOn) { }

	// RVA: 0x199DF00 Offset: 0x199C500 VA: 0x18199DF00
	public LTDescr setRect(RectTransform rect) { }

	// RVA: 0x199E950 Offset: 0x199CF50 VA: 0x18199E950
	public LTDescr setSprites(Sprite[] sprites) { }

	// RVA: 0x199C380 Offset: 0x199A980 VA: 0x18199C380
	public LTDescr setFrameRate(float frameRate) { }

	// RVA: 0x199D820 Offset: 0x199BE20 VA: 0x18199D820
	public LTDescr setOnStart(Action onStart) { }

	// RVA: 0x199A3F0 Offset: 0x19989F0 VA: 0x18199A3F0
	public LTDescr setDirection(float direction) { }

	// RVA: 0x199DFD0 Offset: 0x199C5D0 VA: 0x18199DFD0
	public LTDescr setRecursive(bool useRecursion) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992D30 Offset: 0x1991330 VA: 0x181992D30
	private void <setMoveX>b__71_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992D60 Offset: 0x1991360 VA: 0x181992D60
	private void <setMoveX>b__71_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992E50 Offset: 0x1991450 VA: 0x181992E50
	private void <setMoveY>b__72_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992E90 Offset: 0x1991490 VA: 0x181992E90
	private void <setMoveY>b__72_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992F90 Offset: 0x1991590 VA: 0x181992F90
	private void <setMoveZ>b__73_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992FD0 Offset: 0x19915D0 VA: 0x181992FD0
	private void <setMoveZ>b__73_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992510 Offset: 0x1990B10 VA: 0x181992510
	private void <setMoveLocalX>b__74_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992540 Offset: 0x1990B40 VA: 0x181992540
	private void <setMoveLocalX>b__74_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992630 Offset: 0x1990C30 VA: 0x181992630
	private void <setMoveLocalY>b__75_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992670 Offset: 0x1990C70 VA: 0x181992670
	private void <setMoveLocalY>b__75_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992770 Offset: 0x1990D70 VA: 0x181992770
	private void <setMoveLocalZ>b__76_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19927B0 Offset: 0x1990DB0 VA: 0x1819927B0
	private void <setMoveLocalZ>b__76_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19920A0 Offset: 0x19906A0 VA: 0x1819920A0
	private void <setMoveCurved>b__78_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1991C70 Offset: 0x1990270 VA: 0x181991C70
	private void <setMoveCurvedLocal>b__79_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992990 Offset: 0x1990F90 VA: 0x181992990
	private void <setMoveSpline>b__80_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992890 Offset: 0x1990E90 VA: 0x181992890
	private void <setMoveSplineLocal>b__81_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1994160 Offset: 0x1992760 VA: 0x181994160
	private void <setScaleX>b__82_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1994190 Offset: 0x1992790 VA: 0x181994190
	private void <setScaleX>b__82_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1994280 Offset: 0x1992880 VA: 0x181994280
	private void <setScaleY>b__83_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19942C0 Offset: 0x19928C0 VA: 0x1819942C0
	private void <setScaleY>b__83_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19943C0 Offset: 0x19929C0 VA: 0x1819943C0
	private void <setScaleZ>b__84_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1994400 Offset: 0x1992A00 VA: 0x181994400
	private void <setScaleZ>b__84_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1993BC0 Offset: 0x19921C0 VA: 0x181993BC0
	private void <setRotateX>b__85_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1993C60 Offset: 0x1992260 VA: 0x181993C60
	private void <setRotateX>b__85_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1993D50 Offset: 0x1992350 VA: 0x181993D50
	private void <setRotateY>b__86_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1993DF0 Offset: 0x19923F0 VA: 0x181993DF0
	private void <setRotateY>b__86_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1993EF0 Offset: 0x19924F0 VA: 0x181993EF0
	private void <setRotateZ>b__87_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1993FA0 Offset: 0x19925A0 VA: 0x181993FA0
	private void <setRotateZ>b__87_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19934A0 Offset: 0x1991AA0 VA: 0x1819934A0
	private void <setRotateAround>b__88_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19934F0 Offset: 0x1991AF0 VA: 0x1819934F0
	private void <setRotateAround>b__88_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19930B0 Offset: 0x19916B0 VA: 0x1819930B0
	private void <setRotateAroundLocal>b__89_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1993100 Offset: 0x1991700 VA: 0x181993100
	private void <setRotateAroundLocal>b__89_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x198EC00 Offset: 0x198D200 VA: 0x18198EC00
	private void <setAlpha>b__90_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x198F300 Offset: 0x198D900 VA: 0x18198F300
	private void <setAlpha>b__90_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x198F110 Offset: 0x198D710 VA: 0x18198F110
	private void <setAlpha>b__90_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19944E0 Offset: 0x1992AE0 VA: 0x1819944E0
	private void <setTextAlpha>b__91_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19945D0 Offset: 0x1992BD0 VA: 0x1819945D0
	private void <setTextAlpha>b__91_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x198F4D0 Offset: 0x198DAD0 VA: 0x18198F4D0
	private void <setAlphaVertex>b__92_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x198F560 Offset: 0x198DB60 VA: 0x18198F560
	private void <setAlphaVertex>b__92_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1990F60 Offset: 0x198F560 VA: 0x181990F60
	private void <setColor>b__93_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1991440 Offset: 0x198FA40 VA: 0x181991440
	private void <setColor>b__93_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x198F7E0 Offset: 0x198DDE0 VA: 0x18198F7E0
	private void <setCallbackColor>b__94_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x198F830 Offset: 0x198DE30 VA: 0x18198F830
	private void <setCallbackColor>b__94_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1994620 Offset: 0x1992C20 VA: 0x181994620
	private void <setTextColor>b__95_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1994720 Offset: 0x1992D20 VA: 0x181994720
	private void <setTextColor>b__95_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x198FA00 Offset: 0x198E000 VA: 0x18198FA00
	private void <setCanvasAlpha>b__96_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x198FB60 Offset: 0x198E160 VA: 0x18198FB60
	private void <setCanvasAlpha>b__96_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19900D0 Offset: 0x198E6D0 VA: 0x1819900D0
	private void <setCanvasGroupAlpha>b__97_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1990130 Offset: 0x198E730 VA: 0x181990130
	private void <setCanvasGroupAlpha>b__97_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x198FD70 Offset: 0x198E370 VA: 0x18198FD70
	private void <setCanvasColor>b__98_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x198FF10 Offset: 0x198E510 VA: 0x18198FF10
	private void <setCanvasColor>b__98_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1990250 Offset: 0x198E850 VA: 0x181990250
	private void <setCanvasMoveX>b__99_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1990290 Offset: 0x198E890 VA: 0x181990290
	private void <setCanvasMoveX>b__99_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1990350 Offset: 0x198E950 VA: 0x181990350
	private void <setCanvasMoveY>b__100_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1990390 Offset: 0x198E990 VA: 0x181990390
	private void <setCanvasMoveY>b__100_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1990450 Offset: 0x198EA50 VA: 0x181990450
	private void <setCanvasMoveZ>b__101_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1990490 Offset: 0x198EA90 VA: 0x181990490
	private void <setCanvasMoveZ>b__101_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1990A80 Offset: 0x198F080 VA: 0x181990A80
	private void <setCanvasRotateAround>b__103_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1990750 Offset: 0x198ED50 VA: 0x181990750
	private void <setCanvasRotateAroundLocal>b__104_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1990560 Offset: 0x198EB60 VA: 0x181990560
	private void <setCanvasPlaySprite>b__105_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19905C0 Offset: 0x198EBC0 VA: 0x1819905C0
	private void <setCanvasPlaySprite>b__105_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19901B0 Offset: 0x198E7B0 VA: 0x1819901B0
	private void <setCanvasMove>b__106_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19901F0 Offset: 0x198E7F0 VA: 0x1819901F0
	private void <setCanvasMove>b__106_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1990D70 Offset: 0x198F370 VA: 0x181990D70
	private void <setCanvasScale>b__107_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1990DB0 Offset: 0x198F3B0 VA: 0x181990DB0
	private void <setCanvasScale>b__107_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1990E10 Offset: 0x198F410 VA: 0x181990E10
	private void <setCanvasSizeDelta>b__108_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1990EB0 Offset: 0x198F4B0 VA: 0x181990EB0
	private void <setCanvasSizeDelta>b__108_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992A90 Offset: 0x1991090 VA: 0x181992A90
	private void <setMove>b__112_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992C90 Offset: 0x1991290 VA: 0x181992C90
	private void <setMove>b__112_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992430 Offset: 0x1990A30 VA: 0x181992430
	private void <setMoveLocal>b__113_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992470 Offset: 0x1990A70 VA: 0x181992470
	private void <setMoveLocal>b__113_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992A90 Offset: 0x1991090 VA: 0x181992A90
	private void <setMoveToTransform>b__114_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1992AD0 Offset: 0x19910D0 VA: 0x181992AD0
	private void <setMoveToTransform>b__114_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19939F0 Offset: 0x1991FF0 VA: 0x1819939F0
	private void <setRotate>b__115_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1993B20 Offset: 0x1992120 VA: 0x181993B20
	private void <setRotate>b__115_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1993820 Offset: 0x1991E20 VA: 0x181993820
	private void <setRotateLocal>b__116_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1993950 Offset: 0x1991F50 VA: 0x181993950
	private void <setRotateLocal>b__116_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1994080 Offset: 0x1992680 VA: 0x181994080
	private void <setScale>b__117_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19940C0 Offset: 0x19926C0 VA: 0x1819940C0
	private void <setScale>b__117_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19917E0 Offset: 0x198FDE0 VA: 0x1819917E0
	private void <setGUIMove>b__118_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19918B0 Offset: 0x198FEB0 VA: 0x1819918B0
	private void <setGUIMove>b__118_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19916A0 Offset: 0x198FCA0 VA: 0x1819916A0
	private void <setGUIMoveMargin>b__119_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1991750 Offset: 0x198FD50 VA: 0x181991750
	private void <setGUIMoveMargin>b__119_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1991A90 Offset: 0x1990090 VA: 0x181991A90
	private void <setGUIScale>b__120_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1991B60 Offset: 0x1990160 VA: 0x181991B60
	private void <setGUIScale>b__120_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1991620 Offset: 0x198FC20 VA: 0x181991620
	private void <setGUIAlpha>b__121_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1991650 Offset: 0x198FC50 VA: 0x181991650
	private void <setGUIAlpha>b__121_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19919D0 Offset: 0x198FFD0 VA: 0x1819919D0
	private void <setGUIRotate>b__122_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1991A40 Offset: 0x1990040 VA: 0x181991A40
	private void <setGUIRotate>b__122_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1991610 Offset: 0x198FC10 VA: 0x181991610
	private void <setDelayedSound>b__123_0() { }

}

public sealed class LTDescr.EaseTypeDelegate : MulticastDelegate // TypeDefIndex: 5570
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x198A790 Offset: 0x1988D90 VA: 0x18198A790 Slot: 12
	public virtual Vector3 Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x198A750 Offset: 0x1988D50 VA: 0x18198A750 Slot: 14
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

	// RVA: 0x19A4B80 Offset: 0x19A3180 VA: 0x1819A4B80
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <setCallback>b__110_0() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <setValue3>b__111_0() { }

}

