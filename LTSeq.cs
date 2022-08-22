public class LTSeq // TypeDefIndex: 5574
{	// Fields
	public LTSeq previous; // 0x10
	public LTSeq current; // 0x18
	public LTDescr tween; // 0x20
	public float totalDelay; // 0x28
	public float timeScale; // 0x2C
	private int debugIter; // 0x30
	public uint counter; // 0x34
	public bool toggle; // 0x38
	private uint _id; // 0x3C

	// Properties
	public int id { get; }

	// Methods

	// RVA: 0x21AAE10 Offset: 0x21A9410 VA: 0x1821AAE10
	public int get_id() { }

	// RVA: 0x21AAF10 Offset: 0x21A9510 VA: 0x1821AAF10
	public void reset() { }

	// RVA: 0x21AAE20 Offset: 0x21A9420 VA: 0x1821AAE20
	public void init(uint id, uint global_counter) { }

	// RVA: 0x21AA4C0 Offset: 0x21A8AC0 VA: 0x1821AA4C0
	private LTSeq addOn() { }

	// RVA: 0x21AA590 Offset: 0x21A8B90 VA: 0x1821AA590
	private float addPreviousDelays() { }

	// RVA: 0x21AADE0 Offset: 0x21A93E0 VA: 0x1821AADE0
	public LTSeq append(float delay) { }

	// RVA: 0x21AA5D0 Offset: 0x21A8BD0 VA: 0x1821AA5D0
	public LTSeq append(Action callback) { }

	// RVA: 0x21AA7A0 Offset: 0x21A8DA0 VA: 0x1821AA7A0
	public LTSeq append(Action<object> callback, object obj) { }

	// RVA: 0x21AAA30 Offset: 0x21A9030 VA: 0x1821AAA30
	public LTSeq append(GameObject gameObject, Action callback) { }

	// RVA: 0x21AABF0 Offset: 0x21A91F0 VA: 0x1821AABF0
	public LTSeq append(GameObject gameObject, Action<object> callback, object obj) { }

	// RVA: 0x21AA9A0 Offset: 0x21A8FA0 VA: 0x1821AA9A0
	public LTSeq append(LTDescr tween) { }

	// RVA: 0x21AAE90 Offset: 0x21A9490 VA: 0x1821AAE90
	public LTSeq insert(LTDescr tween) { }

	// RVA: 0x21AB020 Offset: 0x21A9620 VA: 0x1821AB020
	public LTSeq setScale(float timeScale) { }

	// RVA: 0x21AAF60 Offset: 0x21A9560 VA: 0x1821AAF60
	private void setScaleRecursive(LTSeq seq, float timeScale, int count) { }

	// RVA: 0x21AAF50 Offset: 0x21A9550 VA: 0x1821AAF50
	public LTSeq reverse() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

