public class KeyframeView : MonoBehaviour // TypeDefIndex: 10866
{	// Fields
	public ScrollRect Scroller; // 0x18
	public GameObjectRef KeyframePrefab; // 0x20
	public RectTransform KeyframeRoot; // 0x28
	public Transform CurrentPositionIndicator; // 0x30
	public bool LockScrollToCurrentPosition; // 0x38
	public RustText TrackName; // 0x40
	private List<KeyframeWidget> spawnedWidgets; // 0x48

	// Methods

	// RVA: 0x681CF0 Offset: 0x6802F0 VA: 0x180681CF0
	public void Populate(DemoShotVectorTrack track, float trackLength) { }

	// RVA: 0x681DC0 Offset: 0x6803C0 VA: 0x180681DC0
	public void Populate(DemoShotFloatTrack track, float trackLength) { }

	// RVA: 0x681E90 Offset: 0x680490 VA: 0x180681E90
	public void Populate(DemoShotQuaternionTrack track, float trackLength) { }

	// RVA: 0x681F60 Offset: 0x680560 VA: 0x180681F60
	public void SetTrackName(string text) { }

	// RVA: 0x681F90 Offset: 0x680590 VA: 0x180681F90
	private void Update() { }

	// RVA: 0x681F80 Offset: 0x680580 VA: 0x180681F80
	public static float TimeToXPos(float time) { }

	// RVA: 0x681820 Offset: 0x67FE20 VA: 0x180681820
	private void ApplyTimelineLength(float trackDuration) { }

	// RVA: 0x681850 Offset: 0x67FE50 VA: 0x180681850
	private void CleanupMarkers() { }

	// RVA: 0x6819F0 Offset: 0x67FFF0 VA: 0x1806819F0
	private void PopulateMarkers(List<KeyframeView.UIKeyframeValue> toDisplay) { }

	// RVA: 0x6820D0 Offset: 0x6806D0 VA: 0x1806820D0
	public void .ctor() { }

}

public struct KeyframeView.UIKeyframeValue // TypeDefIndex: 10867
{	// Fields
	public float time; // 0x0
	public string visibleValue; // 0x8
	public object backingKeyframe; // 0x10
	public KeyframeView.UIKeyframeValue.KeyframeValueType type; // 0x18

}

public enum KeyframeView.UIKeyframeValue.KeyframeValueType // TypeDefIndex: 10868
{	// Fields
	public int value__; // 0x0
	public const KeyframeView.UIKeyframeValue.KeyframeValueType Vector3 = 0;
	public const KeyframeView.UIKeyframeValue.KeyframeValueType Quaternion = 1;
	public const KeyframeView.UIKeyframeValue.KeyframeValueType Float = 2;

}

