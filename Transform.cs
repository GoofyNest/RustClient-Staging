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
	[NativePropertyAttribute] // RVA: 0xD1AE0 Offset: 0xD0EE0 VA: 0x1800D1AE0
	public bool hasChanged { get; set; }

	// Methods

	// RVA: 0x18F7990 Offset: 0x18F5F90 VA: 0x1818F7990
	protected void .ctor() { }

	// RVA: 0x217F9A0 Offset: 0x217DFA0 VA: 0x18217F9A0
	public Vector3 get_position() { }

	// RVA: 0x2180320 Offset: 0x217E920 VA: 0x182180320
	public void set_position(Vector3 value) { }

	// RVA: 0x217F670 Offset: 0x217DC70 VA: 0x18217F670
	public Vector3 get_localPosition() { }

	// RVA: 0x2180090 Offset: 0x217E690 VA: 0x182180090
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x217F370 Offset: 0x217D970 VA: 0x18217F370
	public Vector3 get_eulerAngles() { }

	// RVA: 0x217FDE0 Offset: 0x217E3E0 VA: 0x18217FDE0
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x217F590 Offset: 0x217DB90 VA: 0x18217F590
	public Vector3 get_localEulerAngles() { }

	// RVA: 0x217FF90 Offset: 0x217E590 VA: 0x18217FF90
	public void set_localEulerAngles(Vector3 value) { }

	// RVA: 0x217F9F0 Offset: 0x217DFF0 VA: 0x18217F9F0
	public Vector3 get_right() { }

	// RVA: 0x2180370 Offset: 0x217E970 VA: 0x182180370
	public void set_right(Vector3 value) { }

	// RVA: 0x217FBE0 Offset: 0x217E1E0 VA: 0x18217FBE0
	public Vector3 get_up() { }

	// RVA: 0x2180560 Offset: 0x217EB60 VA: 0x182180560
	public void set_up(Vector3 value) { }

	// RVA: 0x217F400 Offset: 0x217DA00 VA: 0x18217F400
	public Vector3 get_forward() { }

	// RVA: 0x217FE90 Offset: 0x217E490 VA: 0x18217FE90
	public void set_forward(Vector3 value) { }

	// RVA: 0x217FB90 Offset: 0x217E190 VA: 0x18217FB90
	public Quaternion get_rotation() { }

	// RVA: 0x2180510 Offset: 0x217EB10 VA: 0x182180510
	public void set_rotation(Quaternion value) { }

	// RVA: 0x217F710 Offset: 0x217DD10 VA: 0x18217F710
	public Quaternion get_localRotation() { }

	// RVA: 0x2180130 Offset: 0x217E730 VA: 0x182180130
	public void set_localRotation(Quaternion value) { }

	// RVA: 0x217F7B0 Offset: 0x217DDB0 VA: 0x18217F7B0
	public Vector3 get_localScale() { }

	// RVA: 0x21801D0 Offset: 0x217E7D0 VA: 0x1821801D0
	public void set_localScale(Vector3 value) { }

	// RVA: 0x217DD90 Offset: 0x217C390 VA: 0x18217DD90
	public Transform get_parent() { }

	// RVA: 0x2180220 Offset: 0x217E820 VA: 0x182180220
	public void set_parent(Transform value) { }

	// RVA: 0x217DD90 Offset: 0x217C390 VA: 0x18217DD90
	internal Transform get_parentInternal() { }

	// RVA: 0x217ED70 Offset: 0x217D370 VA: 0x18217ED70
	internal void set_parentInternal(Transform value) { }

	// RVA: 0x217DD90 Offset: 0x217C390 VA: 0x18217DD90
	private Transform GetParent() { }

	// RVA: 0x217ED70 Offset: 0x217D370 VA: 0x18217ED70
	public void SetParent(Transform p) { }

	[FreeFunctionAttribute] // RVA: 0xD0E50 Offset: 0xD0250 VA: 0x1800D0E50
	// RVA: 0x217ED10 Offset: 0x217D310 VA: 0x18217ED10
	public void SetParent(Transform parent, bool worldPositionStays) { }

	// RVA: 0x217FD80 Offset: 0x217E380 VA: 0x18217FD80
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0x217F850 Offset: 0x217DE50 VA: 0x18217F850
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x217EE20 Offset: 0x217D420 VA: 0x18217EE20
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	// RVA: 0x217F160 Offset: 0x217D760 VA: 0x18217F160
	public void Translate(Vector3 translation, Space relativeTo) { }

	// RVA: 0x217F100 Offset: 0x217D700 VA: 0x18217F100
	public void Translate(Vector3 translation) { }

	// RVA: 0x217F130 Offset: 0x217D730 VA: 0x18217F130
	public void Translate(float x, float y, float z) { }

	// RVA: 0x217E780 Offset: 0x217CD80 VA: 0x18217E780
	public void Rotate(Vector3 eulers, Space relativeTo) { }

	// RVA: 0x217EA40 Offset: 0x217D040 VA: 0x18217EA40
	public void Rotate(Vector3 eulers) { }

	[NativeMethodAttribute] // RVA: 0xD10F0 Offset: 0xD04F0 VA: 0x1800D10F0
	// RVA: 0x217E4E0 Offset: 0x217CAE0 VA: 0x18217E4E0
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	// RVA: 0x217EB50 Offset: 0x217D150 VA: 0x18217EB50
	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	// RVA: 0x217EA70 Offset: 0x217D070 VA: 0x18217EA70
	public void Rotate(Vector3 axis, float angle) { }

	// RVA: 0x217E540 Offset: 0x217CB40 VA: 0x18217E540
	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	// RVA: 0x217E310 Offset: 0x217C910 VA: 0x18217E310
	public void LookAt(Transform target) { }

	// RVA: 0x217E1A0 Offset: 0x217C7A0 VA: 0x18217E1A0
	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x217E210 Offset: 0x217C810 VA: 0x18217E210
	public void LookAt(Vector3 worldPosition) { }

	[FreeFunctionAttribute] // RVA: 0xD1340 Offset: 0xD0740 VA: 0x1800D1340
	// RVA: 0x217DEB0 Offset: 0x217C4B0 VA: 0x18217DEB0
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x217EF20 Offset: 0x217D520 VA: 0x18217EF20
	public Vector3 TransformDirection(Vector3 direction) { }

	// RVA: 0x217DF70 Offset: 0x217C570 VA: 0x18217DF70
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	// RVA: 0x217F0A0 Offset: 0x217D6A0 VA: 0x18217F0A0
	public Vector3 TransformVector(Vector3 vector) { }

	// RVA: 0x217E0F0 Offset: 0x217C6F0 VA: 0x18217E0F0
	public Vector3 InverseTransformVector(Vector3 vector) { }

	// RVA: 0x217EFE0 Offset: 0x217D5E0 VA: 0x18217EFE0
	public Vector3 TransformPoint(Vector3 position) { }

	// RVA: 0x217E030 Offset: 0x217C630 VA: 0x18217E030
	public Vector3 InverseTransformPoint(Vector3 position) { }

	// RVA: 0x217DDD0 Offset: 0x217C3D0 VA: 0x18217DDD0
	public Transform get_root() { }

	// RVA: 0x217DDD0 Offset: 0x217C3D0 VA: 0x18217DDD0
	private Transform GetRoot() { }

	[NativeMethodAttribute] // RVA: 0xD14C0 Offset: 0xD08C0 VA: 0x1800D14C0
	// RVA: 0x217F330 Offset: 0x217D930 VA: 0x18217F330
	public int get_childCount() { }

	[FreeFunctionAttribute] // RVA: 0xD1540 Offset: 0xD0940 VA: 0x1800D1540
	// RVA: 0x217DBA0 Offset: 0x217C1A0 VA: 0x18217DBA0
	public void DetachChildren() { }

	// RVA: 0x217EC90 Offset: 0x217D290 VA: 0x18217EC90
	public void SetAsFirstSibling() { }

	// RVA: 0x217ECD0 Offset: 0x217D2D0 VA: 0x18217ECD0
	public void SetAsLastSibling() { }

	// RVA: 0x217EE80 Offset: 0x217D480 VA: 0x18217EE80
	public void SetSiblingIndex(int index) { }

	// RVA: 0x217DE10 Offset: 0x217C410 VA: 0x18217DE10
	public int GetSiblingIndex() { }

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x217DBE0 Offset: 0x217C1E0 VA: 0x18217DBE0
	private static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) { }

	// RVA: 0x217DC40 Offset: 0x217C240 VA: 0x18217DC40
	public Transform Find(string n) { }

	[NativeMethodAttribute] // RVA: 0xD16C0 Offset: 0xD0AC0 VA: 0x1800D16C0
	// RVA: 0x217F900 Offset: 0x217DF00 VA: 0x18217F900
	public Vector3 get_lossyScale() { }

	[FreeFunctionAttribute] // RVA: 0xD1790 Offset: 0xD0B90 VA: 0x1800D1790
	// RVA: 0x217E150 Offset: 0x217C750 VA: 0x18217E150
	public bool IsChildOf(Transform parent) { }

	// RVA: 0x217F550 Offset: 0x217DB50 VA: 0x18217F550
	public bool get_hasChanged() { }

	// RVA: 0x217FF40 Offset: 0x217E540 VA: 0x18217FF40
	public void set_hasChanged(bool value) { }

	// RVA: 0x217DD20 Offset: 0x217C320 VA: 0x18217DD20 Slot: 4
	public IEnumerator GetEnumerator() { }

	[FreeFunctionAttribute] // RVA: 0xD19C0 Offset: 0xD0DC0 VA: 0x1800D19C0
	[NativeThrowsAttribute] // RVA: 0xD19C0 Offset: 0xD0DC0 VA: 0x1800D19C0
	// RVA: 0x217DCE0 Offset: 0x217C2E0 VA: 0x18217DCE0
	public Transform GetChild(int index) { }

	// RVA: 0x217F950 Offset: 0x217DF50 VA: 0x18217F950
	private void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x21802D0 Offset: 0x217E8D0 VA: 0x1821802D0
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x217F620 Offset: 0x217DC20 VA: 0x18217F620
	private void get_localPosition_Injected(out Vector3 ret) { }

	// RVA: 0x2180040 Offset: 0x217E640 VA: 0x182180040
	private void set_localPosition_Injected(ref Vector3 value) { }

	// RVA: 0x217FB40 Offset: 0x217E140 VA: 0x18217FB40
	private void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x21804C0 Offset: 0x217EAC0 VA: 0x1821804C0
	private void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0x217F6C0 Offset: 0x217DCC0 VA: 0x18217F6C0
	private void get_localRotation_Injected(out Quaternion ret) { }

	// RVA: 0x21800E0 Offset: 0x217E6E0 VA: 0x1821800E0
	private void set_localRotation_Injected(ref Quaternion value) { }

	// RVA: 0x217F760 Offset: 0x217DD60 VA: 0x18217F760
	private void get_localScale_Injected(out Vector3 ret) { }

	// RVA: 0x2180180 Offset: 0x217E780 VA: 0x182180180
	private void set_localScale_Injected(ref Vector3 value) { }

	// RVA: 0x217FD30 Offset: 0x217E330 VA: 0x18217FD30
	private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x217F800 Offset: 0x217DE00 VA: 0x18217F800
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x217EDC0 Offset: 0x217D3C0 VA: 0x18217EDC0
	private void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x217E480 Offset: 0x217CA80 VA: 0x18217E480
	private void RotateAroundInternal_Injected(ref Vector3 axis, float angle) { }

	// RVA: 0x217DE50 Offset: 0x217C450 VA: 0x18217DE50
	private void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp) { }

	// RVA: 0x217EEC0 Offset: 0x217D4C0 VA: 0x18217EEC0
	private void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x217DF10 Offset: 0x217C510 VA: 0x18217DF10
	private void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x217F040 Offset: 0x217D640 VA: 0x18217F040
	private void TransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x217E090 Offset: 0x217C690 VA: 0x18217E090
	private void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x217EF80 Offset: 0x217D580 VA: 0x18217EF80
	private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x217DFD0 Offset: 0x217C5D0 VA: 0x18217DFD0
	private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x217F8B0 Offset: 0x217DEB0 VA: 0x18217F8B0
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

	// RVA: 0x2178070 Offset: 0x2176670 VA: 0x182178070 Slot: 5
	public object get_Current() { }

	// RVA: 0x2178010 Offset: 0x2176610 VA: 0x182178010 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x117C410 Offset: 0x117AA10 VA: 0x18117C410 Slot: 6
	public void Reset() { }

}

