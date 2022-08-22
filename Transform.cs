public class Transform : Component, IEnumerable // TypeDefIndex: 3569
{	// Properties
	public Vector3 position { get; set; }
	public Vector3 localPosition { get; set; }
	public Vector3 eulerAngles { get; set; }
	public Vector3 localEulerAngles { get; set; }
	public Vector3 right { get; set; }
	public Vector3 up { get; set; }
	public Vector3 forward { get; set; }
	public Quaternion rotation { get; set; }
	public Quaternion localRotation { get; set; }
	public Vector3 localScale { get; set; }
	public Transform parent { get; set; }
	internal Transform parentInternal { get; set; }
	public Matrix4x4 worldToLocalMatrix { get; }
	public Matrix4x4 localToWorldMatrix { get; }
	public Transform root { get; }
	public int childCount { get; }
	public Vector3 lossyScale { get; }
	[NativePropertyAttribute] // RVA: 0xD1B70 Offset: 0xD0F70 VA: 0x1800D1B70
	public bool hasChanged { get; set; }

	// Methods

	// RVA: 0x18F7950 Offset: 0x18F5F50 VA: 0x1818F7950
	protected void .ctor() { }

	// RVA: 0x217F7E0 Offset: 0x217DDE0 VA: 0x18217F7E0
	public Vector3 get_position() { }

	// RVA: 0x2180160 Offset: 0x217E760 VA: 0x182180160
	public void set_position(Vector3 value) { }

	// RVA: 0x217F4B0 Offset: 0x217DAB0 VA: 0x18217F4B0
	public Vector3 get_localPosition() { }

	// RVA: 0x217FED0 Offset: 0x217E4D0 VA: 0x18217FED0
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x217F1B0 Offset: 0x217D7B0 VA: 0x18217F1B0
	public Vector3 get_eulerAngles() { }

	// RVA: 0x217FC20 Offset: 0x217E220 VA: 0x18217FC20
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x217F3D0 Offset: 0x217D9D0 VA: 0x18217F3D0
	public Vector3 get_localEulerAngles() { }

	// RVA: 0x217FDD0 Offset: 0x217E3D0 VA: 0x18217FDD0
	public void set_localEulerAngles(Vector3 value) { }

	// RVA: 0x217F830 Offset: 0x217DE30 VA: 0x18217F830
	public Vector3 get_right() { }

	// RVA: 0x21801B0 Offset: 0x217E7B0 VA: 0x1821801B0
	public void set_right(Vector3 value) { }

	// RVA: 0x217FA20 Offset: 0x217E020 VA: 0x18217FA20
	public Vector3 get_up() { }

	// RVA: 0x21803A0 Offset: 0x217E9A0 VA: 0x1821803A0
	public void set_up(Vector3 value) { }

	// RVA: 0x217F240 Offset: 0x217D840 VA: 0x18217F240
	public Vector3 get_forward() { }

	// RVA: 0x217FCD0 Offset: 0x217E2D0 VA: 0x18217FCD0
	public void set_forward(Vector3 value) { }

	// RVA: 0x217F9D0 Offset: 0x217DFD0 VA: 0x18217F9D0
	public Quaternion get_rotation() { }

	// RVA: 0x2180350 Offset: 0x217E950 VA: 0x182180350
	public void set_rotation(Quaternion value) { }

	// RVA: 0x217F550 Offset: 0x217DB50 VA: 0x18217F550
	public Quaternion get_localRotation() { }

	// RVA: 0x217FF70 Offset: 0x217E570 VA: 0x18217FF70
	public void set_localRotation(Quaternion value) { }

	// RVA: 0x217F5F0 Offset: 0x217DBF0 VA: 0x18217F5F0
	public Vector3 get_localScale() { }

	// RVA: 0x2180010 Offset: 0x217E610 VA: 0x182180010
	public void set_localScale(Vector3 value) { }

	// RVA: 0x217DBD0 Offset: 0x217C1D0 VA: 0x18217DBD0
	public Transform get_parent() { }

	// RVA: 0x2180060 Offset: 0x217E660 VA: 0x182180060
	public void set_parent(Transform value) { }

	// RVA: 0x217DBD0 Offset: 0x217C1D0 VA: 0x18217DBD0
	internal Transform get_parentInternal() { }

	// RVA: 0x217EBB0 Offset: 0x217D1B0 VA: 0x18217EBB0
	internal void set_parentInternal(Transform value) { }

	// RVA: 0x217DBD0 Offset: 0x217C1D0 VA: 0x18217DBD0
	private Transform GetParent() { }

	// RVA: 0x217EBB0 Offset: 0x217D1B0 VA: 0x18217EBB0
	public void SetParent(Transform p) { }

	[FreeFunctionAttribute] // RVA: 0xD0EE0 Offset: 0xD02E0 VA: 0x1800D0EE0
	// RVA: 0x217EB50 Offset: 0x217D150 VA: 0x18217EB50
	public void SetParent(Transform parent, bool worldPositionStays) { }

	// RVA: 0x217FBC0 Offset: 0x217E1C0 VA: 0x18217FBC0
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0x217F690 Offset: 0x217DC90 VA: 0x18217F690
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x217EC60 Offset: 0x217D260 VA: 0x18217EC60
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	// RVA: 0x217EFA0 Offset: 0x217D5A0 VA: 0x18217EFA0
	public void Translate(Vector3 translation, Space relativeTo) { }

	// RVA: 0x217EF40 Offset: 0x217D540 VA: 0x18217EF40
	public void Translate(Vector3 translation) { }

	// RVA: 0x217EF70 Offset: 0x217D570 VA: 0x18217EF70
	public void Translate(float x, float y, float z) { }

	// RVA: 0x217E5C0 Offset: 0x217CBC0 VA: 0x18217E5C0
	public void Rotate(Vector3 eulers, Space relativeTo) { }

	// RVA: 0x217E880 Offset: 0x217CE80 VA: 0x18217E880
	public void Rotate(Vector3 eulers) { }

	[NativeMethodAttribute] // RVA: 0xD1180 Offset: 0xD0580 VA: 0x1800D1180
	// RVA: 0x217E320 Offset: 0x217C920 VA: 0x18217E320
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	// RVA: 0x217E990 Offset: 0x217CF90 VA: 0x18217E990
	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	// RVA: 0x217E8B0 Offset: 0x217CEB0 VA: 0x18217E8B0
	public void Rotate(Vector3 axis, float angle) { }

	// RVA: 0x217E380 Offset: 0x217C980 VA: 0x18217E380
	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	// RVA: 0x217E150 Offset: 0x217C750 VA: 0x18217E150
	public void LookAt(Transform target) { }

	// RVA: 0x217DFE0 Offset: 0x217C5E0 VA: 0x18217DFE0
	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x217E050 Offset: 0x217C650 VA: 0x18217E050
	public void LookAt(Vector3 worldPosition) { }

	[FreeFunctionAttribute] // RVA: 0xD13D0 Offset: 0xD07D0 VA: 0x1800D13D0
	// RVA: 0x217DCF0 Offset: 0x217C2F0 VA: 0x18217DCF0
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x217ED60 Offset: 0x217D360 VA: 0x18217ED60
	public Vector3 TransformDirection(Vector3 direction) { }

	// RVA: 0x217DDB0 Offset: 0x217C3B0 VA: 0x18217DDB0
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	// RVA: 0x217EEE0 Offset: 0x217D4E0 VA: 0x18217EEE0
	public Vector3 TransformVector(Vector3 vector) { }

	// RVA: 0x217DF30 Offset: 0x217C530 VA: 0x18217DF30
	public Vector3 InverseTransformVector(Vector3 vector) { }

	// RVA: 0x217EE20 Offset: 0x217D420 VA: 0x18217EE20
	public Vector3 TransformPoint(Vector3 position) { }

	// RVA: 0x217DE70 Offset: 0x217C470 VA: 0x18217DE70
	public Vector3 InverseTransformPoint(Vector3 position) { }

	// RVA: 0x217DC10 Offset: 0x217C210 VA: 0x18217DC10
	public Transform get_root() { }

	// RVA: 0x217DC10 Offset: 0x217C210 VA: 0x18217DC10
	private Transform GetRoot() { }

	[NativeMethodAttribute] // RVA: 0xD1550 Offset: 0xD0950 VA: 0x1800D1550
	// RVA: 0x217F170 Offset: 0x217D770 VA: 0x18217F170
	public int get_childCount() { }

	[FreeFunctionAttribute] // RVA: 0xD15D0 Offset: 0xD09D0 VA: 0x1800D15D0
	// RVA: 0x217D9E0 Offset: 0x217BFE0 VA: 0x18217D9E0
	public void DetachChildren() { }

	// RVA: 0x217EAD0 Offset: 0x217D0D0 VA: 0x18217EAD0
	public void SetAsFirstSibling() { }

	// RVA: 0x217EB10 Offset: 0x217D110 VA: 0x18217EB10
	public void SetAsLastSibling() { }

	// RVA: 0x217ECC0 Offset: 0x217D2C0 VA: 0x18217ECC0
	public void SetSiblingIndex(int index) { }

	// RVA: 0x217DC50 Offset: 0x217C250 VA: 0x18217DC50
	public int GetSiblingIndex() { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x217DA20 Offset: 0x217C020 VA: 0x18217DA20
	private static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) { }

	// RVA: 0x217DA80 Offset: 0x217C080 VA: 0x18217DA80
	public Transform Find(string n) { }

	[NativeMethodAttribute] // RVA: 0xD1750 Offset: 0xD0B50 VA: 0x1800D1750
	// RVA: 0x217F740 Offset: 0x217DD40 VA: 0x18217F740
	public Vector3 get_lossyScale() { }

	[FreeFunctionAttribute] // RVA: 0xD1820 Offset: 0xD0C20 VA: 0x1800D1820
	// RVA: 0x217DF90 Offset: 0x217C590 VA: 0x18217DF90
	public bool IsChildOf(Transform parent) { }

	// RVA: 0x217F390 Offset: 0x217D990 VA: 0x18217F390
	public bool get_hasChanged() { }

	// RVA: 0x217FD80 Offset: 0x217E380 VA: 0x18217FD80
	public void set_hasChanged(bool value) { }

	// RVA: 0x217DB60 Offset: 0x217C160 VA: 0x18217DB60 Slot: 4
	public IEnumerator GetEnumerator() { }

	[FreeFunctionAttribute] // RVA: 0xD1A00 Offset: 0xD0E00 VA: 0x1800D1A00
	[NativeThrowsAttribute] // RVA: 0xD1A00 Offset: 0xD0E00 VA: 0x1800D1A00
	// RVA: 0x217DB20 Offset: 0x217C120 VA: 0x18217DB20
	public Transform GetChild(int index) { }

	// RVA: 0x217F790 Offset: 0x217DD90 VA: 0x18217F790
	private void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x2180110 Offset: 0x217E710 VA: 0x182180110
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x217F460 Offset: 0x217DA60 VA: 0x18217F460
	private void get_localPosition_Injected(out Vector3 ret) { }

	// RVA: 0x217FE80 Offset: 0x217E480 VA: 0x18217FE80
	private void set_localPosition_Injected(ref Vector3 value) { }

	// RVA: 0x217F980 Offset: 0x217DF80 VA: 0x18217F980
	private void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x2180300 Offset: 0x217E900 VA: 0x182180300
	private void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0x217F500 Offset: 0x217DB00 VA: 0x18217F500
	private void get_localRotation_Injected(out Quaternion ret) { }

	// RVA: 0x217FF20 Offset: 0x217E520 VA: 0x18217FF20
	private void set_localRotation_Injected(ref Quaternion value) { }

	// RVA: 0x217F5A0 Offset: 0x217DBA0 VA: 0x18217F5A0
	private void get_localScale_Injected(out Vector3 ret) { }

	// RVA: 0x217FFC0 Offset: 0x217E5C0 VA: 0x18217FFC0
	private void set_localScale_Injected(ref Vector3 value) { }

	// RVA: 0x217FB70 Offset: 0x217E170 VA: 0x18217FB70
	private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x217F640 Offset: 0x217DC40 VA: 0x18217F640
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x217EC00 Offset: 0x217D200 VA: 0x18217EC00
	private void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x217E2C0 Offset: 0x217C8C0 VA: 0x18217E2C0
	private void RotateAroundInternal_Injected(ref Vector3 axis, float angle) { }

	// RVA: 0x217DC90 Offset: 0x217C290 VA: 0x18217DC90
	private void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp) { }

	// RVA: 0x217ED00 Offset: 0x217D300 VA: 0x18217ED00
	private void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x217DD50 Offset: 0x217C350 VA: 0x18217DD50
	private void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x217EE80 Offset: 0x217D480 VA: 0x18217EE80
	private void TransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x217DED0 Offset: 0x217C4D0 VA: 0x18217DED0
	private void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x217EDC0 Offset: 0x217D3C0 VA: 0x18217EDC0
	private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x217DE10 Offset: 0x217C410 VA: 0x18217DE10
	private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x217F6F0 Offset: 0x217DCF0 VA: 0x18217F6F0
	private void get_lossyScale_Injected(out Vector3 ret) { }

}

private class Transform.Enumerator : IEnumerator // TypeDefIndex: 3570
{	// Fields
	private Transform outer; // 0x10
	private int currentIndex; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x11B9A60 Offset: 0x11B8060 VA: 0x1811B9A60
	internal void .ctor(Transform outer) { }

	// RVA: 0x2177EB0 Offset: 0x21764B0 VA: 0x182177EB0 Slot: 5
	public object get_Current() { }

	// RVA: 0x2177E50 Offset: 0x2176450 VA: 0x182177E50 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x117C410 Offset: 0x117AA10 VA: 0x18117C410 Slot: 6
	public void Reset() { }

}

