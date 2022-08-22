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

	// RVA: 0x19863C0 Offset: 0x19849C0 VA: 0x1819863C0
	public Vector3 get_from() { }

	// RVA: 0x198C440 Offset: 0x198AA40 VA: 0x18198C440
	public void set_from(Vector3 value) { }

	// RVA: 0x19863F0 Offset: 0x19849F0 VA: 0x1819863F0
	public Vector3 get_to() { }

	// RVA: 0x198C460 Offset: 0x198AA60 VA: 0x18198C460
	public void set_to(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDB0 Offset: 0x79A3B0 VA: 0x18079BDB0
	public LTDescr.ActionMethodDelegate get_easeInternal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE40 Offset: 0x79A440 VA: 0x18079BE40
	public void set_easeInternal(LTDescr.ActionMethodDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BDD0 Offset: 0x79A3D0 VA: 0x18079BDD0
	public LTDescr.ActionMethodDelegate get_initInternal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BE50 Offset: 0x79A450 VA: 0x18079BE50
	public void set_initInternal(LTDescr.ActionMethodDelegate value) { }

	// RVA: 0x197B620 Offset: 0x1979C20 VA: 0x18197B620 Slot: 3
	public override string ToString() { }

	// RVA: 0x1981EF0 Offset: 0x19804F0 VA: 0x181981EF0
	public void .ctor() { }

	[ObsoleteAttribute] // RVA: 0xA8020 Offset: 0xA7420 VA: 0x1800A8020
	// RVA: 0x1982AD0 Offset: 0x19810D0 VA: 0x181982AD0
	public LTDescr cancel(GameObject gameObject) { }

	// RVA: 0x19863E0 Offset: 0x19849E0 VA: 0x1819863E0
	public int get_uniqueId() { }

	// RVA: 0x19863E0 Offset: 0x19849E0 VA: 0x1819863E0
	public int get_id() { }

	// RVA: 0xC742E0 Offset: 0xC728E0 VA: 0x180C742E0
	public LTDescrOptional get_optional() { }

	// RVA: 0x198C450 Offset: 0x198AA50 VA: 0x18198C450
	public void set_optional(LTDescrOptional value) { }

	// RVA: 0x1986800 Offset: 0x1984E00 VA: 0x181986800
	public void reset() { }

	// RVA: 0x198AA10 Offset: 0x1989010 VA: 0x18198AA10
	public LTDescr setMoveX() { }

	// RVA: 0x198AAE0 Offset: 0x19890E0 VA: 0x18198AAE0
	public LTDescr setMoveY() { }

	// RVA: 0x198ABB0 Offset: 0x19891B0 VA: 0x18198ABB0
	public LTDescr setMoveZ() { }

	// RVA: 0x198A460 Offset: 0x1988A60 VA: 0x18198A460
	public LTDescr setMoveLocalX() { }

	// RVA: 0x198A530 Offset: 0x1988B30 VA: 0x18198A530
	public LTDescr setMoveLocalY() { }

	// RVA: 0x198A600 Offset: 0x1988C00 VA: 0x18198A600
	public LTDescr setMoveLocalZ() { }

	// RVA: 0x1986460 Offset: 0x1984A60 VA: 0x181986460
	private void initFromInternal() { }

	// RVA: 0x198A390 Offset: 0x1988990 VA: 0x18198A390
	public LTDescr setMoveCurved() { }

	// RVA: 0x198A2C0 Offset: 0x19888C0 VA: 0x18198A2C0
	public LTDescr setMoveCurvedLocal() { }

	// RVA: 0x198A870 Offset: 0x1988E70 VA: 0x18198A870
	public LTDescr setMoveSpline() { }

	// RVA: 0x198A7A0 Offset: 0x1988DA0 VA: 0x18198A7A0
	public LTDescr setMoveSplineLocal() { }

	// RVA: 0x198BC50 Offset: 0x198A250 VA: 0x18198BC50
	public LTDescr setScaleX() { }

	// RVA: 0x198BD20 Offset: 0x198A320 VA: 0x18198BD20
	public LTDescr setScaleY() { }

	// RVA: 0x198BDF0 Offset: 0x198A3F0 VA: 0x18198BDF0
	public LTDescr setScaleZ() { }

	// RVA: 0x198B910 Offset: 0x1989F10 VA: 0x18198B910
	public LTDescr setRotateX() { }

	// RVA: 0x198B9E0 Offset: 0x1989FE0 VA: 0x18198B9E0
	public LTDescr setRotateY() { }

	// RVA: 0x198BAB0 Offset: 0x198A0B0 VA: 0x18198BAB0
	public LTDescr setRotateZ() { }

	// RVA: 0x198B770 Offset: 0x1989D70 VA: 0x18198B770
	public LTDescr setRotateAround() { }

	// RVA: 0x198B6A0 Offset: 0x1989CA0 VA: 0x18198B6A0
	public LTDescr setRotateAroundLocal() { }

	// RVA: 0x1986B70 Offset: 0x1985170 VA: 0x181986B70
	public LTDescr setAlpha() { }

	// RVA: 0x198C000 Offset: 0x198A600 VA: 0x18198C000
	public LTDescr setTextAlpha() { }

	// RVA: 0x1986AA0 Offset: 0x19850A0 VA: 0x181986AA0
	public LTDescr setAlphaVertex() { }

	// RVA: 0x1987890 Offset: 0x1985E90 VA: 0x181987890
	public LTDescr setColor() { }

	// RVA: 0x1986CB0 Offset: 0x19852B0 VA: 0x181986CB0
	public LTDescr setCallbackColor() { }

	// RVA: 0x198C0D0 Offset: 0x198A6D0 VA: 0x18198C0D0
	public LTDescr setTextColor() { }

	// RVA: 0x1986ED0 Offset: 0x19854D0 VA: 0x181986ED0
	public LTDescr setCanvasAlpha() { }

	// RVA: 0x1987070 Offset: 0x1985670 VA: 0x181987070
	public LTDescr setCanvasGroupAlpha() { }

	// RVA: 0x1986FA0 Offset: 0x19855A0 VA: 0x181986FA0
	public LTDescr setCanvasColor() { }

	// RVA: 0x1987140 Offset: 0x1985740 VA: 0x181987140
	public LTDescr setCanvasMoveX() { }

	// RVA: 0x1987210 Offset: 0x1985810 VA: 0x181987210
	public LTDescr setCanvasMoveY() { }

	// RVA: 0x19872E0 Offset: 0x19858E0 VA: 0x1819872E0
	public LTDescr setCanvasMoveZ() { }

	// RVA: 0x1986410 Offset: 0x1984A10 VA: 0x181986410
	private void initCanvasRotateAround() { }

	// RVA: 0x1987620 Offset: 0x1985C20 VA: 0x181987620
	public LTDescr setCanvasRotateAround() { }

	// RVA: 0x1987550 Offset: 0x1985B50 VA: 0x181987550
	public LTDescr setCanvasRotateAroundLocal() { }

	// RVA: 0x1987480 Offset: 0x1985A80 VA: 0x181987480
	public LTDescr setCanvasPlaySprite() { }

	// RVA: 0x19873B0 Offset: 0x19859B0 VA: 0x1819873B0
	public LTDescr setCanvasMove() { }

	// RVA: 0x19876F0 Offset: 0x1985CF0 VA: 0x1819876F0
	public LTDescr setCanvasScale() { }

	// RVA: 0x19877C0 Offset: 0x1985DC0 VA: 0x1819877C0
	public LTDescr setCanvasSizeDelta() { }

	// RVA: 0x1982A50 Offset: 0x1981050 VA: 0x181982A50
	private void callback() { }

	// RVA: 0x1986D80 Offset: 0x1985380 VA: 0x181986D80
	public LTDescr setCallback() { }

	// RVA: 0x198C2F0 Offset: 0x198A8F0 VA: 0x18198C2F0
	public LTDescr setValue3() { }

	// RVA: 0x198AC80 Offset: 0x1989280 VA: 0x18198AC80
	public LTDescr setMove() { }

	// RVA: 0x198A6D0 Offset: 0x1988CD0 VA: 0x18198A6D0
	public LTDescr setMoveLocal() { }

	// RVA: 0x198A940 Offset: 0x1988F40 VA: 0x18198A940
	public LTDescr setMoveToTransform() { }

	// RVA: 0x198BB80 Offset: 0x198A180 VA: 0x18198BB80
	public LTDescr setRotate() { }

	// RVA: 0x198B840 Offset: 0x1989E40 VA: 0x18198B840
	public LTDescr setRotateLocal() { }

	// RVA: 0x198BED0 Offset: 0x198A4D0 VA: 0x18198BED0
	public LTDescr setScale() { }

	// RVA: 0x1989F80 Offset: 0x1988580 VA: 0x181989F80
	public LTDescr setGUIMove() { }

	// RVA: 0x1989EB0 Offset: 0x19884B0 VA: 0x181989EB0
	public LTDescr setGUIMoveMargin() { }

	// RVA: 0x198A120 Offset: 0x1988720 VA: 0x18198A120
	public LTDescr setGUIScale() { }

	// RVA: 0x1989DE0 Offset: 0x19883E0 VA: 0x181989DE0
	public LTDescr setGUIAlpha() { }

	// RVA: 0x198A050 Offset: 0x1988650 VA: 0x18198A050
	public LTDescr setGUIRotate() { }

	// RVA: 0x1987970 Offset: 0x1985F70 VA: 0x181987970
	public LTDescr setDelayedSound() { }

	// RVA: 0x19865E0 Offset: 0x1984BE0 VA: 0x1819865E0
	private void init() { }

	// RVA: 0x1986470 Offset: 0x1984A70 VA: 0x181986470
	private void initSpeed() { }

	// RVA: 0x198D3D0 Offset: 0x198B9D0 VA: 0x18198D3D0
	public LTDescr updateNow() { }

	// RVA: 0x198CEE0 Offset: 0x198B4E0 VA: 0x18198CEE0
	public bool updateInternal() { }

	// RVA: 0x1982930 Offset: 0x1980F30 VA: 0x181982930
	public void callOnCompletes() { }

	// RVA: 0x1989A30 Offset: 0x1988030 VA: 0x181989A30
	public LTDescr setFromColor(Color col) { }

	// RVA: 0x19824E0 Offset: 0x1980AE0 VA: 0x1819824E0
	private static void alphaRecursive(Transform transform, float val, bool useRecursion = True) { }

	// RVA: 0x1982E40 Offset: 0x1981440 VA: 0x181982E40
	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = True) { }

	// RVA: 0x1982200 Offset: 0x1980800 VA: 0x181982200
	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0) { }

	// RVA: 0x1981F60 Offset: 0x1980560 VA: 0x181981F60
	private static void alphaRecursiveSprite(Transform transform, float val) { }

	// RVA: 0x1982BA0 Offset: 0x19811A0 VA: 0x181982BA0
	private static void colorRecursiveSprite(Transform transform, Color toColor) { }

	// RVA: 0x1983130 Offset: 0x1981730 VA: 0x181983130
	private static void colorRecursive(RectTransform rectTransform, Color toColor) { }

	// RVA: 0x198C470 Offset: 0x198AA70 VA: 0x18198C470
	private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = True) { }

	// RVA: 0x198C6E0 Offset: 0x198ACE0 VA: 0x18198C6E0
	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = True) { }

	// RVA: 0x198C990 Offset: 0x198AF90 VA: 0x18198C990
	private static void textColorRecursive(Transform trans, Color toColor) { }

	// RVA: 0x198CBC0 Offset: 0x198B1C0 VA: 0x18198CBC0
	private static Color tweenColor(LTDescr tween, float val) { }

	// RVA: 0x19867E0 Offset: 0x1984DE0 VA: 0x1819867E0
	public LTDescr pause() { }

	// RVA: 0x1986A90 Offset: 0x1985090 VA: 0x181986A90
	public LTDescr resume() { }

	// RVA: 0x1986C80 Offset: 0x1985280 VA: 0x181986C80
	public LTDescr setAxis(Vector3 axis) { }

	// RVA: 0x1987960 Offset: 0x1985F60 VA: 0x181987960
	public LTDescr setDelay(float delay) { }

	// RVA: 0x19890A0 Offset: 0x19876A0 VA: 0x1819890A0
	public LTDescr setEase(LeanTweenType easeType) { }

	// RVA: 0x1988770 Offset: 0x1986D70 VA: 0x181988770
	public LTDescr setEaseLinear() { }

	// RVA: 0x1988F60 Offset: 0x1987560 VA: 0x181988F60
	public LTDescr setEaseSpring() { }

	// RVA: 0x1988530 Offset: 0x1986B30 VA: 0x181988530
	public LTDescr setEaseInQuad() { }

	// RVA: 0x1988B60 Offset: 0x1987160 VA: 0x181988B60
	public LTDescr setEaseOutQuad() { }

	// RVA: 0x19882F0 Offset: 0x19868F0 VA: 0x1819882F0
	public LTDescr setEaseInOutQuad() { }

	// RVA: 0x1987DE0 Offset: 0x19863E0 VA: 0x181987DE0
	public LTDescr setEaseInCubic() { }

	// RVA: 0x19889B0 Offset: 0x1986FB0 VA: 0x1819889B0
	public LTDescr setEaseOutCubic() { }

	// RVA: 0x1988140 Offset: 0x1986740 VA: 0x181988140
	public LTDescr setEaseInOutCubic() { }

	// RVA: 0x19885C0 Offset: 0x1986BC0 VA: 0x1819885C0
	public LTDescr setEaseInQuart() { }

	// RVA: 0x1988BF0 Offset: 0x19871F0 VA: 0x181988BF0
	public LTDescr setEaseOutQuart() { }

	// RVA: 0x1988380 Offset: 0x1986980 VA: 0x181988380
	public LTDescr setEaseInOutQuart() { }

	// RVA: 0x1988650 Offset: 0x1986C50 VA: 0x181988650
	public LTDescr setEaseInQuint() { }

	// RVA: 0x1988C80 Offset: 0x1987280 VA: 0x181988C80
	public LTDescr setEaseOutQuint() { }

	// RVA: 0x1988410 Offset: 0x1986A10 VA: 0x181988410
	public LTDescr setEaseInOutQuint() { }

	// RVA: 0x19886E0 Offset: 0x1986CE0 VA: 0x1819886E0
	public LTDescr setEaseInSine() { }

	// RVA: 0x1988D10 Offset: 0x1987310 VA: 0x181988D10
	public LTDescr setEaseOutSine() { }

	// RVA: 0x19884A0 Offset: 0x1986AA0 VA: 0x1819884A0
	public LTDescr setEaseInOutSine() { }

	// RVA: 0x1987F00 Offset: 0x1986500 VA: 0x181987F00
	public LTDescr setEaseInExpo() { }

	// RVA: 0x1988AD0 Offset: 0x19870D0 VA: 0x181988AD0
	public LTDescr setEaseOutExpo() { }

	// RVA: 0x1988260 Offset: 0x1986860 VA: 0x181988260
	public LTDescr setEaseInOutExpo() { }

	// RVA: 0x1987D50 Offset: 0x1986350 VA: 0x181987D50
	public LTDescr setEaseInCirc() { }

	// RVA: 0x1988920 Offset: 0x1986F20 VA: 0x181988920
	public LTDescr setEaseOutCirc() { }

	// RVA: 0x19880B0 Offset: 0x19866B0 VA: 0x1819880B0
	public LTDescr setEaseInOutCirc() { }

	// RVA: 0x1987CC0 Offset: 0x19862C0 VA: 0x181987CC0
	public LTDescr setEaseInBounce() { }

	// RVA: 0x1988890 Offset: 0x1986E90 VA: 0x181988890
	public LTDescr setEaseOutBounce() { }

	// RVA: 0x1988020 Offset: 0x1986620 VA: 0x181988020
	public LTDescr setEaseInOutBounce() { }

	// RVA: 0x1987C30 Offset: 0x1986230 VA: 0x181987C30
	public LTDescr setEaseInBack() { }

	// RVA: 0x1988800 Offset: 0x1986E00 VA: 0x181988800
	public LTDescr setEaseOutBack() { }

	// RVA: 0x1987F90 Offset: 0x1986590 VA: 0x181987F90
	public LTDescr setEaseInOutBack() { }

	// RVA: 0x1987E70 Offset: 0x1986470 VA: 0x181987E70
	public LTDescr setEaseInElastic() { }

	// RVA: 0x1988A40 Offset: 0x1987040 VA: 0x181988A40
	public LTDescr setEaseOutElastic() { }

	// RVA: 0x19881D0 Offset: 0x19867D0 VA: 0x1819881D0
	public LTDescr setEaseInOutElastic() { }

	// RVA: 0x1988DA0 Offset: 0x19873A0 VA: 0x181988DA0
	public LTDescr setEasePunch() { }

	// RVA: 0x1988E80 Offset: 0x1987480 VA: 0x181988E80
	public LTDescr setEaseShake() { }

	// RVA: 0x198CD80 Offset: 0x198B380 VA: 0x18198CD80
	private Vector3 tweenOnCurve() { }

	// RVA: 0x1984850 Offset: 0x1982E50 VA: 0x181984850
	private Vector3 easeInOutQuad() { }

	// RVA: 0x1984E50 Offset: 0x1983450 VA: 0x181984E50
	private Vector3 easeInQuad() { }

	// RVA: 0x1985CF0 Offset: 0x19842F0 VA: 0x181985CF0
	private Vector3 easeOutQuad() { }

	// RVA: 0x19852F0 Offset: 0x19838F0 VA: 0x1819852F0
	private Vector3 easeLinear() { }

	// RVA: 0x19861E0 Offset: 0x19847E0 VA: 0x1819861E0
	private Vector3 easeSpring() { }

	// RVA: 0x1983850 Offset: 0x1981E50 VA: 0x181983850
	private Vector3 easeInCubic() { }

	// RVA: 0x1985910 Offset: 0x1983F10 VA: 0x181985910
	private Vector3 easeOutCubic() { }

	// RVA: 0x1984320 Offset: 0x1982920 VA: 0x181984320
	private Vector3 easeInOutCubic() { }

	// RVA: 0x1984F50 Offset: 0x1983550 VA: 0x181984F50
	private Vector3 easeInQuart() { }

	// RVA: 0x1985E20 Offset: 0x1984420 VA: 0x181985E20
	private Vector3 easeOutQuart() { }

	// RVA: 0x1984980 Offset: 0x1982F80 VA: 0x181984980
	private Vector3 easeInOutQuart() { }

	// RVA: 0x1985070 Offset: 0x1983670 VA: 0x181985070
	private Vector3 easeInQuint() { }

	// RVA: 0x1985F50 Offset: 0x1984550 VA: 0x181985F50
	private Vector3 easeOutQuint() { }

	// RVA: 0x1984BB0 Offset: 0x19831B0 VA: 0x181984BB0
	private Vector3 easeInOutQuint() { }

	// RVA: 0x1985180 Offset: 0x1983780 VA: 0x181985180
	private Vector3 easeInSine() { }

	// RVA: 0x1986080 Offset: 0x1984680 VA: 0x181986080
	private Vector3 easeOutSine() { }

	// RVA: 0x1984D10 Offset: 0x1983310 VA: 0x181984D10
	private Vector3 easeInOutSine() { }

	// RVA: 0x1983AD0 Offset: 0x19820D0 VA: 0x181983AD0
	private Vector3 easeInExpo() { }

	// RVA: 0x1985BB0 Offset: 0x19841B0 VA: 0x181985BB0
	private Vector3 easeOutExpo() { }

	// RVA: 0x19845F0 Offset: 0x1982BF0 VA: 0x1819845F0
	private Vector3 easeInOutExpo() { }

	// RVA: 0x1983710 Offset: 0x1981D10 VA: 0x181983710
	private Vector3 easeInCirc() { }

	// RVA: 0x19857C0 Offset: 0x1983DC0 VA: 0x1819857C0
	private Vector3 easeOutCirc() { }

	// RVA: 0x1984160 Offset: 0x1982760 VA: 0x181984160
	private Vector3 easeInOutCirc() { }

	// RVA: 0x1983550 Offset: 0x1981B50 VA: 0x181983550
	private Vector3 easeInBounce() { }

	// RVA: 0x1985530 Offset: 0x1983B30 VA: 0x181985530
	private Vector3 easeOutBounce() { }

	// RVA: 0x1983E70 Offset: 0x1982470 VA: 0x181983E70
	private Vector3 easeInOutBounce() { }

	// RVA: 0x19833A0 Offset: 0x19819A0 VA: 0x1819833A0
	private Vector3 easeInBack() { }

	// RVA: 0x19853D0 Offset: 0x19839D0 VA: 0x1819853D0
	private Vector3 easeOutBack() { }

	// RVA: 0x1983C10 Offset: 0x1982210 VA: 0x181983C10
	private Vector3 easeInOutBack() { }

	// RVA: 0x1983950 Offset: 0x1981F50 VA: 0x181983950
	private Vector3 easeInElastic() { }

	// RVA: 0x1985A30 Offset: 0x1984030 VA: 0x181985A30
	private Vector3 easeOutElastic() { }

	// RVA: 0x1984470 Offset: 0x1982A70 VA: 0x181984470
	private Vector3 easeInOutElastic() { }

	// RVA: 0x198B4C0 Offset: 0x1989AC0 VA: 0x18198B4C0
	public LTDescr setOvershoot(float overshoot) { }

	// RVA: 0x198B510 Offset: 0x1989B10 VA: 0x18198B510
	public LTDescr setPeriod(float period) { }

	// RVA: 0x198BEC0 Offset: 0x198A4C0 VA: 0x18198BEC0
	public LTDescr setScale(float scale) { }

	// RVA: 0x1988FF0 Offset: 0x19875F0 VA: 0x181988FF0
	public LTDescr setEase(AnimationCurve easeCurve) { }

	// RVA: 0x198C1C0 Offset: 0x198A7C0 VA: 0x18198C1C0
	public LTDescr setTo(Vector3 to) { }

	// RVA: 0x198C2A0 Offset: 0x198A8A0 VA: 0x18198C2A0
	public LTDescr setTo(Transform to) { }

	// RVA: 0x1989B20 Offset: 0x1988120 VA: 0x181989B20
	public LTDescr setFrom(Vector3 from) { }

	// RVA: 0x1989C70 Offset: 0x1988270 VA: 0x181989C70
	public LTDescr setFrom(float from) { }

	// RVA: 0x1987A50 Offset: 0x1986050 VA: 0x181987A50
	public LTDescr setDiff(Vector3 diff) { }

	// RVA: 0x198A1F0 Offset: 0x19887F0 VA: 0x18198A1F0
	public LTDescr setHasInitialized(bool has) { }

	// RVA: 0x198A200 Offset: 0x1988800 VA: 0x18198A200
	public LTDescr setId(uint id, uint global_counter) { }

	// RVA: 0x198B4D0 Offset: 0x1989AD0 VA: 0x18198B4D0
	public LTDescr setPassed(float passed) { }

	// RVA: 0x198C1A0 Offset: 0x198A7A0 VA: 0x18198C1A0
	public LTDescr setTime(float time) { }

	// RVA: 0x198BFA0 Offset: 0x198A5A0 VA: 0x18198BFA0
	public LTDescr setSpeed(float speed) { }

	// RVA: 0x198B660 Offset: 0x1989C60 VA: 0x18198B660
	public LTDescr setRepeat(int repeat) { }

	// RVA: 0x198A2B0 Offset: 0x19888B0 VA: 0x18198A2B0
	public LTDescr setLoopType(LeanTweenType loopType) { }

	// RVA: 0x198A210 Offset: 0x1988810 VA: 0x18198A210
	public LTDescr setUseEstimatedTime(bool useEstimatedTime) { }

	// RVA: 0x198A210 Offset: 0x1988810 VA: 0x18198A210
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime) { }

	// RVA: 0x198C2D0 Offset: 0x198A8D0 VA: 0x18198C2D0
	public LTDescr setUseFrames(bool useFrames) { }

	// RVA: 0x198C2E0 Offset: 0x198A8E0 VA: 0x18198C2E0
	public LTDescr setUseManualTime(bool useManualTime) { }

	// RVA: 0x198A240 Offset: 0x1988840 VA: 0x18198A240
	public LTDescr setLoopCount(int loopCount) { }

	// RVA: 0x198A260 Offset: 0x1988860 VA: 0x18198A260
	public LTDescr setLoopOnce() { }

	// RVA: 0x198A220 Offset: 0x1988820 VA: 0x18198A220
	public LTDescr setLoopClamp() { }

	// RVA: 0xE72F50 Offset: 0xE71550 VA: 0x180E72F50
	public LTDescr setLoopClamp(int loops) { }

	// RVA: 0x198A270 Offset: 0x1988870 VA: 0x18198A270
	public LTDescr setLoopPingPong() { }

	// RVA: 0x198A290 Offset: 0x1988890 VA: 0x18198A290
	public LTDescr setLoopPingPong(int loops) { }

	// RVA: 0x198AE20 Offset: 0x1989420 VA: 0x18198AE20
	public LTDescr setOnComplete(Action onComplete) { }

	// RVA: 0x198AE60 Offset: 0x1989460 VA: 0x18198AE60
	public LTDescr setOnComplete(Action<object> onComplete) { }

	// RVA: 0x198ADB0 Offset: 0x19893B0 VA: 0x18198ADB0
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam) { }

	// RVA: 0x198AD70 Offset: 0x1989370 VA: 0x18198AD70
	public LTDescr setOnCompleteParam(object onCompleteParam) { }

	// RVA: 0x198B110 Offset: 0x1989710 VA: 0x18198B110
	public LTDescr setOnUpdate(Action<float> onUpdate) { }

	// RVA: 0x198AFE0 Offset: 0x19895E0 VA: 0x18198AFE0
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate) { }

	// RVA: 0x198AF60 Offset: 0x1989560 VA: 0x18198AF60
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate) { }

	// RVA: 0x198B020 Offset: 0x1989620 VA: 0x18198B020
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate) { }

	// RVA: 0x198B060 Offset: 0x1989660 VA: 0x18198B060
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate) { }

	// RVA: 0x198AEE0 Offset: 0x19894E0 VA: 0x18198AEE0
	public LTDescr setOnUpdateColor(Action<Color> onUpdate) { }

	// RVA: 0x198AF20 Offset: 0x1989520 VA: 0x18198AF20
	public LTDescr setOnUpdateColor(Action<Color, object> onUpdate) { }

	// RVA: 0x198AEE0 Offset: 0x19894E0 VA: 0x18198AEE0
	public LTDescr setOnUpdate(Action<Color> onUpdate) { }

	// RVA: 0x198AF20 Offset: 0x1989520 VA: 0x18198AF20
	public LTDescr setOnUpdate(Action<Color, object> onUpdate) { }

	// RVA: 0x198B150 Offset: 0x1989750 VA: 0x18198B150
	public LTDescr setOnUpdate(Action<float, object> onUpdate, object onUpdateParam) { }

	// RVA: 0x198B0A0 Offset: 0x19896A0 VA: 0x18198B0A0
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, object onUpdateParam) { }

	// RVA: 0x198B1C0 Offset: 0x19897C0 VA: 0x18198B1C0
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, object onUpdateParam) { }

	// RVA: 0x198B230 Offset: 0x1989830 VA: 0x18198B230
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, object onUpdateParam) { }

	// RVA: 0x198AFA0 Offset: 0x19895A0 VA: 0x18198AFA0
	public LTDescr setOnUpdateParam(object onUpdateParam) { }

	// RVA: 0x198B3D0 Offset: 0x19899D0 VA: 0x18198B3D0
	public LTDescr setOrientToPath(bool doesOrient) { }

	// RVA: 0x198B2A0 Offset: 0x19898A0 VA: 0x18198B2A0
	public LTDescr setOrientToPath2d(bool doesOrient2d) { }

	// RVA: 0x198B550 Offset: 0x1989B50 VA: 0x18198B550
	public LTDescr setRect(LTRect rect) { }

	// RVA: 0x198B5B0 Offset: 0x1989BB0 VA: 0x18198B5B0
	public LTDescr setRect(Rect rect) { }

	// RVA: 0x198B4E0 Offset: 0x1989AE0 VA: 0x18198B4E0
	public LTDescr setPath(LTBezierPath path) { }

	// RVA: 0x198B520 Offset: 0x1989B20 VA: 0x18198B520
	public LTDescr setPoint(Vector3 point) { }

	// RVA: 0x1987A40 Offset: 0x1986040 VA: 0x181987A40
	public LTDescr setDestroyOnComplete(bool doesDestroy) { }

	// RVA: 0x1986C40 Offset: 0x1985240 VA: 0x181986C40
	public LTDescr setAudio(object audio) { }

	// RVA: 0x198AD50 Offset: 0x1989350 VA: 0x18198AD50
	public LTDescr setOnCompleteOnRepeat(bool isOn) { }

	// RVA: 0x198AD60 Offset: 0x1989360 VA: 0x18198AD60
	public LTDescr setOnCompleteOnStart(bool isOn) { }

	// RVA: 0x198B580 Offset: 0x1989B80 VA: 0x18198B580
	public LTDescr setRect(RectTransform rect) { }

	// RVA: 0x198BFD0 Offset: 0x198A5D0 VA: 0x18198BFD0
	public LTDescr setSprites(Sprite[] sprites) { }

	// RVA: 0x1989A00 Offset: 0x1988000 VA: 0x181989A00
	public LTDescr setFrameRate(float frameRate) { }

	// RVA: 0x198AEA0 Offset: 0x19894A0 VA: 0x18198AEA0
	public LTDescr setOnStart(Action onStart) { }

	// RVA: 0x1987A70 Offset: 0x1986070 VA: 0x181987A70
	public LTDescr setDirection(float direction) { }

	// RVA: 0x198B650 Offset: 0x1989C50 VA: 0x18198B650
	public LTDescr setRecursive(bool useRecursion) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19803B0 Offset: 0x197E9B0 VA: 0x1819803B0
	private void <setMoveX>b__71_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19803E0 Offset: 0x197E9E0 VA: 0x1819803E0
	private void <setMoveX>b__71_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19804D0 Offset: 0x197EAD0 VA: 0x1819804D0
	private void <setMoveY>b__72_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1980510 Offset: 0x197EB10 VA: 0x181980510
	private void <setMoveY>b__72_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1980610 Offset: 0x197EC10 VA: 0x181980610
	private void <setMoveZ>b__73_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1980650 Offset: 0x197EC50 VA: 0x181980650
	private void <setMoveZ>b__73_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197FB90 Offset: 0x197E190 VA: 0x18197FB90
	private void <setMoveLocalX>b__74_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197FBC0 Offset: 0x197E1C0 VA: 0x18197FBC0
	private void <setMoveLocalX>b__74_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197FCB0 Offset: 0x197E2B0 VA: 0x18197FCB0
	private void <setMoveLocalY>b__75_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197FCF0 Offset: 0x197E2F0 VA: 0x18197FCF0
	private void <setMoveLocalY>b__75_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197FDF0 Offset: 0x197E3F0 VA: 0x18197FDF0
	private void <setMoveLocalZ>b__76_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197FE30 Offset: 0x197E430 VA: 0x18197FE30
	private void <setMoveLocalZ>b__76_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197F720 Offset: 0x197DD20 VA: 0x18197F720
	private void <setMoveCurved>b__78_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197F2F0 Offset: 0x197D8F0 VA: 0x18197F2F0
	private void <setMoveCurvedLocal>b__79_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1980010 Offset: 0x197E610 VA: 0x181980010
	private void <setMoveSpline>b__80_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197FF10 Offset: 0x197E510 VA: 0x18197FF10
	private void <setMoveSplineLocal>b__81_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19817E0 Offset: 0x197FDE0 VA: 0x1819817E0
	private void <setScaleX>b__82_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1981810 Offset: 0x197FE10 VA: 0x181981810
	private void <setScaleX>b__82_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1981900 Offset: 0x197FF00 VA: 0x181981900
	private void <setScaleY>b__83_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1981940 Offset: 0x197FF40 VA: 0x181981940
	private void <setScaleY>b__83_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1981A40 Offset: 0x1980040 VA: 0x181981A40
	private void <setScaleZ>b__84_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1981A80 Offset: 0x1980080 VA: 0x181981A80
	private void <setScaleZ>b__84_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1981240 Offset: 0x197F840 VA: 0x181981240
	private void <setRotateX>b__85_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19812E0 Offset: 0x197F8E0 VA: 0x1819812E0
	private void <setRotateX>b__85_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19813D0 Offset: 0x197F9D0 VA: 0x1819813D0
	private void <setRotateY>b__86_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1981470 Offset: 0x197FA70 VA: 0x181981470
	private void <setRotateY>b__86_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1981570 Offset: 0x197FB70 VA: 0x181981570
	private void <setRotateZ>b__87_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1981620 Offset: 0x197FC20 VA: 0x181981620
	private void <setRotateZ>b__87_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1980B20 Offset: 0x197F120 VA: 0x181980B20
	private void <setRotateAround>b__88_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1980B70 Offset: 0x197F170 VA: 0x181980B70
	private void <setRotateAround>b__88_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1980730 Offset: 0x197ED30 VA: 0x181980730
	private void <setRotateAroundLocal>b__89_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1980780 Offset: 0x197ED80 VA: 0x181980780
	private void <setRotateAroundLocal>b__89_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197C280 Offset: 0x197A880 VA: 0x18197C280
	private void <setAlpha>b__90_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197C980 Offset: 0x197AF80 VA: 0x18197C980
	private void <setAlpha>b__90_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197C790 Offset: 0x197AD90 VA: 0x18197C790
	private void <setAlpha>b__90_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1981B60 Offset: 0x1980160 VA: 0x181981B60
	private void <setTextAlpha>b__91_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1981C50 Offset: 0x1980250 VA: 0x181981C50
	private void <setTextAlpha>b__91_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197CB50 Offset: 0x197B150 VA: 0x18197CB50
	private void <setAlphaVertex>b__92_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197CBE0 Offset: 0x197B1E0 VA: 0x18197CBE0
	private void <setAlphaVertex>b__92_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197E5E0 Offset: 0x197CBE0 VA: 0x18197E5E0
	private void <setColor>b__93_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197EAC0 Offset: 0x197D0C0 VA: 0x18197EAC0
	private void <setColor>b__93_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197CE60 Offset: 0x197B460 VA: 0x18197CE60
	private void <setCallbackColor>b__94_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197CEB0 Offset: 0x197B4B0 VA: 0x18197CEB0
	private void <setCallbackColor>b__94_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1981CA0 Offset: 0x19802A0 VA: 0x181981CA0
	private void <setTextColor>b__95_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1981DA0 Offset: 0x19803A0 VA: 0x181981DA0
	private void <setTextColor>b__95_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197D080 Offset: 0x197B680 VA: 0x18197D080
	private void <setCanvasAlpha>b__96_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197D1E0 Offset: 0x197B7E0 VA: 0x18197D1E0
	private void <setCanvasAlpha>b__96_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197D750 Offset: 0x197BD50 VA: 0x18197D750
	private void <setCanvasGroupAlpha>b__97_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197D7B0 Offset: 0x197BDB0 VA: 0x18197D7B0
	private void <setCanvasGroupAlpha>b__97_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197D3F0 Offset: 0x197B9F0 VA: 0x18197D3F0
	private void <setCanvasColor>b__98_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197D590 Offset: 0x197BB90 VA: 0x18197D590
	private void <setCanvasColor>b__98_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197D8D0 Offset: 0x197BED0 VA: 0x18197D8D0
	private void <setCanvasMoveX>b__99_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197D910 Offset: 0x197BF10 VA: 0x18197D910
	private void <setCanvasMoveX>b__99_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197D9D0 Offset: 0x197BFD0 VA: 0x18197D9D0
	private void <setCanvasMoveY>b__100_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197DA10 Offset: 0x197C010 VA: 0x18197DA10
	private void <setCanvasMoveY>b__100_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197DAD0 Offset: 0x197C0D0 VA: 0x18197DAD0
	private void <setCanvasMoveZ>b__101_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197DB10 Offset: 0x197C110 VA: 0x18197DB10
	private void <setCanvasMoveZ>b__101_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197E100 Offset: 0x197C700 VA: 0x18197E100
	private void <setCanvasRotateAround>b__103_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197DDD0 Offset: 0x197C3D0 VA: 0x18197DDD0
	private void <setCanvasRotateAroundLocal>b__104_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197DBE0 Offset: 0x197C1E0 VA: 0x18197DBE0
	private void <setCanvasPlaySprite>b__105_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197DC40 Offset: 0x197C240 VA: 0x18197DC40
	private void <setCanvasPlaySprite>b__105_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197D830 Offset: 0x197BE30 VA: 0x18197D830
	private void <setCanvasMove>b__106_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197D870 Offset: 0x197BE70 VA: 0x18197D870
	private void <setCanvasMove>b__106_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197E3F0 Offset: 0x197C9F0 VA: 0x18197E3F0
	private void <setCanvasScale>b__107_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197E430 Offset: 0x197CA30 VA: 0x18197E430
	private void <setCanvasScale>b__107_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197E490 Offset: 0x197CA90 VA: 0x18197E490
	private void <setCanvasSizeDelta>b__108_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197E530 Offset: 0x197CB30 VA: 0x18197E530
	private void <setCanvasSizeDelta>b__108_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1980110 Offset: 0x197E710 VA: 0x181980110
	private void <setMove>b__112_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1980310 Offset: 0x197E910 VA: 0x181980310
	private void <setMove>b__112_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197FAB0 Offset: 0x197E0B0 VA: 0x18197FAB0
	private void <setMoveLocal>b__113_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197FAF0 Offset: 0x197E0F0 VA: 0x18197FAF0
	private void <setMoveLocal>b__113_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1980110 Offset: 0x197E710 VA: 0x181980110
	private void <setMoveToTransform>b__114_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1980150 Offset: 0x197E750 VA: 0x181980150
	private void <setMoveToTransform>b__114_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1981070 Offset: 0x197F670 VA: 0x181981070
	private void <setRotate>b__115_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19811A0 Offset: 0x197F7A0 VA: 0x1819811A0
	private void <setRotate>b__115_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1980EA0 Offset: 0x197F4A0 VA: 0x181980EA0
	private void <setRotateLocal>b__116_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1980FD0 Offset: 0x197F5D0 VA: 0x181980FD0
	private void <setRotateLocal>b__116_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1981700 Offset: 0x197FD00 VA: 0x181981700
	private void <setScale>b__117_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1981740 Offset: 0x197FD40 VA: 0x181981740
	private void <setScale>b__117_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197EE60 Offset: 0x197D460 VA: 0x18197EE60
	private void <setGUIMove>b__118_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197EF30 Offset: 0x197D530 VA: 0x18197EF30
	private void <setGUIMove>b__118_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197ED20 Offset: 0x197D320 VA: 0x18197ED20
	private void <setGUIMoveMargin>b__119_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197EDD0 Offset: 0x197D3D0 VA: 0x18197EDD0
	private void <setGUIMoveMargin>b__119_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197F110 Offset: 0x197D710 VA: 0x18197F110
	private void <setGUIScale>b__120_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197F1E0 Offset: 0x197D7E0 VA: 0x18197F1E0
	private void <setGUIScale>b__120_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197ECA0 Offset: 0x197D2A0 VA: 0x18197ECA0
	private void <setGUIAlpha>b__121_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197ECD0 Offset: 0x197D2D0 VA: 0x18197ECD0
	private void <setGUIAlpha>b__121_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197F050 Offset: 0x197D650 VA: 0x18197F050
	private void <setGUIRotate>b__122_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197F0C0 Offset: 0x197D6C0 VA: 0x18197F0C0
	private void <setGUIRotate>b__122_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x197EC90 Offset: 0x197D290 VA: 0x18197EC90
	private void <setDelayedSound>b__123_0() { }

}

public sealed class LTDescr.EaseTypeDelegate : MulticastDelegate // TypeDefIndex: 5570
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1977E10 Offset: 0x1976410 VA: 0x181977E10 Slot: 12
	public virtual Vector3 Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1977DD0 Offset: 0x19763D0 VA: 0x181977DD0 Slot: 14
	public virtual Vector3 EndInvoke(IAsyncResult result) { }

}

public sealed class LTDescr.ActionMethodDelegate : MulticastDelegate // TypeDefIndex: 5571
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14638B0 Offset: 0x1461EB0 VA: 0x1814638B0 Slot: 12
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

	// RVA: 0x1992200 Offset: 0x1990800 VA: 0x181992200
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <setCallback>b__110_0() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void <setValue3>b__111_0() { }

}

