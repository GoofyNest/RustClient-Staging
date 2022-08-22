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

	// RVA: 0x21B5130 Offset: 0x21B3730 VA: 0x1821B5130
	public static void init() { }

	// RVA: 0x21B4A40 Offset: 0x21B3040 VA: 0x1821B4A40
	public static int get_maxSearch() { }

	// RVA: 0x21B4AA0 Offset: 0x21B30A0 VA: 0x1821B4AA0
	public static int get_maxSimulataneousTweens() { }

	// RVA: 0x21B4BC0 Offset: 0x21B31C0 VA: 0x1821B4BC0
	public static int get_tweensRunning() { }

	// RVA: 0x21B51E0 Offset: 0x21B37E0 VA: 0x1821B51E0
	public static void init(int maxSimultaneousTweens) { }

	// RVA: 0x21B4CA0 Offset: 0x21B32A0 VA: 0x1821B4CA0
	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences) { }

	// RVA: 0x21B9690 Offset: 0x21B7C90 VA: 0x1821B9690
	public static void reset() { }

	// RVA: 0x21AEE40 Offset: 0x21AD440 VA: 0x1821AEE40
	public void Update() { }

	// RVA: 0x21B7F80 Offset: 0x21B6580 VA: 0x1821B7F80
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x21B5250 Offset: 0x21B3850 VA: 0x1821B5250
	private static void internalOnLevelWasLoaded(int lvl) { }

	// RVA: 0x21BB910 Offset: 0x21B9F10 VA: 0x1821BB910
	public static void update() { }

	// RVA: 0x21B90F0 Offset: 0x21B76F0 VA: 0x1821B90F0
	public static void removeTween(int i, int uniqueId) { }

	// RVA: 0x21B91C0 Offset: 0x21B77C0 VA: 0x1821B91C0
	public static void removeTween(int i) { }

	// RVA: 0x21AFBF0 Offset: 0x21AE1F0 VA: 0x1821AFBF0
	public static Vector3[] add(Vector3[] a, Vector3 b) { }

	// RVA: 0x21B1370 Offset: 0x21AF970 VA: 0x1821B1370
	public static float closestRot(float from, float to) { }

	// RVA: 0x21B03F0 Offset: 0x21AE9F0 VA: 0x1821B03F0
	public static void cancelAll() { }

	// RVA: 0x21B0440 Offset: 0x21AEA40 VA: 0x1821B0440
	public static void cancelAll(bool callComplete) { }

	// RVA: 0x21B0CF0 Offset: 0x21AF2F0 VA: 0x1821B0CF0
	public static void cancel(GameObject gameObject) { }

	// RVA: 0x21B06B0 Offset: 0x21AECB0 VA: 0x1821B06B0
	public static void cancel(GameObject gameObject, bool callOnComplete) { }

	// RVA: 0x21B1230 Offset: 0x21AF830 VA: 0x1821B1230
	public static void cancel(RectTransform rect) { }

	// RVA: 0x21B0EF0 Offset: 0x21AF4F0 VA: 0x1821B0EF0
	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = False) { }

	// RVA: 0x21B0D50 Offset: 0x21AF350 VA: 0x1821B0D50
	public static void cancel(LTRect ltRect, int uniqueId) { }

	// RVA: 0x21B0E90 Offset: 0x21AF490 VA: 0x1821B0E90
	public static void cancel(int uniqueId) { }

	// RVA: 0x21B09B0 Offset: 0x21AEFB0 VA: 0x1821B09B0
	public static void cancel(int uniqueId, bool callOnComplete) { }

	// RVA: 0x21B1F80 Offset: 0x21B0580 VA: 0x1821B1F80
	public static LTDescr descr(int uniqueId) { }

	// RVA: 0x21B22D0 Offset: 0x21B08D0 VA: 0x1821B22D0
	public static LTDescr description(int uniqueId) { }

	// RVA: 0x21B2320 Offset: 0x21B0920 VA: 0x1821B2320
	public static LTDescr[] descriptions(GameObject gameObject) { }

	[ObsoleteAttribute] // RVA: 0xB4B40 Offset: 0xB3F40 VA: 0x1800B4B40
	// RVA: 0x21B88D0 Offset: 0x21B6ED0 VA: 0x1821B88D0
	public static void pause(GameObject gameObject, int uniqueId) { }

	// RVA: 0x21B87C0 Offset: 0x21B6DC0 VA: 0x1821B87C0
	public static void pause(int uniqueId) { }

	// RVA: 0x21B8620 Offset: 0x21B6C20 VA: 0x1821B8620
	public static void pause(GameObject gameObject) { }

	// RVA: 0x21B8520 Offset: 0x21B6B20 VA: 0x1821B8520
	public static void pauseAll() { }

	// RVA: 0x21B9880 Offset: 0x21B7E80 VA: 0x1821B9880
	public static void resumeAll() { }

	[ObsoleteAttribute] // RVA: 0xB4C10 Offset: 0xB4010 VA: 0x1800B4C10
	// RVA: 0x21B9C30 Offset: 0x21B8230 VA: 0x1821B9C30
	public static void resume(GameObject gameObject, int uniqueId) { }

	// RVA: 0x21B9B20 Offset: 0x21B8120 VA: 0x1821B9B20
	public static void resume(int uniqueId) { }

	// RVA: 0x21B9980 Offset: 0x21B7F80 VA: 0x1821B9980
	public static void resume(GameObject gameObject) { }

	// RVA: 0x21B5400 Offset: 0x21B3A00 VA: 0x1821B5400
	public static bool isTweening(GameObject gameObject) { }

	// RVA: 0x21B5670 Offset: 0x21B3C70 VA: 0x1821B5670
	public static bool isTweening(RectTransform rect) { }

	// RVA: 0x21B52A0 Offset: 0x21B38A0 VA: 0x1821B52A0
	public static bool isTweening(int uniqueId) { }

	// RVA: 0x21B56E0 Offset: 0x21B3CE0 VA: 0x1821B56E0
	public static bool isTweening(LTRect ltRect) { }

	// RVA: 0x21B29E0 Offset: 0x21B0FE0 VA: 0x1821B29E0
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0, Transform arrowTransform) { }

	// RVA: 0x21B58C0 Offset: 0x21B3EC0 VA: 0x1821B58C0
	public static object logError(string error) { }

	// RVA: 0x21B8020 Offset: 0x21B6620 VA: 0x1821B8020
	public static LTDescr options(LTDescr seed) { }

	// RVA: 0x21B8080 Offset: 0x21B6680 VA: 0x1821B8080
	public static LTDescr options() { }

	// RVA: 0x21B4B00 Offset: 0x21B3100 VA: 0x1821B4B00
	public static GameObject get_tweenEmpty() { }

	// RVA: 0x21B8B50 Offset: 0x21B7150 VA: 0x1821B8B50
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween) { }

	// RVA: 0x21B8A20 Offset: 0x21B7020 VA: 0x1821B8A20
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites) { }

	// RVA: 0x21B01D0 Offset: 0x21AE7D0 VA: 0x1821B01D0
	public static LTDescr alpha(GameObject gameObject, float to, float time) { }

	// RVA: 0x21BAF30 Offset: 0x21B9530 VA: 0x1821BAF30
	public static LTSeq sequence(bool initSequence = True) { }

	// RVA: 0x21B00C0 Offset: 0x21AE6C0 VA: 0x1821B00C0
	public static LTDescr alpha(LTRect ltRect, float to, float time) { }

	// RVA: 0x21BB4F0 Offset: 0x21B9AF0 VA: 0x1821BB4F0
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time) { }

	// RVA: 0x21AFEF0 Offset: 0x21AE4F0 VA: 0x1821AFEF0
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time) { }

	// RVA: 0x21AFE00 Offset: 0x21AE400 VA: 0x1821AFE00
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time) { }

	// RVA: 0x21AFFE0 Offset: 0x21AE5E0 VA: 0x1821AFFE0
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B1720 Offset: 0x21AFD20 VA: 0x1821B1720
	public static LTDescr color(GameObject gameObject, Color to, float time) { }

	// RVA: 0x21BB5E0 Offset: 0x21B9BE0 VA: 0x1821BB5E0
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time) { }

	// RVA: 0x21B1450 Offset: 0x21AFA50 VA: 0x1821B1450
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time) { }

	// RVA: 0x21B19A0 Offset: 0x21AFFA0 VA: 0x1821B19A0
	public static LTDescr delayedCall(float delayTime, Action callback) { }

	// RVA: 0x21B1AB0 Offset: 0x21B00B0 VA: 0x1821B1AB0
	public static LTDescr delayedCall(float delayTime, Action<object> callback) { }

	// RVA: 0x21B1BC0 Offset: 0x21B01C0 VA: 0x1821B1BC0
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback) { }

	// RVA: 0x21B18A0 Offset: 0x21AFEA0 VA: 0x1821B18A0
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback) { }

	// RVA: 0x21B25B0 Offset: 0x21B0BB0 VA: 0x1821B25B0
	public static LTDescr destroyAfter(LTRect rect, float delayTime) { }

	// RVA: 0x21B72E0 Offset: 0x21B58E0 VA: 0x1821B72E0
	public static LTDescr move(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21B7920 Offset: 0x21B5F20 VA: 0x1821B7920
	public static LTDescr move(GameObject gameObject, Vector2 to, float time) { }

	// RVA: 0x21B7390 Offset: 0x21B5990 VA: 0x1821B7390
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B76D0 Offset: 0x21B5CD0 VA: 0x1821B76D0
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time) { }

	// RVA: 0x21B7C30 Offset: 0x21B6230 VA: 0x1821B7C30
	public static LTDescr move(GameObject gameObject, LTSpline to, float time) { }

	// RVA: 0x21B6A90 Offset: 0x21B5090 VA: 0x1821B6A90
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B6840 Offset: 0x21B4E40 VA: 0x1821B6840
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time) { }

	// RVA: 0x21B65C0 Offset: 0x21B4BC0 VA: 0x1821B65C0
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B7A40 Offset: 0x21B6040 VA: 0x1821B7A40
	public static LTDescr move(LTRect ltRect, Vector2 to, float time) { }

	// RVA: 0x21B64B0 Offset: 0x21B4AB0 VA: 0x1821B64B0
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time) { }

	// RVA: 0x21B6E20 Offset: 0x21B5420 VA: 0x1821B6E20
	public static LTDescr moveX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B7010 Offset: 0x21B5610 VA: 0x1821B7010
	public static LTDescr moveY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B70F0 Offset: 0x21B56F0 VA: 0x1821B70F0
	public static LTDescr moveZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B5F60 Offset: 0x21B4560 VA: 0x1821B5F60
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21B5C20 Offset: 0x21B4220 VA: 0x1821B5C20
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time) { }

	// RVA: 0x21B5980 Offset: 0x21B3F80 VA: 0x1821B5980
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B5A60 Offset: 0x21B4060 VA: 0x1821B5A60
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B5B40 Offset: 0x21B4140 VA: 0x1821B5B40
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21B6010 Offset: 0x21B4610 VA: 0x1821B6010
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time) { }

	// RVA: 0x21B6260 Offset: 0x21B4860 VA: 0x1821B6260
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time) { }

	// RVA: 0x21B7E80 Offset: 0x21B6480 VA: 0x1821B7E80
	public static LTDescr move(GameObject gameObject, Transform to, float time) { }

	// RVA: 0x21BA800 Offset: 0x21B8E00 VA: 0x1821BA800
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21BA700 Offset: 0x21B8D00 VA: 0x1821BA700
	public static LTDescr rotate(LTRect ltRect, float to, float time) { }

	// RVA: 0x21BA240 Offset: 0x21B8840 VA: 0x1821BA240
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21BA2F0 Offset: 0x21B88F0 VA: 0x1821BA2F0
	public static LTDescr rotateX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21BA3D0 Offset: 0x21B89D0 VA: 0x1821BA3D0
	public static LTDescr rotateY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21BA4B0 Offset: 0x21B8AB0 VA: 0x1821BA4B0
	public static LTDescr rotateZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21BA130 Offset: 0x21B8730 VA: 0x1821BA130
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time) { }

	// RVA: 0x21B9ED0 Offset: 0x21B84D0 VA: 0x1821B9ED0
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time) { }

	// RVA: 0x21BADA0 Offset: 0x21B93A0 VA: 0x1821BADA0
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time) { }

	// RVA: 0x21BAC90 Offset: 0x21B9290 VA: 0x1821BAC90
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time) { }

	// RVA: 0x21BA9F0 Offset: 0x21B8FF0 VA: 0x1821BA9F0
	public static LTDescr scaleX(GameObject gameObject, float to, float time) { }

	// RVA: 0x21BAAD0 Offset: 0x21B90D0 VA: 0x1821BAAD0
	public static LTDescr scaleY(GameObject gameObject, float to, float time) { }

	// RVA: 0x21BABB0 Offset: 0x21B91B0 VA: 0x1821BABB0
	public static LTDescr scaleZ(GameObject gameObject, float to, float time) { }

	// RVA: 0x21BC180 Offset: 0x21BA780 VA: 0x1821BC180
	public static LTDescr value(GameObject gameObject, float from, float to, float time) { }

	// RVA: 0x21BCBA0 Offset: 0x21BB1A0 VA: 0x1821BCBA0
	public static LTDescr value(float from, float to, float time) { }

	// RVA: 0x21BC640 Offset: 0x21BAC40 VA: 0x1821BC640
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time) { }

	// RVA: 0x21BD1A0 Offset: 0x21BB7A0 VA: 0x1821BD1A0
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time) { }

	// RVA: 0x21BC480 Offset: 0x21BAA80 VA: 0x1821BC480
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time) { }

	// RVA: 0x21BCD00 Offset: 0x21BB300 VA: 0x1821BCD00
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time) { }

	// RVA: 0x21BC9F0 Offset: 0x21BAFF0 VA: 0x1821BC9F0
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time) { }

	// RVA: 0x21BC7D0 Offset: 0x21BADD0 VA: 0x1821BC7D0
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time) { }

	// RVA: 0x21BBF60 Offset: 0x21BA560 VA: 0x1821BBF60
	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time) { }

	// RVA: 0x21BC2E0 Offset: 0x21BA8E0 VA: 0x1821BC2E0
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time) { }

	// RVA: 0x21BD070 Offset: 0x21BB670 VA: 0x1821BD070
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time) { }

	// RVA: 0x21BCEB0 Offset: 0x21BB4B0 VA: 0x1821BCEB0
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time) { }

	// RVA: 0x21B1CC0 Offset: 0x21B02C0 VA: 0x1821B1CC0
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume) { }

	// RVA: 0x21B1E20 Offset: 0x21B0420 VA: 0x1821B1E20
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume) { }

	// RVA: 0x21B7B50 Offset: 0x21B6150 VA: 0x1821B7B50
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time) { }

	// RVA: 0x21B6D10 Offset: 0x21B5310 VA: 0x1821B6D10
	public static LTDescr moveX(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B6F00 Offset: 0x21B5500 VA: 0x1821B6F00
	public static LTDescr moveY(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B71D0 Offset: 0x21B57D0 VA: 0x1821B71D0
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21BA590 Offset: 0x21B8B90 VA: 0x1821BA590
	public static LTDescr rotate(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21BA8B0 Offset: 0x21B8EB0 VA: 0x1821BA8B0
	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time) { }

	// RVA: 0x21B9FE0 Offset: 0x21B85E0 VA: 0x1821B9FE0
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time) { }

	// RVA: 0x21B9D80 Offset: 0x21B8380 VA: 0x1821B9D80
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time) { }

	// RVA: 0x21BAE50 Offset: 0x21B9450 VA: 0x1821BAE50
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time) { }

	// RVA: 0x21BB2B0 Offset: 0x21B98B0 VA: 0x1821BB2B0
	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time) { }

	// RVA: 0x21B02E0 Offset: 0x21AE8E0 VA: 0x1821B02E0
	public static LTDescr alpha(RectTransform rectTrans, float to, float time) { }

	// RVA: 0x21B15B0 Offset: 0x21AFBB0 VA: 0x1821B15B0
	public static LTDescr color(RectTransform rectTrans, Color to, float time) { }

	// RVA: 0x21BB8B0 Offset: 0x21B9EB0 VA: 0x1821BB8B0
	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed) { }

	// RVA: 0x21BB740 Offset: 0x21B9D40 VA: 0x1821BB740
	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed) { }

	// RVA: 0x21B48E0 Offset: 0x21B2EE0 VA: 0x1821B48E0
	public static float easeOutQuadOpt(float start, float diff, float ratioPassed) { }

	// RVA: 0x21B43B0 Offset: 0x21B29B0 VA: 0x1821B43B0
	public static float easeInQuadOpt(float start, float diff, float ratioPassed) { }

	// RVA: 0x21B4150 Offset: 0x21B2750 VA: 0x1821B4150
	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed) { }

	// RVA: 0x21B3F40 Offset: 0x21B2540 VA: 0x1821B3F40
	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed) { }

	// RVA: 0x21B5840 Offset: 0x21B3E40 VA: 0x1821B5840
	public static float linear(float start, float end, float val) { }

	// RVA: 0x21B12A0 Offset: 0x21AF8A0 VA: 0x1821B12A0
	public static float clerp(float start, float end, float val) { }

	// RVA: 0x21BB3D0 Offset: 0x21B99D0 VA: 0x1821BB3D0
	public static float spring(float start, float end, float val) { }

	// RVA: 0x21B43C0 Offset: 0x21B29C0 VA: 0x1821B43C0
	public static float easeInQuad(float start, float end, float val) { }

	// RVA: 0x21B4900 Offset: 0x21B2F00 VA: 0x1821B4900
	public static float easeOutQuad(float start, float end, float val) { }

	// RVA: 0x21B41B0 Offset: 0x21B27B0 VA: 0x1821B41B0
	public static float easeInOutQuad(float start, float end, float val) { }

	// RVA: 0x21B3F00 Offset: 0x21B2500 VA: 0x1821B3F00
	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2) { }

	// RVA: 0x21B3660 Offset: 0x21B1C60 VA: 0x1821B3660
	public static float easeInCubic(float start, float end, float val) { }

	// RVA: 0x21B46B0 Offset: 0x21B2CB0 VA: 0x1821B46B0
	public static float easeOutCubic(float start, float end, float val) { }

	// RVA: 0x21B3B90 Offset: 0x21B2190 VA: 0x1821B3B90
	public static float easeInOutCubic(float start, float end, float val) { }

	// RVA: 0x21B43E0 Offset: 0x21B29E0 VA: 0x1821B43E0
	public static float easeInQuart(float start, float end, float val) { }

	// RVA: 0x21B4930 Offset: 0x21B2F30 VA: 0x1821B4930
	public static float easeOutQuart(float start, float end, float val) { }

	// RVA: 0x21B4220 Offset: 0x21B2820 VA: 0x1821B4220
	public static float easeInOutQuart(float start, float end, float val) { }

	// RVA: 0x21B4400 Offset: 0x21B2A00 VA: 0x1821B4400
	public static float easeInQuint(float start, float end, float val) { }

	// RVA: 0x21B4970 Offset: 0x21B2F70 VA: 0x1821B4970
	public static float easeOutQuint(float start, float end, float val) { }

	// RVA: 0x21B4290 Offset: 0x21B2890 VA: 0x1821B4290
	public static float easeInOutQuint(float start, float end, float val) { }

	// RVA: 0x21B4420 Offset: 0x21B2A20 VA: 0x1821B4420
	public static float easeInSine(float start, float end, float val) { }

	// RVA: 0x21B49B0 Offset: 0x21B2FB0 VA: 0x1821B49B0
	public static float easeOutSine(float start, float end, float val) { }

	// RVA: 0x21B4300 Offset: 0x21B2900 VA: 0x1821B4300
	public static float easeInOutSine(float start, float end, float val) { }

	// RVA: 0x21B37E0 Offset: 0x21B1DE0 VA: 0x1821B37E0
	public static float easeInExpo(float start, float end, float val) { }

	// RVA: 0x21B4830 Offset: 0x21B2E30 VA: 0x1821B4830
	public static float easeOutExpo(float start, float end, float val) { }

	// RVA: 0x21B3DF0 Offset: 0x21B23F0 VA: 0x1821B3DF0
	public static float easeInOutExpo(float start, float end, float val) { }

	// RVA: 0x21B35B0 Offset: 0x21B1BB0 VA: 0x1821B35B0
	public static float easeInCirc(float start, float end, float val) { }

	// RVA: 0x21B4610 Offset: 0x21B2C10 VA: 0x1821B4610
	public static float easeOutCirc(float start, float end, float val) { }

	// RVA: 0x21B3A90 Offset: 0x21B2090 VA: 0x1821B3A90
	public static float easeInOutCirc(float start, float end, float val) { }

	// RVA: 0x21B3510 Offset: 0x21B1B10 VA: 0x1821B3510
	public static float easeInBounce(float start, float end, float val) { }

	// RVA: 0x21B4510 Offset: 0x21B2B10 VA: 0x1821B4510
	public static float easeOutBounce(float start, float end, float val) { }

	// RVA: 0x21B3920 Offset: 0x21B1F20 VA: 0x1821B3920
	public static float easeInOutBounce(float start, float end, float val) { }

	// RVA: 0x21B34D0 Offset: 0x21B1AD0 VA: 0x1821B34D0
	public static float easeInBack(float start, float end, float val, float overshoot = 1) { }

	// RVA: 0x21B44C0 Offset: 0x21B2AC0 VA: 0x1821B44C0
	public static float easeOutBack(float start, float end, float val, float overshoot = 1) { }

	// RVA: 0x21B3880 Offset: 0x21B1E80 VA: 0x1821B3880
	public static float easeInOutBack(float start, float end, float val, float overshoot = 1) { }

	// RVA: 0x21B3680 Offset: 0x21B1C80 VA: 0x1821B3680
	public static float easeInElastic(float start, float end, float val, float overshoot = 1, float period = 0,3) { }

	// RVA: 0x21B46E0 Offset: 0x21B2CE0 VA: 0x1821B46E0
	public static float easeOutElastic(float start, float end, float val, float overshoot = 1, float period = 0,3) { }

	// RVA: 0x21B3BF0 Offset: 0x21B21F0 VA: 0x1821B3BF0
	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1, float period = 0,3) { }

	// RVA: 0x21AFB80 Offset: 0x21AE180 VA: 0x1821AFB80
	public static void addListener(int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21AF5F0 Offset: 0x21ADBF0 VA: 0x1821AF5F0
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21B8F80 Offset: 0x21B7580 VA: 0x1821B8F80
	public static bool removeListener(int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21B8FF0 Offset: 0x21B75F0 VA: 0x1821B8FF0
	public static bool removeListener(int eventId) { }

	// RVA: 0x21B8CB0 Offset: 0x21B72B0 VA: 0x1821B8CB0
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback) { }

	// RVA: 0x21B26D0 Offset: 0x21B0CD0 VA: 0x1821B26D0
	public static void dispatchEvent(int eventId) { }

	// RVA: 0x21B2730 Offset: 0x21B0D30 VA: 0x1821B2730
	public static void dispatchEvent(int eventId, object data) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x21AEE90 Offset: 0x21AD490 VA: 0x1821AEE90
	private static void .cctor() { }

}

