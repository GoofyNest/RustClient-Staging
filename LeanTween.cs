public class LeanTween : MonoBehaviour // TypeDefIndex: 5580
{	// Fields
	public static bool throwErrors; // 0x0
	public static float tau; // 0x4
	public static float PI_DIV2; // 0x8
	private static LTSeq[] sequences; // 0x10
	private static LTDescr[] tweens; // 0x18
	private static int[] tweensFinished; // 0x20
	private static int[] tweensFinishedIds; // 0x28
	private static LTDescr tween; // 0x30
	private static int tweenMaxSearch; // 0x38
	private static int maxTweens; // 0x3C
	private static int maxSequences; // 0x40
	private static int frameRendered; // 0x44
	private static GameObject _tweenEmpty; // 0x48
	public static float dtEstimated; // 0x50
	public static float dtManual; // 0x54
	public static float dtActual; // 0x58
	private static uint global_counter; // 0x5C
	private static int i; // 0x60
	private static int j; // 0x64
	private static int finishedCnt; // 0x68
	public static AnimationCurve punch; // 0x70
	public static AnimationCurve shake; // 0x78
	private static int maxTweenReached; // 0x80
	public static int startSearch; // 0x84
	public static LTDescr d; // 0x88
	private static Action<LTEvent>[] eventListeners; // 0x90
	private static GameObject[] goListeners; // 0x98
	private static int eventsMaxSearch; // 0xA0
	public static int EVENTS_MAX; // 0xA4
	public static int LISTENERS_MAX; // 0xA8
	private static int INIT_LISTENERS_MAX; // 0xAC

	// Properties
	public static int maxSearch { get; }
	public static int maxSimulataneousTweens { get; }
	public static int tweensRunning { get; }
	public static GameObject tweenEmpty { get; }

	// Methods

	// RVA: 0x21B4810 Offset: 0x21B2E10 VA: 0x1821B4810
	public static void init() { }

	// RVA: 0x21B4120 Offset: 0x21B2720 VA: 0x1821B4120
	public static int get_maxSearch() { }

	// RVA: 0x21B4180 Offset: 0x21B2780 VA: 0x1821B4180
	public static int get_maxSimulataneousTweens() { }

	// RVA: 0x21B42A0 Offset: 0x21B28A0 VA: 0x1821B42A0
	public static int get_tweensRunning() { }

	// RVA: 0x21B48C0 Offset: 0x21B2EC0 VA: 0x1821B48C0
	public static void init(int maxSimultaneousTweens) { }

	// RVA: 0x21B4380 Offset: 0x21B2980 VA: 0x1821B4380
	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences) { }

	// RVA: 0x21B8D70 Offset: 0x21B7370 VA: 0x1821B8D70
	public static void reset() { }

	// RVA: 0x21AE520 Offset: 0x21ACB20 VA: 0x1821AE520
	public void Update() { }

	// RVA: 0x21B7660 Offset: 0x21B5C60 VA: 0x1821B7660
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x21B4930 Offset: 0x21B2F30 VA: 0x1821B4930
	private static void internalOnLevelWasLoaded(int lvl) { }

	// RVA: 0x21BAFF0 Offset: 0x21B95F0 VA: 0x1821BAFF0
	public static void update() { }

	// RVA: 0x21B87D0 Offset: 0x21B6DD0 VA: 0x1821B87D0
	public static void removeTween(int i, int uniqueId) { }

	// RVA: 0x21B88A0 Offset: 0x21B6EA0 VA: 0x1821B88A0
	public static void removeTween(int i) { }

	// RVA: 0x21AF2D0 Offset: 0x21AD8D0 VA: 0x1821AF2D0
	public static Vector3[] add(Vector3[] a, Vector3 b) { }

	// RVA: 0x21B0A50 Offset: 0x21AF050 VA: 0x1821B0A50
	public static float closestRot(float from, float to) { }

	// RVA: 0x21AFAD0 Offset: 0x21AE0D0 VA: 0x1821AFAD0
	public static void cancelAll() { }

	// RVA: 0x21AFB20 Offset: 0x21AE120 VA: 0x1821AFB20
	public static void cancelAll(bool callComplete) { }

	// RVA: 0x21B03D0 Offset: 0x21AE9D0 VA: 0x1821B03D0
	public static void cancel(GameObject gameObject) { }

	// RVA: 0x21AFD90 Offset: 0x21AE390 VA: 0x1821AFD90
	public static void cancel(GameObject gameObject, bool callOnComplete) { }

	// RVA: 0x21B0910 Offset: 0x21AEF10 VA: 0x1821B0910
	public static void cancel(RectTransform rect) { }

	// RVA: 0x21B05D0 Offset: 0x21AEBD0 VA: 0x1821B05D0
	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = False) { }

	// RVA: 0x21B0430 Offset: 0x21AEA30 VA: 0x1821B0430
	public static void cancel(LTRect ltRect, int uniqueId) { }

	// RVA: 0x21B0570 Offset: 0x21AEB70 VA: 0x1821B0570
	public static void cancel(int uniqueId) { }

	// RVA: 0x21B0090 Offset: 0x21AE690 VA: 0x1821B0090
	public static void cancel(int uniqueId, bool callOnComplete) { }

	// RVA: 0x21B1660 Offset: 0x21AFC60 VA: 0x1821B1660
	public static LTDescr descr(int uniqueId) { }

	// RVA: 0x21B19B0 Offset: 0x21AFFB0 VA: 0x1821B19B0
	public static LTDescr description(int uniqueId) { }

	// RVA: 0x21B1A00 Offset: 0x21B0000 VA: 0x1821B1A00
	public static LTDescr[] descriptions(GameObject gameObject) { }

	[ObsoleteAttribute] // RVA: 0xB4AA0 Offset: 0xB3EA0 VA: 0x1800B4AA0
	// RVA: 0x21B7FB0 Offset: 0x21B65B0 VA: 0x1821B7FB0
	public static void pause(GameObject gameObject, int uniqueId) { }

	// RVA: 0x21B7EA0 Offset: 0x21B64A0 VA: 0x1821B7EA0
	public static void pause(int uniqueId) { }

	// RVA: 0x21B7D00 Offset: 0x21B6300 VA: 0x1821B7D00
	public static void pause(GameObject gameObject) { }

	// RVA: 0x21B7C00 Offset: 0x21B6200 VA: 0x1821B7C00
	public static void pauseAll() { }

	// RVA: 0x21B8F60 Offset: 0x21B7560 VA: 0x1821B8F60
	public static void resumeAll() { }

	[ObsoleteAttribute] // RVA: 0xB4B70 Offset: 0xB3F70 VA: 0x1800B4B70
	// RVA: 0x21B9310 Offset: 0x21B7910 VA: 0x1821B9310
	public static void resume(GameObject gameObject, int uniqueId) { }

	// RVA: 0x21B9200 Offset: 0x21B7800 VA: 0x1821B9200
	public static void resume(int uniqueId) { }

	// RVA: 0x21B9060 Offset: 0x21B7660 VA: 0x1821B9060
	public static void resume(GameObject gameObject) { }

	// RVA: 0x21B4AE0 Offset: 0x21B30E0 VA: 0x1821B4AE0
	public static bool isTweening(GameObject gameObject) { }

	// RVA: 0x21B4D50 Offset: 0x21B3350 VA: 0x1821B4D50
	public static bool isTweening(RectTransform rect) { }

	// RVA: 0x21B4980 Offset: 0x21B2F80 VA: 0x1821B4980
	public static bool isTweening(int uniqueId) { }

	// RVA: 0x21B4DC0 Offset: 0x21B33C0 VA: 0x1821B4DC0
	public static bool isTweening(LTRect ltRect) { }

	// RVA: 0x21B20C0 Offset: 0x21B06C0 VA: 0x1821B20C0
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0, Transform arrowTransform) { }

	// RVA: 0x21B4FA0 Offset: 0x21B35A0 VA: 0x1821B4FA0
	public static object logError(string error) { }

	// RVA: 0x21B7700 Offset: 0x21B5D00 VA: 0x1821B7700
	public static LTDescr options(LTDescr seed) { }

	// RVA: 0x21B7760 Offset: 0x21B5D60 VA: 0x1821B7760
	public static LTDescr options() { }

	// RVA: 0x21B41E0 Offset: 0x21B27E0 VA: 0x1821B41E0
	public static GameObject get_tweenEmpty() { }

	// RVA: 0x21B8230 Offset: 0x21B6830 VA: 0x1821B8230
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween) { }

	// RVA: 0x21B8100 Offset: 0x21B6700 VA: 0x1821B8100
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites) { }

	// RVA: 0x21AF8B0 Offset: 0x21ADEB0 VA: 0x1821AF8B0
	public static LTDescr alpha(GameObject gameObject, float to, float time) { }

	// RVA: 0x21BA610 Offset: 0x21B8C10 VA: 0x1821BA610
	public static LTSeq sequence(bool initSequence = True) { }

	// RVA: 0x21AF7A0 Offset: 0x21ADDA0 VA: 0x1821AF7A0
	public static LTDescr alpha(LTRect ltRect, float to, float time) { }

	// RVA: 0x21BABD0 Offset: 0x21B91D0 VA: 0x1821BABD0
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time) { }

	// RVA: 0x21AF5D0 Offset: 0x21ADBD0 VA: 0x1821AF5D0
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time) { }

	// RVA: 0x21AF4E0 Offset: 0x21ADAE0 VA: 0x1821AF4E0
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time) { }

	// RVA: 0x21AF6C0 Offset: 0x21ADCC0 VA: 0x1821AF6C0
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B0E00 Offset: 0x21AF400 VA: 0x1821B0E00
	public static LTDescr color(GameObject gameObject, Color to, float time) { }

	// RVA: 0x21BACC0 Offset: 0x21B92C0 VA: 0x1821BACC0
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time) { }

	// RVA: 0x21B0B30 Offset: 0x21AF130 VA: 0x1821B0B30
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time) { }

	// RVA: 0x21B1080 Offset: 0x21AF680 VA: 0x1821B1080
	public static LTDescr delayedCall(float delayTime, Action callback) { }

	// RVA: 0x21B1190 Offset: 0x21AF790 VA: 0x1821B1190
	public static LTDescr delayedCall(float delayTime, Action<object> callback) { }

	// RVA: 0x21B12A0 Offset: 0x21AF8A0 VA: 0x1821B12A0
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback) { }

	// RVA: 0x21B0F80 Offset: 0x21AF580 VA: 0x1821B0F80
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback) { }

	// RVA: 0x21B1C90 Offset: 0x21B0290 VA: 0x1821B1C90
	public static LTDescr destroyAfter(LTRect rect, float delayTime) { }

	// RVA: 0x21B69C0 Offset: 0x21B4FC0 VA: 0x1821B69C0
	public static LTDescr move(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21B7000 Offset: 0x21B5600 VA: 0x1821B7000
	public static LTDescr move(GameObject gameObject, Vector2 to, float time) { }

	// RVA: 0x21B6A70 Offset: 0x21B5070 VA: 0x1821B6A70
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B6DB0 Offset: 0x21B53B0 VA: 0x1821B6DB0
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time) { }

	// RVA: 0x21B7310 Offset: 0x21B5910 VA: 0x1821B7310
	public static LTDescr move(GameObject gameObject, LTSpline to, float time) { }

	// RVA: 0x21B6170 Offset: 0x21B4770 VA: 0x1821B6170
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B5F20 Offset: 0x21B4520 VA: 0x1821B5F20
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time) { }

	// RVA: 0x21B5CA0 Offset: 0x21B42A0 VA: 0x1821B5CA0
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B7120 Offset: 0x21B5720 VA: 0x1821B7120
	public static LTDescr move(LTRect ltRect, Vector2 to, float time) { }

	// RVA: 0x21B5B90 Offset: 0x21B4190 VA: 0x1821B5B90
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time) { }

	// RVA: 0x21B6500 Offset: 0x21B4B00 VA: 0x1821B6500
	public static LTDescr moveX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B66F0 Offset: 0x21B4CF0 VA: 0x1821B66F0
	public static LTDescr moveY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B67D0 Offset: 0x21B4DD0 VA: 0x1821B67D0
	public static LTDescr moveZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B5640 Offset: 0x21B3C40 VA: 0x1821B5640
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21B5300 Offset: 0x21B3900 VA: 0x1821B5300
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B5060 Offset: 0x21B3660 VA: 0x1821B5060
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B5140 Offset: 0x21B3740 VA: 0x1821B5140
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B5220 Offset: 0x21B3820 VA: 0x1821B5220
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B56F0 Offset: 0x21B3CF0 VA: 0x1821B56F0
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time) { }

	// RVA: 0x21B5940 Offset: 0x21B3F40 VA: 0x1821B5940
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time) { }

	// RVA: 0x21B7560 Offset: 0x21B5B60 VA: 0x1821B7560
	public static LTDescr move(GameObject gameObject, Transform to, float time) { }

	// RVA: 0x21B9EE0 Offset: 0x21B84E0 VA: 0x1821B9EE0
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21B9DE0 Offset: 0x21B83E0 VA: 0x1821B9DE0
	public static LTDescr rotate(LTRect ltRect, float to, float time) { }

	// RVA: 0x21B9920 Offset: 0x21B7F20 VA: 0x1821B9920
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21B99D0 Offset: 0x21B7FD0 VA: 0x1821B99D0
	public static LTDescr rotateX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B9AB0 Offset: 0x21B80B0 VA: 0x1821B9AB0
	public static LTDescr rotateY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B9B90 Offset: 0x21B8190 VA: 0x1821B9B90
	public static LTDescr rotateZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B9810 Offset: 0x21B7E10 VA: 0x1821B9810
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time) { }

	// RVA: 0x21B95B0 Offset: 0x21B7BB0 VA: 0x1821B95B0
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time) { }

	// RVA: 0x21BA480 Offset: 0x21B8A80 VA: 0x1821BA480
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21BA370 Offset: 0x21B8970 VA: 0x1821BA370
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time) { }

	// RVA: 0x21BA0D0 Offset: 0x21B86D0 VA: 0x1821BA0D0
	public static LTDescr scaleX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21BA1B0 Offset: 0x21B87B0 VA: 0x1821BA1B0
	public static LTDescr scaleY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21BA290 Offset: 0x21B8890 VA: 0x1821BA290
	public static LTDescr scaleZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21BB860 Offset: 0x21B9E60 VA: 0x1821BB860
	public static LTDescr value(GameObject gameObject, float from, float to, float time) { }

	// RVA: 0x21BC280 Offset: 0x21BA880 VA: 0x1821BC280
	public static LTDescr value(float from, float to, float time) { }

	// RVA: 0x21BBD20 Offset: 0x21BA320 VA: 0x1821BBD20
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time) { }

	// RVA: 0x21BC880 Offset: 0x21BAE80 VA: 0x1821BC880
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time) { }

	// RVA: 0x21BBB60 Offset: 0x21BA160 VA: 0x1821BBB60
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time) { }

	// RVA: 0x21BC3E0 Offset: 0x21BA9E0 VA: 0x1821BC3E0
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time) { }

	// RVA: 0x21BC0D0 Offset: 0x21BA6D0 VA: 0x1821BC0D0
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time) { }

	// RVA: 0x21BBEB0 Offset: 0x21BA4B0 VA: 0x1821BBEB0
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time) { }

	// RVA: 0x21BB640 Offset: 0x21B9C40 VA: 0x1821BB640
	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time) { }

	// RVA: 0x21BB9C0 Offset: 0x21B9FC0 VA: 0x1821BB9C0
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time) { }

	// RVA: 0x21BC750 Offset: 0x21BAD50 VA: 0x1821BC750
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time) { }

	// RVA: 0x21BC590 Offset: 0x21BAB90 VA: 0x1821BC590
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time) { }

	// RVA: 0x21B13A0 Offset: 0x21AF9A0 VA: 0x1821B13A0
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume) { }

	// RVA: 0x21B1500 Offset: 0x21AFB00 VA: 0x1821B1500
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume) { }

	// RVA: 0x21B7230 Offset: 0x21B5830 VA: 0x1821B7230
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time) { }

	// RVA: 0x21B63F0 Offset: 0x21B49F0 VA: 0x1821B63F0
	public static LTDescr moveX(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B65E0 Offset: 0x21B4BE0 VA: 0x1821B65E0
	public static LTDescr moveY(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B68B0 Offset: 0x21B4EB0 VA: 0x1821B68B0
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B9C70 Offset: 0x21B8270 VA: 0x1821B9C70
	public static LTDescr rotate(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B9F90 Offset: 0x21B8590 VA: 0x1821B9F90
	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time) { }

	// RVA: 0x21B96C0 Offset: 0x21B7CC0 VA: 0x1821B96C0
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time) { }

	// RVA: 0x21B9460 Offset: 0x21B7A60 VA: 0x1821B9460
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time) { }

	// RVA: 0x21BA530 Offset: 0x21B8B30 VA: 0x1821BA530
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time) { }

	// RVA: 0x21BA990 Offset: 0x21B8F90 VA: 0x1821BA990
	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time) { }

	// RVA: 0x21AF9C0 Offset: 0x21ADFC0 VA: 0x1821AF9C0
	public static LTDescr alpha(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B0C90 Offset: 0x21AF290 VA: 0x1821B0C90
	public static LTDescr color(RectTransform rectTrans, Color to, float time) { }

	// RVA: 0x21BAF90 Offset: 0x21B9590 VA: 0x1821BAF90
	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed) { }

	// RVA: 0x21BAE20 Offset: 0x21B9420 VA: 0x1821BAE20
	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed) { }

	// RVA: 0x21B3FC0 Offset: 0x21B25C0 VA: 0x1821B3FC0
	public static float easeOutQuadOpt(float start, float diff, float ratioPassed) { }

	// RVA: 0x21B3A90 Offset: 0x21B2090 VA: 0x1821B3A90
	public static float easeInQuadOpt(float start, float diff, float ratioPassed) { }

	// RVA: 0x21B3830 Offset: 0x21B1E30 VA: 0x1821B3830
	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed) { }

	// RVA: 0x21B3620 Offset: 0x21B1C20 VA: 0x1821B3620
	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed) { }

	// RVA: 0x21B4F20 Offset: 0x21B3520 VA: 0x1821B4F20
	public static float linear(float start, float end, float val) { }

	// RVA: 0x21B0980 Offset: 0x21AEF80 VA: 0x1821B0980
	public static float clerp(float start, float end, float val) { }

	// RVA: 0x21BAAB0 Offset: 0x21B90B0 VA: 0x1821BAAB0
	public static float spring(float start, float end, float val) { }

	// RVA: 0x21B3AA0 Offset: 0x21B20A0 VA: 0x1821B3AA0
	public static float easeInQuad(float start, float end, float val) { }

	// RVA: 0x21B3FE0 Offset: 0x21B25E0 VA: 0x1821B3FE0
	public static float easeOutQuad(float start, float end, float val) { }

	// RVA: 0x21B3890 Offset: 0x21B1E90 VA: 0x1821B3890
	public static float easeInOutQuad(float start, float end, float val) { }

	// RVA: 0x21B35E0 Offset: 0x21B1BE0 VA: 0x1821B35E0
	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2) { }

	// RVA: 0x21B2D40 Offset: 0x21B1340 VA: 0x1821B2D40
	public static float easeInCubic(float start, float end, float val) { }

	// RVA: 0x21B3D90 Offset: 0x21B2390 VA: 0x1821B3D90
	public static float easeOutCubic(float start, float end, float val) { }

	// RVA: 0x21B3270 Offset: 0x21B1870 VA: 0x1821B3270
	public static float easeInOutCubic(float start, float end, float val) { }

	// RVA: 0x21B3AC0 Offset: 0x21B20C0 VA: 0x1821B3AC0
	public static float easeInQuart(float start, float end, float val) { }

	// RVA: 0x21B4010 Offset: 0x21B2610 VA: 0x1821B4010
	public static float easeOutQuart(float start, float end, float val) { }

	// RVA: 0x21B3900 Offset: 0x21B1F00 VA: 0x1821B3900
	public static float easeInOutQuart(float start, float end, float val) { }

	// RVA: 0x21B3AE0 Offset: 0x21B20E0 VA: 0x1821B3AE0
	public static float easeInQuint(float start, float end, float val) { }

	// RVA: 0x21B4050 Offset: 0x21B2650 VA: 0x1821B4050
	public static float easeOutQuint(float start, float end, float val) { }

	// RVA: 0x21B3970 Offset: 0x21B1F70 VA: 0x1821B3970
	public static float easeInOutQuint(float start, float end, float val) { }

	// RVA: 0x21B3B00 Offset: 0x21B2100 VA: 0x1821B3B00
	public static float easeInSine(float start, float end, float val) { }

	// RVA: 0x21B4090 Offset: 0x21B2690 VA: 0x1821B4090
	public static float easeOutSine(float start, float end, float val) { }

	// RVA: 0x21B39E0 Offset: 0x21B1FE0 VA: 0x1821B39E0
	public static float easeInOutSine(float start, float end, float val) { }

	// RVA: 0x21B2EC0 Offset: 0x21B14C0 VA: 0x1821B2EC0
	public static float easeInExpo(float start, float end, float val) { }

	// RVA: 0x21B3F10 Offset: 0x21B2510 VA: 0x1821B3F10
	public static float easeOutExpo(float start, float end, float val) { }

	// RVA: 0x21B34D0 Offset: 0x21B1AD0 VA: 0x1821B34D0
	public static float easeInOutExpo(float start, float end, float val) { }

	// RVA: 0x21B2C90 Offset: 0x21B1290 VA: 0x1821B2C90
	public static float easeInCirc(float start, float end, float val) { }

	// RVA: 0x21B3CF0 Offset: 0x21B22F0 VA: 0x1821B3CF0
	public static float easeOutCirc(float start, float end, float val) { }

	// RVA: 0x21B3170 Offset: 0x21B1770 VA: 0x1821B3170
	public static float easeInOutCirc(float start, float end, float val) { }

	// RVA: 0x21B2BF0 Offset: 0x21B11F0 VA: 0x1821B2BF0
	public static float easeInBounce(float start, float end, float val) { }

	// RVA: 0x21B3BF0 Offset: 0x21B21F0 VA: 0x1821B3BF0
	public static float easeOutBounce(float start, float end, float val) { }

	// RVA: 0x21B3000 Offset: 0x21B1600 VA: 0x1821B3000
	public static float easeInOutBounce(float start, float end, float val) { }

	// RVA: 0x21B2BB0 Offset: 0x21B11B0 VA: 0x1821B2BB0
	public static float easeInBack(float start, float end, float val, float overshoot = 1) { }

	// RVA: 0x21B3BA0 Offset: 0x21B21A0 VA: 0x1821B3BA0
	public static float easeOutBack(float start, float end, float val, float overshoot = 1) { }

	// RVA: 0x21B2F60 Offset: 0x21B1560 VA: 0x1821B2F60
	public static float easeInOutBack(float start, float end, float val, float overshoot = 1) { }

	// RVA: 0x21B2D60 Offset: 0x21B1360 VA: 0x1821B2D60
	public static float easeInElastic(float start, float end, float val, float overshoot = 1, float period = 0,3) { }

	// RVA: 0x21B3DC0 Offset: 0x21B23C0 VA: 0x1821B3DC0
	public static float easeOutElastic(float start, float end, float val, float overshoot = 1, float period = 0,3) { }

	// RVA: 0x21B32D0 Offset: 0x21B18D0 VA: 0x1821B32D0
	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1, float period = 0,3) { }

	// RVA: 0x21AF260 Offset: 0x21AD860 VA: 0x1821AF260
	public static void addListener(int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21AECD0 Offset: 0x21AD2D0 VA: 0x1821AECD0
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21B8660 Offset: 0x21B6C60 VA: 0x1821B8660
	public static bool removeListener(int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21B86D0 Offset: 0x21B6CD0 VA: 0x1821B86D0
	public static bool removeListener(int eventId) { }

	// RVA: 0x21B8390 Offset: 0x21B6990 VA: 0x1821B8390
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21B1DB0 Offset: 0x21B03B0 VA: 0x1821B1DB0
	public static void dispatchEvent(int eventId) { }

	// RVA: 0x21B1E10 Offset: 0x21B0410 VA: 0x1821B1E10
	public static void dispatchEvent(int eventId, object data) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x21AE570 Offset: 0x21ACB70 VA: 0x1821AE570
	private static void .cctor() { }

}

