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

	// RVA: 0x21B4910 Offset: 0x21B2F10 VA: 0x1821B4910
	public static void init() { }

	// RVA: 0x21B4220 Offset: 0x21B2820 VA: 0x1821B4220
	public static int get_maxSearch() { }

	// RVA: 0x21B4280 Offset: 0x21B2880 VA: 0x1821B4280
	public static int get_maxSimulataneousTweens() { }

	// RVA: 0x21B43A0 Offset: 0x21B29A0 VA: 0x1821B43A0
	public static int get_tweensRunning() { }

	// RVA: 0x21B49C0 Offset: 0x21B2FC0 VA: 0x1821B49C0
	public static void init(int maxSimultaneousTweens) { }

	// RVA: 0x21B4480 Offset: 0x21B2A80 VA: 0x1821B4480
	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences) { }

	// RVA: 0x21B8E70 Offset: 0x21B7470 VA: 0x1821B8E70
	public static void reset() { }

	// RVA: 0x21AE620 Offset: 0x21ACC20 VA: 0x1821AE620
	public void Update() { }

	// RVA: 0x21B7760 Offset: 0x21B5D60 VA: 0x1821B7760
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x21B4A30 Offset: 0x21B3030 VA: 0x1821B4A30
	private static void internalOnLevelWasLoaded(int lvl) { }

	// RVA: 0x21BB0F0 Offset: 0x21B96F0 VA: 0x1821BB0F0
	public static void update() { }

	// RVA: 0x21B88D0 Offset: 0x21B6ED0 VA: 0x1821B88D0
	public static void removeTween(int i, int uniqueId) { }

	// RVA: 0x21B89A0 Offset: 0x21B6FA0 VA: 0x1821B89A0
	public static void removeTween(int i) { }

	// RVA: 0x21AF3D0 Offset: 0x21AD9D0 VA: 0x1821AF3D0
	public static Vector3[] add(Vector3[] a, Vector3 b) { }

	// RVA: 0x21B0B50 Offset: 0x21AF150 VA: 0x1821B0B50
	public static float closestRot(float from, float to) { }

	// RVA: 0x21AFBD0 Offset: 0x21AE1D0 VA: 0x1821AFBD0
	public static void cancelAll() { }

	// RVA: 0x21AFC20 Offset: 0x21AE220 VA: 0x1821AFC20
	public static void cancelAll(bool callComplete) { }

	// RVA: 0x21B04D0 Offset: 0x21AEAD0 VA: 0x1821B04D0
	public static void cancel(GameObject gameObject) { }

	// RVA: 0x21AFE90 Offset: 0x21AE490 VA: 0x1821AFE90
	public static void cancel(GameObject gameObject, bool callOnComplete) { }

	// RVA: 0x21B0A10 Offset: 0x21AF010 VA: 0x1821B0A10
	public static void cancel(RectTransform rect) { }

	// RVA: 0x21B06D0 Offset: 0x21AECD0 VA: 0x1821B06D0
	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = False) { }

	// RVA: 0x21B0530 Offset: 0x21AEB30 VA: 0x1821B0530
	public static void cancel(LTRect ltRect, int uniqueId) { }

	// RVA: 0x21B0670 Offset: 0x21AEC70 VA: 0x1821B0670
	public static void cancel(int uniqueId) { }

	// RVA: 0x21B0190 Offset: 0x21AE790 VA: 0x1821B0190
	public static void cancel(int uniqueId, bool callOnComplete) { }

	// RVA: 0x21B1760 Offset: 0x21AFD60 VA: 0x1821B1760
	public static LTDescr descr(int uniqueId) { }

	// RVA: 0x21B1AB0 Offset: 0x21B00B0 VA: 0x1821B1AB0
	public static LTDescr description(int uniqueId) { }

	// RVA: 0x21B1B00 Offset: 0x21B0100 VA: 0x1821B1B00
	public static LTDescr[] descriptions(GameObject gameObject) { }

	[ObsoleteAttribute] // RVA: 0xB4B40 Offset: 0xB3F40 VA: 0x1800B4B40
	// RVA: 0x21B80B0 Offset: 0x21B66B0 VA: 0x1821B80B0
	public static void pause(GameObject gameObject, int uniqueId) { }

	// RVA: 0x21B7FA0 Offset: 0x21B65A0 VA: 0x1821B7FA0
	public static void pause(int uniqueId) { }

	// RVA: 0x21B7E00 Offset: 0x21B6400 VA: 0x1821B7E00
	public static void pause(GameObject gameObject) { }

	// RVA: 0x21B7D00 Offset: 0x21B6300 VA: 0x1821B7D00
	public static void pauseAll() { }

	// RVA: 0x21B9060 Offset: 0x21B7660 VA: 0x1821B9060
	public static void resumeAll() { }

	[ObsoleteAttribute] // RVA: 0xB4C10 Offset: 0xB4010 VA: 0x1800B4C10
	// RVA: 0x21B9410 Offset: 0x21B7A10 VA: 0x1821B9410
	public static void resume(GameObject gameObject, int uniqueId) { }

	// RVA: 0x21B9300 Offset: 0x21B7900 VA: 0x1821B9300
	public static void resume(int uniqueId) { }

	// RVA: 0x21B9160 Offset: 0x21B7760 VA: 0x1821B9160
	public static void resume(GameObject gameObject) { }

	// RVA: 0x21B4BE0 Offset: 0x21B31E0 VA: 0x1821B4BE0
	public static bool isTweening(GameObject gameObject) { }

	// RVA: 0x21B4E50 Offset: 0x21B3450 VA: 0x1821B4E50
	public static bool isTweening(RectTransform rect) { }

	// RVA: 0x21B4A80 Offset: 0x21B3080 VA: 0x1821B4A80
	public static bool isTweening(int uniqueId) { }

	// RVA: 0x21B4EC0 Offset: 0x21B34C0 VA: 0x1821B4EC0
	public static bool isTweening(LTRect ltRect) { }

	// RVA: 0x21B21C0 Offset: 0x21B07C0 VA: 0x1821B21C0
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0, Transform arrowTransform) { }

	// RVA: 0x21B50A0 Offset: 0x21B36A0 VA: 0x1821B50A0
	public static object logError(string error) { }

	// RVA: 0x21B7800 Offset: 0x21B5E00 VA: 0x1821B7800
	public static LTDescr options(LTDescr seed) { }

	// RVA: 0x21B7860 Offset: 0x21B5E60 VA: 0x1821B7860
	public static LTDescr options() { }

	// RVA: 0x21B42E0 Offset: 0x21B28E0 VA: 0x1821B42E0
	public static GameObject get_tweenEmpty() { }

	// RVA: 0x21B8330 Offset: 0x21B6930 VA: 0x1821B8330
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween) { }

	// RVA: 0x21B8200 Offset: 0x21B6800 VA: 0x1821B8200
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites) { }

	// RVA: 0x21AF9B0 Offset: 0x21ADFB0 VA: 0x1821AF9B0
	public static LTDescr alpha(GameObject gameObject, float to, float time) { }

	// RVA: 0x21BA710 Offset: 0x21B8D10 VA: 0x1821BA710
	public static LTSeq sequence(bool initSequence = True) { }

	// RVA: 0x21AF8A0 Offset: 0x21ADEA0 VA: 0x1821AF8A0
	public static LTDescr alpha(LTRect ltRect, float to, float time) { }

	// RVA: 0x21BACD0 Offset: 0x21B92D0 VA: 0x1821BACD0
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time) { }

	// RVA: 0x21AF6D0 Offset: 0x21ADCD0 VA: 0x1821AF6D0
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time) { }

	// RVA: 0x21AF5E0 Offset: 0x21ADBE0 VA: 0x1821AF5E0
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time) { }

	// RVA: 0x21AF7C0 Offset: 0x21ADDC0 VA: 0x1821AF7C0
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B0F00 Offset: 0x21AF500 VA: 0x1821B0F00
	public static LTDescr color(GameObject gameObject, Color to, float time) { }

	// RVA: 0x21BADC0 Offset: 0x21B93C0 VA: 0x1821BADC0
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time) { }

	// RVA: 0x21B0C30 Offset: 0x21AF230 VA: 0x1821B0C30
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time) { }

	// RVA: 0x21B1180 Offset: 0x21AF780 VA: 0x1821B1180
	public static LTDescr delayedCall(float delayTime, Action callback) { }

	// RVA: 0x21B1290 Offset: 0x21AF890 VA: 0x1821B1290
	public static LTDescr delayedCall(float delayTime, Action<object> callback) { }

	// RVA: 0x21B13A0 Offset: 0x21AF9A0 VA: 0x1821B13A0
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback) { }

	// RVA: 0x21B1080 Offset: 0x21AF680 VA: 0x1821B1080
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback) { }

	// RVA: 0x21B1D90 Offset: 0x21B0390 VA: 0x1821B1D90
	public static LTDescr destroyAfter(LTRect rect, float delayTime) { }

	// RVA: 0x21B6AC0 Offset: 0x21B50C0 VA: 0x1821B6AC0
	public static LTDescr move(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21B7100 Offset: 0x21B5700 VA: 0x1821B7100
	public static LTDescr move(GameObject gameObject, Vector2 to, float time) { }

	// RVA: 0x21B6B70 Offset: 0x21B5170 VA: 0x1821B6B70
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B6EB0 Offset: 0x21B54B0 VA: 0x1821B6EB0
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time) { }

	// RVA: 0x21B7410 Offset: 0x21B5A10 VA: 0x1821B7410
	public static LTDescr move(GameObject gameObject, LTSpline to, float time) { }

	// RVA: 0x21B6270 Offset: 0x21B4870 VA: 0x1821B6270
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B6020 Offset: 0x21B4620 VA: 0x1821B6020
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time) { }

	// RVA: 0x21B5DA0 Offset: 0x21B43A0 VA: 0x1821B5DA0
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B7220 Offset: 0x21B5820 VA: 0x1821B7220
	public static LTDescr move(LTRect ltRect, Vector2 to, float time) { }

	// RVA: 0x21B5C90 Offset: 0x21B4290 VA: 0x1821B5C90
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time) { }

	// RVA: 0x21B6600 Offset: 0x21B4C00 VA: 0x1821B6600
	public static LTDescr moveX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B67F0 Offset: 0x21B4DF0 VA: 0x1821B67F0
	public static LTDescr moveY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B68D0 Offset: 0x21B4ED0 VA: 0x1821B68D0
	public static LTDescr moveZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B5740 Offset: 0x21B3D40 VA: 0x1821B5740
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21B5400 Offset: 0x21B3A00 VA: 0x1821B5400
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B5160 Offset: 0x21B3760 VA: 0x1821B5160
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B5240 Offset: 0x21B3840 VA: 0x1821B5240
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B5320 Offset: 0x21B3920 VA: 0x1821B5320
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B57F0 Offset: 0x21B3DF0 VA: 0x1821B57F0
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time) { }

	// RVA: 0x21B5A40 Offset: 0x21B4040 VA: 0x1821B5A40
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time) { }

	// RVA: 0x21B7660 Offset: 0x21B5C60 VA: 0x1821B7660
	public static LTDescr move(GameObject gameObject, Transform to, float time) { }

	// RVA: 0x21B9FE0 Offset: 0x21B85E0 VA: 0x1821B9FE0
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21B9EE0 Offset: 0x21B84E0 VA: 0x1821B9EE0
	public static LTDescr rotate(LTRect ltRect, float to, float time) { }

	// RVA: 0x21B9A20 Offset: 0x21B8020 VA: 0x1821B9A20
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21B9AD0 Offset: 0x21B80D0 VA: 0x1821B9AD0
	public static LTDescr rotateX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B9BB0 Offset: 0x21B81B0 VA: 0x1821B9BB0
	public static LTDescr rotateY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B9C90 Offset: 0x21B8290 VA: 0x1821B9C90
	public static LTDescr rotateZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B9910 Offset: 0x21B7F10 VA: 0x1821B9910
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time) { }

	// RVA: 0x21B96B0 Offset: 0x21B7CB0 VA: 0x1821B96B0
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time) { }

	// RVA: 0x21BA580 Offset: 0x21B8B80 VA: 0x1821BA580
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21BA470 Offset: 0x21B8A70 VA: 0x1821BA470
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time) { }

	// RVA: 0x21BA1D0 Offset: 0x21B87D0 VA: 0x1821BA1D0
	public static LTDescr scaleX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21BA2B0 Offset: 0x21B88B0 VA: 0x1821BA2B0
	public static LTDescr scaleY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21BA390 Offset: 0x21B8990 VA: 0x1821BA390
	public static LTDescr scaleZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21BB960 Offset: 0x21B9F60 VA: 0x1821BB960
	public static LTDescr value(GameObject gameObject, float from, float to, float time) { }

	// RVA: 0x21BC380 Offset: 0x21BA980 VA: 0x1821BC380
	public static LTDescr value(float from, float to, float time) { }

	// RVA: 0x21BBE20 Offset: 0x21BA420 VA: 0x1821BBE20
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time) { }

	// RVA: 0x21BC980 Offset: 0x21BAF80 VA: 0x1821BC980
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time) { }

	// RVA: 0x21BBC60 Offset: 0x21BA260 VA: 0x1821BBC60
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time) { }

	// RVA: 0x21BC4E0 Offset: 0x21BAAE0 VA: 0x1821BC4E0
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time) { }

	// RVA: 0x21BC1D0 Offset: 0x21BA7D0 VA: 0x1821BC1D0
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time) { }

	// RVA: 0x21BBFB0 Offset: 0x21BA5B0 VA: 0x1821BBFB0
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time) { }

	// RVA: 0x21BB740 Offset: 0x21B9D40 VA: 0x1821BB740
	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time) { }

	// RVA: 0x21BBAC0 Offset: 0x21BA0C0 VA: 0x1821BBAC0
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time) { }

	// RVA: 0x21BC850 Offset: 0x21BAE50 VA: 0x1821BC850
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time) { }

	// RVA: 0x21BC690 Offset: 0x21BAC90 VA: 0x1821BC690
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time) { }

	// RVA: 0x21B14A0 Offset: 0x21AFAA0 VA: 0x1821B14A0
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume) { }

	// RVA: 0x21B1600 Offset: 0x21AFC00 VA: 0x1821B1600
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume) { }

	// RVA: 0x21B7330 Offset: 0x21B5930 VA: 0x1821B7330
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time) { }

	// RVA: 0x21B64F0 Offset: 0x21B4AF0 VA: 0x1821B64F0
	public static LTDescr moveX(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B66E0 Offset: 0x21B4CE0 VA: 0x1821B66E0
	public static LTDescr moveY(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B69B0 Offset: 0x21B4FB0 VA: 0x1821B69B0
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B9D70 Offset: 0x21B8370 VA: 0x1821B9D70
	public static LTDescr rotate(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21BA090 Offset: 0x21B8690 VA: 0x1821BA090
	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time) { }

	// RVA: 0x21B97C0 Offset: 0x21B7DC0 VA: 0x1821B97C0
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time) { }

	// RVA: 0x21B9560 Offset: 0x21B7B60 VA: 0x1821B9560
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time) { }

	// RVA: 0x21BA630 Offset: 0x21B8C30 VA: 0x1821BA630
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time) { }

	// RVA: 0x21BAA90 Offset: 0x21B9090 VA: 0x1821BAA90
	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time) { }

	// RVA: 0x21AFAC0 Offset: 0x21AE0C0 VA: 0x1821AFAC0
	public static LTDescr alpha(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B0D90 Offset: 0x21AF390 VA: 0x1821B0D90
	public static LTDescr color(RectTransform rectTrans, Color to, float time) { }

	// RVA: 0x21BB090 Offset: 0x21B9690 VA: 0x1821BB090
	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed) { }

	// RVA: 0x21BAF20 Offset: 0x21B9520 VA: 0x1821BAF20
	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed) { }

	// RVA: 0x21B40C0 Offset: 0x21B26C0 VA: 0x1821B40C0
	public static float easeOutQuadOpt(float start, float diff, float ratioPassed) { }

	// RVA: 0x21B3B90 Offset: 0x21B2190 VA: 0x1821B3B90
	public static float easeInQuadOpt(float start, float diff, float ratioPassed) { }

	// RVA: 0x21B3930 Offset: 0x21B1F30 VA: 0x1821B3930
	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed) { }

	// RVA: 0x21B3720 Offset: 0x21B1D20 VA: 0x1821B3720
	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed) { }

	// RVA: 0x21B5020 Offset: 0x21B3620 VA: 0x1821B5020
	public static float linear(float start, float end, float val) { }

	// RVA: 0x21B0A80 Offset: 0x21AF080 VA: 0x1821B0A80
	public static float clerp(float start, float end, float val) { }

	// RVA: 0x21BABB0 Offset: 0x21B91B0 VA: 0x1821BABB0
	public static float spring(float start, float end, float val) { }

	// RVA: 0x21B3BA0 Offset: 0x21B21A0 VA: 0x1821B3BA0
	public static float easeInQuad(float start, float end, float val) { }

	// RVA: 0x21B40E0 Offset: 0x21B26E0 VA: 0x1821B40E0
	public static float easeOutQuad(float start, float end, float val) { }

	// RVA: 0x21B3990 Offset: 0x21B1F90 VA: 0x1821B3990
	public static float easeInOutQuad(float start, float end, float val) { }

	// RVA: 0x21B36E0 Offset: 0x21B1CE0 VA: 0x1821B36E0
	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2) { }

	// RVA: 0x21B2E40 Offset: 0x21B1440 VA: 0x1821B2E40
	public static float easeInCubic(float start, float end, float val) { }

	// RVA: 0x21B3E90 Offset: 0x21B2490 VA: 0x1821B3E90
	public static float easeOutCubic(float start, float end, float val) { }

	// RVA: 0x21B3370 Offset: 0x21B1970 VA: 0x1821B3370
	public static float easeInOutCubic(float start, float end, float val) { }

	// RVA: 0x21B3BC0 Offset: 0x21B21C0 VA: 0x1821B3BC0
	public static float easeInQuart(float start, float end, float val) { }

	// RVA: 0x21B4110 Offset: 0x21B2710 VA: 0x1821B4110
	public static float easeOutQuart(float start, float end, float val) { }

	// RVA: 0x21B3A00 Offset: 0x21B2000 VA: 0x1821B3A00
	public static float easeInOutQuart(float start, float end, float val) { }

	// RVA: 0x21B3BE0 Offset: 0x21B21E0 VA: 0x1821B3BE0
	public static float easeInQuint(float start, float end, float val) { }

	// RVA: 0x21B4150 Offset: 0x21B2750 VA: 0x1821B4150
	public static float easeOutQuint(float start, float end, float val) { }

	// RVA: 0x21B3A70 Offset: 0x21B2070 VA: 0x1821B3A70
	public static float easeInOutQuint(float start, float end, float val) { }

	// RVA: 0x21B3C00 Offset: 0x21B2200 VA: 0x1821B3C00
	public static float easeInSine(float start, float end, float val) { }

	// RVA: 0x21B4190 Offset: 0x21B2790 VA: 0x1821B4190
	public static float easeOutSine(float start, float end, float val) { }

	// RVA: 0x21B3AE0 Offset: 0x21B20E0 VA: 0x1821B3AE0
	public static float easeInOutSine(float start, float end, float val) { }

	// RVA: 0x21B2FC0 Offset: 0x21B15C0 VA: 0x1821B2FC0
	public static float easeInExpo(float start, float end, float val) { }

	// RVA: 0x21B4010 Offset: 0x21B2610 VA: 0x1821B4010
	public static float easeOutExpo(float start, float end, float val) { }

	// RVA: 0x21B35D0 Offset: 0x21B1BD0 VA: 0x1821B35D0
	public static float easeInOutExpo(float start, float end, float val) { }

	// RVA: 0x21B2D90 Offset: 0x21B1390 VA: 0x1821B2D90
	public static float easeInCirc(float start, float end, float val) { }

	// RVA: 0x21B3DF0 Offset: 0x21B23F0 VA: 0x1821B3DF0
	public static float easeOutCirc(float start, float end, float val) { }

	// RVA: 0x21B3270 Offset: 0x21B1870 VA: 0x1821B3270
	public static float easeInOutCirc(float start, float end, float val) { }

	// RVA: 0x21B2CF0 Offset: 0x21B12F0 VA: 0x1821B2CF0
	public static float easeInBounce(float start, float end, float val) { }

	// RVA: 0x21B3CF0 Offset: 0x21B22F0 VA: 0x1821B3CF0
	public static float easeOutBounce(float start, float end, float val) { }

	// RVA: 0x21B3100 Offset: 0x21B1700 VA: 0x1821B3100
	public static float easeInOutBounce(float start, float end, float val) { }

	// RVA: 0x21B2CB0 Offset: 0x21B12B0 VA: 0x1821B2CB0
	public static float easeInBack(float start, float end, float val, float overshoot = 1) { }

	// RVA: 0x21B3CA0 Offset: 0x21B22A0 VA: 0x1821B3CA0
	public static float easeOutBack(float start, float end, float val, float overshoot = 1) { }

	// RVA: 0x21B3060 Offset: 0x21B1660 VA: 0x1821B3060
	public static float easeInOutBack(float start, float end, float val, float overshoot = 1) { }

	// RVA: 0x21B2E60 Offset: 0x21B1460 VA: 0x1821B2E60
	public static float easeInElastic(float start, float end, float val, float overshoot = 1, float period = 0,3) { }

	// RVA: 0x21B3EC0 Offset: 0x21B24C0 VA: 0x1821B3EC0
	public static float easeOutElastic(float start, float end, float val, float overshoot = 1, float period = 0,3) { }

	// RVA: 0x21B33D0 Offset: 0x21B19D0 VA: 0x1821B33D0
	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1, float period = 0,3) { }

	// RVA: 0x21AF360 Offset: 0x21AD960 VA: 0x1821AF360
	public static void addListener(int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21AEDD0 Offset: 0x21AD3D0 VA: 0x1821AEDD0
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21B8760 Offset: 0x21B6D60 VA: 0x1821B8760
	public static bool removeListener(int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21B87D0 Offset: 0x21B6DD0 VA: 0x1821B87D0
	public static bool removeListener(int eventId) { }

	// RVA: 0x21B8490 Offset: 0x21B6A90 VA: 0x1821B8490
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21B1EB0 Offset: 0x21B04B0 VA: 0x1821B1EB0
	public static void dispatchEvent(int eventId) { }

	// RVA: 0x21B1F10 Offset: 0x21B0510 VA: 0x1821B1F10
	public static void dispatchEvent(int eventId, object data) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x21AE670 Offset: 0x21ACC70 VA: 0x1821AE670
	private static void .cctor() { }

}

