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

	// RVA: 0x21B4650 Offset: 0x21B2C50 VA: 0x1821B4650
	public static void init() { }

	// RVA: 0x21B3F60 Offset: 0x21B2560 VA: 0x1821B3F60
	public static int get_maxSearch() { }

	// RVA: 0x21B3FC0 Offset: 0x21B25C0 VA: 0x1821B3FC0
	public static int get_maxSimulataneousTweens() { }

	// RVA: 0x21B40E0 Offset: 0x21B26E0 VA: 0x1821B40E0
	public static int get_tweensRunning() { }

	// RVA: 0x21B4700 Offset: 0x21B2D00 VA: 0x1821B4700
	public static void init(int maxSimultaneousTweens) { }

	// RVA: 0x21B41C0 Offset: 0x21B27C0 VA: 0x1821B41C0
	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences) { }

	// RVA: 0x21B8BB0 Offset: 0x21B71B0 VA: 0x1821B8BB0
	public static void reset() { }

	// RVA: 0x21AE360 Offset: 0x21AC960 VA: 0x1821AE360
	public void Update() { }

	// RVA: 0x21B74A0 Offset: 0x21B5AA0 VA: 0x1821B74A0
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x21B4770 Offset: 0x21B2D70 VA: 0x1821B4770
	private static void internalOnLevelWasLoaded(int lvl) { }

	// RVA: 0x21BAE30 Offset: 0x21B9430 VA: 0x1821BAE30
	public static void update() { }

	// RVA: 0x21B8610 Offset: 0x21B6C10 VA: 0x1821B8610
	public static void removeTween(int i, int uniqueId) { }

	// RVA: 0x21B86E0 Offset: 0x21B6CE0 VA: 0x1821B86E0
	public static void removeTween(int i) { }

	// RVA: 0x21AF110 Offset: 0x21AD710 VA: 0x1821AF110
	public static Vector3[] add(Vector3[] a, Vector3 b) { }

	// RVA: 0x21B0890 Offset: 0x21AEE90 VA: 0x1821B0890
	public static float closestRot(float from, float to) { }

	// RVA: 0x21AF910 Offset: 0x21ADF10 VA: 0x1821AF910
	public static void cancelAll() { }

	// RVA: 0x21AF960 Offset: 0x21ADF60 VA: 0x1821AF960
	public static void cancelAll(bool callComplete) { }

	// RVA: 0x21B0210 Offset: 0x21AE810 VA: 0x1821B0210
	public static void cancel(GameObject gameObject) { }

	// RVA: 0x21AFBD0 Offset: 0x21AE1D0 VA: 0x1821AFBD0
	public static void cancel(GameObject gameObject, bool callOnComplete) { }

	// RVA: 0x21B0750 Offset: 0x21AED50 VA: 0x1821B0750
	public static void cancel(RectTransform rect) { }

	// RVA: 0x21B0410 Offset: 0x21AEA10 VA: 0x1821B0410
	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = False) { }

	// RVA: 0x21B0270 Offset: 0x21AE870 VA: 0x1821B0270
	public static void cancel(LTRect ltRect, int uniqueId) { }

	// RVA: 0x21B03B0 Offset: 0x21AE9B0 VA: 0x1821B03B0
	public static void cancel(int uniqueId) { }

	// RVA: 0x21AFED0 Offset: 0x21AE4D0 VA: 0x1821AFED0
	public static void cancel(int uniqueId, bool callOnComplete) { }

	// RVA: 0x21B14A0 Offset: 0x21AFAA0 VA: 0x1821B14A0
	public static LTDescr descr(int uniqueId) { }

	// RVA: 0x21B17F0 Offset: 0x21AFDF0 VA: 0x1821B17F0
	public static LTDescr description(int uniqueId) { }

	// RVA: 0x21B1840 Offset: 0x21AFE40 VA: 0x1821B1840
	public static LTDescr[] descriptions(GameObject gameObject) { }

	[ObsoleteAttribute] // RVA: 0xB4B40 Offset: 0xB3F40 VA: 0x1800B4B40
	// RVA: 0x21B7DF0 Offset: 0x21B63F0 VA: 0x1821B7DF0
	public static void pause(GameObject gameObject, int uniqueId) { }

	// RVA: 0x21B7CE0 Offset: 0x21B62E0 VA: 0x1821B7CE0
	public static void pause(int uniqueId) { }

	// RVA: 0x21B7B40 Offset: 0x21B6140 VA: 0x1821B7B40
	public static void pause(GameObject gameObject) { }

	// RVA: 0x21B7A40 Offset: 0x21B6040 VA: 0x1821B7A40
	public static void pauseAll() { }

	// RVA: 0x21B8DA0 Offset: 0x21B73A0 VA: 0x1821B8DA0
	public static void resumeAll() { }

	[ObsoleteAttribute] // RVA: 0xB4C10 Offset: 0xB4010 VA: 0x1800B4C10
	// RVA: 0x21B9150 Offset: 0x21B7750 VA: 0x1821B9150
	public static void resume(GameObject gameObject, int uniqueId) { }

	// RVA: 0x21B9040 Offset: 0x21B7640 VA: 0x1821B9040
	public static void resume(int uniqueId) { }

	// RVA: 0x21B8EA0 Offset: 0x21B74A0 VA: 0x1821B8EA0
	public static void resume(GameObject gameObject) { }

	// RVA: 0x21B4920 Offset: 0x21B2F20 VA: 0x1821B4920
	public static bool isTweening(GameObject gameObject) { }

	// RVA: 0x21B4B90 Offset: 0x21B3190 VA: 0x1821B4B90
	public static bool isTweening(RectTransform rect) { }

	// RVA: 0x21B47C0 Offset: 0x21B2DC0 VA: 0x1821B47C0
	public static bool isTweening(int uniqueId) { }

	// RVA: 0x21B4C00 Offset: 0x21B3200 VA: 0x1821B4C00
	public static bool isTweening(LTRect ltRect) { }

	// RVA: 0x21B1F00 Offset: 0x21B0500 VA: 0x1821B1F00
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0, Transform arrowTransform) { }

	// RVA: 0x21B4DE0 Offset: 0x21B33E0 VA: 0x1821B4DE0
	public static object logError(string error) { }

	// RVA: 0x21B7540 Offset: 0x21B5B40 VA: 0x1821B7540
	public static LTDescr options(LTDescr seed) { }

	// RVA: 0x21B75A0 Offset: 0x21B5BA0 VA: 0x1821B75A0
	public static LTDescr options() { }

	// RVA: 0x21B4020 Offset: 0x21B2620 VA: 0x1821B4020
	public static GameObject get_tweenEmpty() { }

	// RVA: 0x21B8070 Offset: 0x21B6670 VA: 0x1821B8070
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween) { }

	// RVA: 0x21B7F40 Offset: 0x21B6540 VA: 0x1821B7F40
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites) { }

	// RVA: 0x21AF6F0 Offset: 0x21ADCF0 VA: 0x1821AF6F0
	public static LTDescr alpha(GameObject gameObject, float to, float time) { }

	// RVA: 0x21BA450 Offset: 0x21B8A50 VA: 0x1821BA450
	public static LTSeq sequence(bool initSequence = True) { }

	// RVA: 0x21AF5E0 Offset: 0x21ADBE0 VA: 0x1821AF5E0
	public static LTDescr alpha(LTRect ltRect, float to, float time) { }

	// RVA: 0x21BAA10 Offset: 0x21B9010 VA: 0x1821BAA10
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time) { }

	// RVA: 0x21AF410 Offset: 0x21ADA10 VA: 0x1821AF410
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time) { }

	// RVA: 0x21AF320 Offset: 0x21AD920 VA: 0x1821AF320
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time) { }

	// RVA: 0x21AF500 Offset: 0x21ADB00 VA: 0x1821AF500
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B0C40 Offset: 0x21AF240 VA: 0x1821B0C40
	public static LTDescr color(GameObject gameObject, Color to, float time) { }

	// RVA: 0x21BAB00 Offset: 0x21B9100 VA: 0x1821BAB00
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time) { }

	// RVA: 0x21B0970 Offset: 0x21AEF70 VA: 0x1821B0970
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time) { }

	// RVA: 0x21B0EC0 Offset: 0x21AF4C0 VA: 0x1821B0EC0
	public static LTDescr delayedCall(float delayTime, Action callback) { }

	// RVA: 0x21B0FD0 Offset: 0x21AF5D0 VA: 0x1821B0FD0
	public static LTDescr delayedCall(float delayTime, Action<object> callback) { }

	// RVA: 0x21B10E0 Offset: 0x21AF6E0 VA: 0x1821B10E0
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback) { }

	// RVA: 0x21B0DC0 Offset: 0x21AF3C0 VA: 0x1821B0DC0
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback) { }

	// RVA: 0x21B1AD0 Offset: 0x21B00D0 VA: 0x1821B1AD0
	public static LTDescr destroyAfter(LTRect rect, float delayTime) { }

	// RVA: 0x21B6800 Offset: 0x21B4E00 VA: 0x1821B6800
	public static LTDescr move(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21B6E40 Offset: 0x21B5440 VA: 0x1821B6E40
	public static LTDescr move(GameObject gameObject, Vector2 to, float time) { }

	// RVA: 0x21B68B0 Offset: 0x21B4EB0 VA: 0x1821B68B0
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B6BF0 Offset: 0x21B51F0 VA: 0x1821B6BF0
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time) { }

	// RVA: 0x21B7150 Offset: 0x21B5750 VA: 0x1821B7150
	public static LTDescr move(GameObject gameObject, LTSpline to, float time) { }

	// RVA: 0x21B5FB0 Offset: 0x21B45B0 VA: 0x1821B5FB0
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B5D60 Offset: 0x21B4360 VA: 0x1821B5D60
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time) { }

	// RVA: 0x21B5AE0 Offset: 0x21B40E0 VA: 0x1821B5AE0
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B6F60 Offset: 0x21B5560 VA: 0x1821B6F60
	public static LTDescr move(LTRect ltRect, Vector2 to, float time) { }

	// RVA: 0x21B59D0 Offset: 0x21B3FD0 VA: 0x1821B59D0
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time) { }

	// RVA: 0x21B6340 Offset: 0x21B4940 VA: 0x1821B6340
	public static LTDescr moveX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B6530 Offset: 0x21B4B30 VA: 0x1821B6530
	public static LTDescr moveY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B6610 Offset: 0x21B4C10 VA: 0x1821B6610
	public static LTDescr moveZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B5480 Offset: 0x21B3A80 VA: 0x1821B5480
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21B5140 Offset: 0x21B3740 VA: 0x1821B5140
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B4EA0 Offset: 0x21B34A0 VA: 0x1821B4EA0
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B4F80 Offset: 0x21B3580 VA: 0x1821B4F80
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B5060 Offset: 0x21B3660 VA: 0x1821B5060
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B5530 Offset: 0x21B3B30 VA: 0x1821B5530
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time) { }

	// RVA: 0x21B5780 Offset: 0x21B3D80 VA: 0x1821B5780
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time) { }

	// RVA: 0x21B73A0 Offset: 0x21B59A0 VA: 0x1821B73A0
	public static LTDescr move(GameObject gameObject, Transform to, float time) { }

	// RVA: 0x21B9D20 Offset: 0x21B8320 VA: 0x1821B9D20
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21B9C20 Offset: 0x21B8220 VA: 0x1821B9C20
	public static LTDescr rotate(LTRect ltRect, float to, float time) { }

	// RVA: 0x21B9760 Offset: 0x21B7D60 VA: 0x1821B9760
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21B9810 Offset: 0x21B7E10 VA: 0x1821B9810
	public static LTDescr rotateX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B98F0 Offset: 0x21B7EF0 VA: 0x1821B98F0
	public static LTDescr rotateY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B99D0 Offset: 0x21B7FD0 VA: 0x1821B99D0
	public static LTDescr rotateZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B9650 Offset: 0x21B7C50 VA: 0x1821B9650
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time) { }

	// RVA: 0x21B93F0 Offset: 0x21B79F0 VA: 0x1821B93F0
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time) { }

	// RVA: 0x21BA2C0 Offset: 0x21B88C0 VA: 0x1821BA2C0
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21BA1B0 Offset: 0x21B87B0 VA: 0x1821BA1B0
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time) { }

	// RVA: 0x21B9F10 Offset: 0x21B8510 VA: 0x1821B9F10
	public static LTDescr scaleX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B9FF0 Offset: 0x21B85F0 VA: 0x1821B9FF0
	public static LTDescr scaleY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21BA0D0 Offset: 0x21B86D0 VA: 0x1821BA0D0
	public static LTDescr scaleZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21BB6A0 Offset: 0x21B9CA0 VA: 0x1821BB6A0
	public static LTDescr value(GameObject gameObject, float from, float to, float time) { }

	// RVA: 0x21BC0C0 Offset: 0x21BA6C0 VA: 0x1821BC0C0
	public static LTDescr value(float from, float to, float time) { }

	// RVA: 0x21BBB60 Offset: 0x21BA160 VA: 0x1821BBB60
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time) { }

	// RVA: 0x21BC6C0 Offset: 0x21BACC0 VA: 0x1821BC6C0
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time) { }

	// RVA: 0x21BB9A0 Offset: 0x21B9FA0 VA: 0x1821BB9A0
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time) { }

	// RVA: 0x21BC220 Offset: 0x21BA820 VA: 0x1821BC220
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time) { }

	// RVA: 0x21BBF10 Offset: 0x21BA510 VA: 0x1821BBF10
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time) { }

	// RVA: 0x21BBCF0 Offset: 0x21BA2F0 VA: 0x1821BBCF0
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time) { }

	// RVA: 0x21BB480 Offset: 0x21B9A80 VA: 0x1821BB480
	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time) { }

	// RVA: 0x21BB800 Offset: 0x21B9E00 VA: 0x1821BB800
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time) { }

	// RVA: 0x21BC590 Offset: 0x21BAB90 VA: 0x1821BC590
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time) { }

	// RVA: 0x21BC3D0 Offset: 0x21BA9D0 VA: 0x1821BC3D0
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time) { }

	// RVA: 0x21B11E0 Offset: 0x21AF7E0 VA: 0x1821B11E0
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume) { }

	// RVA: 0x21B1340 Offset: 0x21AF940 VA: 0x1821B1340
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume) { }

	// RVA: 0x21B7070 Offset: 0x21B5670 VA: 0x1821B7070
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time) { }

	// RVA: 0x21B6230 Offset: 0x21B4830 VA: 0x1821B6230
	public static LTDescr moveX(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B6420 Offset: 0x21B4A20 VA: 0x1821B6420
	public static LTDescr moveY(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B66F0 Offset: 0x21B4CF0 VA: 0x1821B66F0
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B9AB0 Offset: 0x21B80B0 VA: 0x1821B9AB0
	public static LTDescr rotate(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B9DD0 Offset: 0x21B83D0 VA: 0x1821B9DD0
	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time) { }

	// RVA: 0x21B9500 Offset: 0x21B7B00 VA: 0x1821B9500
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time) { }

	// RVA: 0x21B92A0 Offset: 0x21B78A0 VA: 0x1821B92A0
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time) { }

	// RVA: 0x21BA370 Offset: 0x21B8970 VA: 0x1821BA370
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time) { }

	// RVA: 0x21BA7D0 Offset: 0x21B8DD0 VA: 0x1821BA7D0
	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time) { }

	// RVA: 0x21AF800 Offset: 0x21ADE00 VA: 0x1821AF800
	public static LTDescr alpha(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B0AD0 Offset: 0x21AF0D0 VA: 0x1821B0AD0
	public static LTDescr color(RectTransform rectTrans, Color to, float time) { }

	// RVA: 0x21BADD0 Offset: 0x21B93D0 VA: 0x1821BADD0
	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed) { }

	// RVA: 0x21BAC60 Offset: 0x21B9260 VA: 0x1821BAC60
	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed) { }

	// RVA: 0x21B3E00 Offset: 0x21B2400 VA: 0x1821B3E00
	public static float easeOutQuadOpt(float start, float diff, float ratioPassed) { }

	// RVA: 0x21B38D0 Offset: 0x21B1ED0 VA: 0x1821B38D0
	public static float easeInQuadOpt(float start, float diff, float ratioPassed) { }

	// RVA: 0x21B3670 Offset: 0x21B1C70 VA: 0x1821B3670
	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed) { }

	// RVA: 0x21B3460 Offset: 0x21B1A60 VA: 0x1821B3460
	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed) { }

	// RVA: 0x21B4D60 Offset: 0x21B3360 VA: 0x1821B4D60
	public static float linear(float start, float end, float val) { }

	// RVA: 0x21B07C0 Offset: 0x21AEDC0 VA: 0x1821B07C0
	public static float clerp(float start, float end, float val) { }

	// RVA: 0x21BA8F0 Offset: 0x21B8EF0 VA: 0x1821BA8F0
	public static float spring(float start, float end, float val) { }

	// RVA: 0x21B38E0 Offset: 0x21B1EE0 VA: 0x1821B38E0
	public static float easeInQuad(float start, float end, float val) { }

	// RVA: 0x21B3E20 Offset: 0x21B2420 VA: 0x1821B3E20
	public static float easeOutQuad(float start, float end, float val) { }

	// RVA: 0x21B36D0 Offset: 0x21B1CD0 VA: 0x1821B36D0
	public static float easeInOutQuad(float start, float end, float val) { }

	// RVA: 0x21B3420 Offset: 0x21B1A20 VA: 0x1821B3420
	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2) { }

	// RVA: 0x21B2B80 Offset: 0x21B1180 VA: 0x1821B2B80
	public static float easeInCubic(float start, float end, float val) { }

	// RVA: 0x21B3BD0 Offset: 0x21B21D0 VA: 0x1821B3BD0
	public static float easeOutCubic(float start, float end, float val) { }

	// RVA: 0x21B30B0 Offset: 0x21B16B0 VA: 0x1821B30B0
	public static float easeInOutCubic(float start, float end, float val) { }

	// RVA: 0x21B3900 Offset: 0x21B1F00 VA: 0x1821B3900
	public static float easeInQuart(float start, float end, float val) { }

	// RVA: 0x21B3E50 Offset: 0x21B2450 VA: 0x1821B3E50
	public static float easeOutQuart(float start, float end, float val) { }

	// RVA: 0x21B3740 Offset: 0x21B1D40 VA: 0x1821B3740
	public static float easeInOutQuart(float start, float end, float val) { }

	// RVA: 0x21B3920 Offset: 0x21B1F20 VA: 0x1821B3920
	public static float easeInQuint(float start, float end, float val) { }

	// RVA: 0x21B3E90 Offset: 0x21B2490 VA: 0x1821B3E90
	public static float easeOutQuint(float start, float end, float val) { }

	// RVA: 0x21B37B0 Offset: 0x21B1DB0 VA: 0x1821B37B0
	public static float easeInOutQuint(float start, float end, float val) { }

	// RVA: 0x21B3940 Offset: 0x21B1F40 VA: 0x1821B3940
	public static float easeInSine(float start, float end, float val) { }

	// RVA: 0x21B3ED0 Offset: 0x21B24D0 VA: 0x1821B3ED0
	public static float easeOutSine(float start, float end, float val) { }

	// RVA: 0x21B3820 Offset: 0x21B1E20 VA: 0x1821B3820
	public static float easeInOutSine(float start, float end, float val) { }

	// RVA: 0x21B2D00 Offset: 0x21B1300 VA: 0x1821B2D00
	public static float easeInExpo(float start, float end, float val) { }

	// RVA: 0x21B3D50 Offset: 0x21B2350 VA: 0x1821B3D50
	public static float easeOutExpo(float start, float end, float val) { }

	// RVA: 0x21B3310 Offset: 0x21B1910 VA: 0x1821B3310
	public static float easeInOutExpo(float start, float end, float val) { }

	// RVA: 0x21B2AD0 Offset: 0x21B10D0 VA: 0x1821B2AD0
	public static float easeInCirc(float start, float end, float val) { }

	// RVA: 0x21B3B30 Offset: 0x21B2130 VA: 0x1821B3B30
	public static float easeOutCirc(float start, float end, float val) { }

	// RVA: 0x21B2FB0 Offset: 0x21B15B0 VA: 0x1821B2FB0
	public static float easeInOutCirc(float start, float end, float val) { }

	// RVA: 0x21B2A30 Offset: 0x21B1030 VA: 0x1821B2A30
	public static float easeInBounce(float start, float end, float val) { }

	// RVA: 0x21B3A30 Offset: 0x21B2030 VA: 0x1821B3A30
	public static float easeOutBounce(float start, float end, float val) { }

	// RVA: 0x21B2E40 Offset: 0x21B1440 VA: 0x1821B2E40
	public static float easeInOutBounce(float start, float end, float val) { }

	// RVA: 0x21B29F0 Offset: 0x21B0FF0 VA: 0x1821B29F0
	public static float easeInBack(float start, float end, float val, float overshoot = 1) { }

	// RVA: 0x21B39E0 Offset: 0x21B1FE0 VA: 0x1821B39E0
	public static float easeOutBack(float start, float end, float val, float overshoot = 1) { }

	// RVA: 0x21B2DA0 Offset: 0x21B13A0 VA: 0x1821B2DA0
	public static float easeInOutBack(float start, float end, float val, float overshoot = 1) { }

	// RVA: 0x21B2BA0 Offset: 0x21B11A0 VA: 0x1821B2BA0
	public static float easeInElastic(float start, float end, float val, float overshoot = 1, float period = 0,3) { }

	// RVA: 0x21B3C00 Offset: 0x21B2200 VA: 0x1821B3C00
	public static float easeOutElastic(float start, float end, float val, float overshoot = 1, float period = 0,3) { }

	// RVA: 0x21B3110 Offset: 0x21B1710 VA: 0x1821B3110
	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1, float period = 0,3) { }

	// RVA: 0x21AF0A0 Offset: 0x21AD6A0 VA: 0x1821AF0A0
	public static void addListener(int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21AEB10 Offset: 0x21AD110 VA: 0x1821AEB10
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21B84A0 Offset: 0x21B6AA0 VA: 0x1821B84A0
	public static bool removeListener(int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21B8510 Offset: 0x21B6B10 VA: 0x1821B8510
	public static bool removeListener(int eventId) { }

	// RVA: 0x21B81D0 Offset: 0x21B67D0 VA: 0x1821B81D0
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21B1BF0 Offset: 0x21B01F0 VA: 0x1821B1BF0
	public static void dispatchEvent(int eventId) { }

	// RVA: 0x21B1C50 Offset: 0x21B0250 VA: 0x1821B1C50
	public static void dispatchEvent(int eventId, object data) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x21AE3B0 Offset: 0x21AC9B0 VA: 0x1821AE3B0
	private static void .cctor() { }

}

