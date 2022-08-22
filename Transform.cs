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

	// RVA: 0x18F7C10 Offset: 0x18F6210 VA: 0x1818F7C10
	protected void .ctor() { }

	// RVA: 0x217FAA0 Offset: 0x217E0A0 VA: 0x18217FAA0
	public Vector3 get_position() { }

	// RVA: 0x2180420 Offset: 0x217EA20 VA: 0x182180420
	public void set_position(Vector3 value) { }

	// RVA: 0x217F770 Offset: 0x217DD70 VA: 0x18217F770
	public Vector3 get_localPosition() { }

	// RVA: 0x2180190 Offset: 0x217E790 VA: 0x182180190
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x217F470 Offset: 0x217DA70 VA: 0x18217F470
	public Vector3 get_eulerAngles() { }

	// RVA: 0x217FEE0 Offset: 0x217E4E0 VA: 0x18217FEE0
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x217F690 Offset: 0x217DC90 VA: 0x18217F690
	public Vector3 get_localEulerAngles() { }

	// RVA: 0x2180090 Offset: 0x217E690 VA: 0x182180090
	public void set_localEulerAngles(Vector3 value) { }

	// RVA: 0x217FAF0 Offset: 0x217E0F0 VA: 0x18217FAF0
	public Vector3 get_right() { }

	// RVA: 0x2180470 Offset: 0x217EA70 VA: 0x182180470
	public void set_right(Vector3 value) { }

	// RVA: 0x217FCE0 Offset: 0x217E2E0 VA: 0x18217FCE0
	public Vector3 get_up() { }

	// RVA: 0x2180660 Offset: 0x217EC60 VA: 0x182180660
	public void set_up(Vector3 value) { }

	// RVA: 0x217F500 Offset: 0x217DB00 VA: 0x18217F500
	public Vector3 get_forward() { }

	// RVA: 0x217FF90 Offset: 0x217E590 VA: 0x18217FF90
	public void set_forward(Vector3 value) { }

	// RVA: 0x217FC90 Offset: 0x217E290 VA: 0x18217FC90
	public Quaternion get_rotation() { }

	// RVA: 0x2180610 Offset: 0x217EC10 VA: 0x182180610
	public void set_rotation(Quaternion value) { }

	// RVA: 0x217F810 Offset: 0x217DE10 VA: 0x18217F810
	public Quaternion get_localRotation() { }

	// RVA: 0x2180230 Offset: 0x217E830 VA: 0x182180230
	public void set_localRotation(Quaternion value) { }

	// RVA: 0x217F8B0 Offset: 0x217DEB0 VA: 0x18217F8B0
	public Vector3 get_localScale() { }

	// RVA: 0x21802D0 Offset: 0x217E8D0 VA: 0x1821802D0
	public void set_localScale(Vector3 value) { }

	// RVA: 0x217DE90 Offset: 0x217C490 VA: 0x18217DE90
	public Transform get_parent() { }

	// RVA: 0x2180320 Offset: 0x217E920 VA: 0x182180320
	public void set_parent(Transform value) { }

	// RVA: 0x217DE90 Offset: 0x217C490 VA: 0x18217DE90
	internal Transform get_parentInternal() { }

	// RVA: 0x217EE70 Offset: 0x217D470 VA: 0x18217EE70
	internal void set_parentInternal(Transform value) { }

	// RVA: 0x217DE90 Offset: 0x217C490 VA: 0x18217DE90
	private Transform GetParent() { }

	// RVA: 0x217EE70 Offset: 0x217D470 VA: 0x18217EE70
	public void SetParent(Transform p) { }

	[FreeFunctionAttribute] // RVA: 0xD0EE0 Offset: 0xD02E0 VA: 0x1800D0EE0
	// RVA: 0x217EE10 Offset: 0x217D410 VA: 0x18217EE10
	public void SetParent(Transform parent, bool worldPositionStays) { }

	// RVA: 0x217FE80 Offset: 0x217E480 VA: 0x18217FE80
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0x217F950 Offset: 0x217DF50 VA: 0x18217F950
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x217EF20 Offset: 0x217D520 VA: 0x18217EF20
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	// RVA: 0x217F260 Offset: 0x217D860 VA: 0x18217F260
	public void Translate(Vector3 translation, Space relativeTo) { }

	// RVA: 0x217F200 Offset: 0x217D800 VA: 0x18217F200
	public void Translate(Vector3 translation) { }

	// RVA: 0x217F230 Offset: 0x217D830 VA: 0x18217F230
	public void Translate(float x, float y, float z) { }

	// RVA: 0x217E880 Offset: 0x217CE80 VA: 0x18217E880
	public void Rotate(Vector3 eulers, Space relativeTo) { }

	// RVA: 0x217EB40 Offset: 0x217D140 VA: 0x18217EB40
	public void Rotate(Vector3 eulers) { }

	[NativeMethodAttribute] // RVA: 0xD1180 Offset: 0xD0580 VA: 0x1800D1180
	// RVA: 0x217E5E0 Offset: 0x217CBE0 VA: 0x18217E5E0
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	// RVA: 0x217EC50 Offset: 0x217D250 VA: 0x18217EC50
	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	// RVA: 0x217EB70 Offset: 0x217D170 VA: 0x18217EB70
	public void Rotate(Vector3 axis, float angle) { }

	// RVA: 0x217E640 Offset: 0x217CC40 VA: 0x18217E640
	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	// RVA: 0x217E410 Offset: 0x217CA10 VA: 0x18217E410
	public void LookAt(Transform target) { }

	// RVA: 0x217E2A0 Offset: 0x217C8A0 VA: 0x18217E2A0
	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x217E310 Offset: 0x217C910 VA: 0x18217E310
	public void LookAt(Vector3 worldPosition) { }

	[FreeFunctionAttribute] // RVA: 0xD13D0 Offset: 0xD07D0 VA: 0x1800D13D0
	// RVA: 0x217DFB0 Offset: 0x217C5B0 VA: 0x18217DFB0
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x217F020 Offset: 0x217D620 VA: 0x18217F020
	public Vector3 TransformDirection(Vector3 direction) { }

	// RVA: 0x217E070 Offset: 0x217C670 VA: 0x18217E070
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	// RVA: 0x217F1A0 Offset: 0x217D7A0 VA: 0x18217F1A0
	public Vector3 TransformVector(Vector3 vector) { }

	// RVA: 0x217E1F0 Offset: 0x217C7F0 VA: 0x18217E1F0
	public Vector3 InverseTransformVector(Vector3 vector) { }

	// RVA: 0x217F0E0 Offset: 0x217D6E0 VA: 0x18217F0E0
	public Vector3 TransformPoint(Vector3 position) { }

	// RVA: 0x217E130 Offset: 0x217C730 VA: 0x18217E130
	public Vector3 InverseTransformPoint(Vector3 position) { }

	// RVA: 0x217DED0 Offset: 0x217C4D0 VA: 0x18217DED0
	public Transform get_root() { }

	// RVA: 0x217DED0 Offset: 0x217C4D0 VA: 0x18217DED0
	private Transform GetRoot() { }

	[NativeMethodAttribute] // RVA: 0xD1550 Offset: 0xD0950 VA: 0x1800D1550
	// RVA: 0x217F430 Offset: 0x217DA30 VA: 0x18217F430
	public int get_childCount() { }

	[FreeFunctionAttribute] // RVA: 0xD15D0 Offset: 0xD09D0 VA: 0x1800D15D0
	// RVA: 0x217DCA0 Offset: 0x217C2A0 VA: 0x18217DCA0
	public void DetachChildren() { }

	// RVA: 0x217ED90 Offset: 0x217D390 VA: 0x18217ED90
	public void SetAsFirstSibling() { }

	// RVA: 0x217EDD0 Offset: 0x217D3D0 VA: 0x18217EDD0
	public void SetAsLastSibling() { }

	// RVA: 0x217EF80 Offset: 0x217D580 VA: 0x18217EF80
	public void SetSiblingIndex(int index) { }

	// RVA: 0x217DF10 Offset: 0x217C510 VA: 0x18217DF10
	public int GetSiblingIndex() { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x217DCE0 Offset: 0x217C2E0 VA: 0x18217DCE0
	private static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) { }

	// RVA: 0x217DD40 Offset: 0x217C340 VA: 0x18217DD40
	public Transform Find(string n) { }

	[NativeMethodAttribute] // RVA: 0xD1750 Offset: 0xD0B50 VA: 0x1800D1750
	// RVA: 0x217FA00 Offset: 0x217E000 VA: 0x18217FA00
	public Vector3 get_lossyScale() { }

	[FreeFunctionAttribute] // RVA: 0xD1820 Offset: 0xD0C20 VA: 0x1800D1820
	// RVA: 0x217E250 Offset: 0x217C850 VA: 0x18217E250
	public bool IsChildOf(Transform parent) { }

	// RVA: 0x217F650 Offset: 0x217DC50 VA: 0x18217F650
	public bool get_hasChanged() { }

	// RVA: 0x2180040 Offset: 0x217E640 VA: 0x182180040
	public void set_hasChanged(bool value) { }

	// RVA: 0x217DE20 Offset: 0x217C420 VA: 0x18217DE20 Slot: 4
	public IEnumerator GetEnumerator() { }

	[FreeFunctionAttribute] // RVA: 0xD1A00 Offset: 0xD0E00 VA: 0x1800D1A00
	[NativeThrowsAttribute] // RVA: 0xD1A00 Offset: 0xD0E00 VA: 0x1800D1A00
	// RVA: 0x217DDE0 Offset: 0x217C3E0 VA: 0x18217DDE0
	public Transform GetChild(int index) { }

	// RVA: 0x217FA50 Offset: 0x217E050 VA: 0x18217FA50
	private void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x21803D0 Offset: 0x217E9D0 VA: 0x1821803D0
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x217F720 Offset: 0x217DD20 VA: 0x18217F720
	private void get_localPosition_Injected(out Vector3 ret) { }

	// RVA: 0x2180140 Offset: 0x217E740 VA: 0x182180140
	private void set_localPosition_Injected(ref Vector3 value) { }

	// RVA: 0x217FC40 Offset: 0x217E240 VA: 0x18217FC40
	private void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x21805C0 Offset: 0x217EBC0 VA: 0x1821805C0
	private void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0x217F7C0 Offset: 0x217DDC0 VA: 0x18217F7C0
	private void get_localRotation_Injected(out Quaternion ret) { }

	// RVA: 0x21801E0 Offset: 0x217E7E0 VA: 0x1821801E0
	private void set_localRotation_Injected(ref Quaternion value) { }

	// RVA: 0x217F860 Offset: 0x217DE60 VA: 0x18217F860
	private void get_localScale_Injected(out Vector3 ret) { }

	// RVA: 0x2180280 Offset: 0x217E880 VA: 0x182180280
	private void set_localScale_Injected(ref Vector3 value) { }

	// RVA: 0x217FE30 Offset: 0x217E430 VA: 0x18217FE30
	private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x217F900 Offset: 0x217DF00 VA: 0x18217F900
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x217EEC0 Offset: 0x217D4C0 VA: 0x18217EEC0
	private void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x217E580 Offset: 0x217CB80 VA: 0x18217E580
	private void RotateAroundInternal_Injected(ref Vector3 axis, float angle) { }

	// RVA: 0x217DF50 Offset: 0x217C550 VA: 0x18217DF50
	private void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp) { }

	// RVA: 0x217EFC0 Offset: 0x217D5C0 VA: 0x18217EFC0
	private void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x217E010 Offset: 0x217C610 VA: 0x18217E010
	private void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x217F140 Offset: 0x217D740 VA: 0x18217F140
	private void TransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x217E190 Offset: 0x217C790 VA: 0x18217E190
	private void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x217F080 Offset: 0x217D680 VA: 0x18217F080
	private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x217E0D0 Offset: 0x217C6D0 VA: 0x18217E0D0
	private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x217F9B0 Offset: 0x217DFB0 VA: 0x18217F9B0
	private void get_lossyScale_Injected(out Vector3 ret) { }

}

private class Transform.Enumerator : IEnumerator // TypeDefIndex: 3570
{	// Fields
	private Transform outer; // 0x10
	private int currentIndex; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x11B9D20 Offset: 0x11B8320 VA: 0x1811B9D20
	internal void .ctor(Transform outer) { }

	// RVA: 0x2178170 Offset: 0x2176770 VA: 0x182178170 Slot: 5
	public object get_Current() { }

	// RVA: 0x2178110 Offset: 0x2176710 VA: 0x182178110 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x117C6D0 Offset: 0x117ACD0 VA: 0x18117C6D0 Slot: 6
	public void Reset() { }

}

