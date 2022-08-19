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

	// RVA: 0x21AAD10 Offset: 0x21A9310 VA: 0x1821AAD10
	public int get_id() { }

	// RVA: 0x21AAE10 Offset: 0x21A9410 VA: 0x1821AAE10
	public void reset() { }

	// RVA: 0x21AAD20 Offset: 0x21A9320 VA: 0x1821AAD20
	public void init(uint id, uint global_counter) { }

	// RVA: 0x21AA3C0 Offset: 0x21A89C0 VA: 0x1821AA3C0
	private LTSeq addOn() { }

	// RVA: 0x21AA490 Offset: 0x21A8A90 VA: 0x1821AA490
	private float addPreviousDelays() { }

	// RVA: 0x21AACE0 Offset: 0x21A92E0 VA: 0x1821AACE0
	public LTSeq append(float delay) { }

	// RVA: 0x21AA4D0 Offset: 0x21A8AD0 VA: 0x1821AA4D0
	public LTSeq append(Action callback) { }

	// RVA: 0x21AA6A0 Offset: 0x21A8CA0 VA: 0x1821AA6A0
	public LTSeq append(Action<object> callback, object obj) { }

	// RVA: 0x21AA930 Offset: 0x21A8F30 VA: 0x1821AA930
	public LTSeq append(GameObject gameObject, Action callback) { }

	// RVA: 0x21AAAF0 Offset: 0x21A90F0 VA: 0x1821AAAF0
	public LTSeq append(GameObject gameObject, Action<object> callback, object obj) { }

	// RVA: 0x21AA8A0 Offset: 0x21A8EA0 VA: 0x1821AA8A0
	public LTSeq append(LTDescr tween) { }

	// RVA: 0x21AAD90 Offset: 0x21A9390 VA: 0x1821AAD90
	public LTSeq insert(LTDescr tween) { }

	// RVA: 0x21AAF20 Offset: 0x21A9520 VA: 0x1821AAF20
	public LTSeq setScale(float timeScale) { }

	// RVA: 0x21AAE60 Offset: 0x21A9460 VA: 0x1821AAE60
	private void setScaleRecursive(LTSeq seq, float timeScale, int count) { }

	// RVA: 0x21AAE50 Offset: 0x21A9450 VA: 0x1821AAE50
	public LTSeq reverse() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

