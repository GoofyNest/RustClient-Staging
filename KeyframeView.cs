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

	// RVA: 0x681D60 Offset: 0x680360 VA: 0x180681D60
	public void Populate(DemoShotVectorTrack track, float trackLength) { }

	// RVA: 0x681E30 Offset: 0x680430 VA: 0x180681E30
	public void Populate(DemoShotFloatTrack track, float trackLength) { }

	// RVA: 0x681F00 Offset: 0x680500 VA: 0x180681F00
	public void Populate(DemoShotQuaternionTrack track, float trackLength) { }

	// RVA: 0x681FD0 Offset: 0x6805D0 VA: 0x180681FD0
	public void SetTrackName(string text) { }

	// RVA: 0x682000 Offset: 0x680600 VA: 0x180682000
	private void Update() { }

	// RVA: 0x681FF0 Offset: 0x6805F0 VA: 0x180681FF0
	public static float TimeToXPos(float time) { }

	// RVA: 0x681890 Offset: 0x67FE90 VA: 0x180681890
	private void ApplyTimelineLength(float trackDuration) { }

	// RVA: 0x6818C0 Offset: 0x67FEC0 VA: 0x1806818C0
	private void CleanupMarkers() { }

	// RVA: 0x681A60 Offset: 0x680060 VA: 0x180681A60
	private void PopulateMarkers(List<KeyframeView.UIKeyframeValue> toDisplay) { }

	// RVA: 0x682140 Offset: 0x680740 VA: 0x180682140
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

