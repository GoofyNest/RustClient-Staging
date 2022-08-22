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

	// RVA: 0x18F7330 Offset: 0x18F5930 VA: 0x1818F7330
	protected void .ctor() { }

	// RVA: 0x21802C0 Offset: 0x217E8C0 VA: 0x1821802C0
	public Vector3 get_position() { }

	// RVA: 0x2180C40 Offset: 0x217F240 VA: 0x182180C40
	public void set_position(Vector3 value) { }

	// RVA: 0x217FF90 Offset: 0x217E590 VA: 0x18217FF90
	public Vector3 get_localPosition() { }

	// RVA: 0x21809B0 Offset: 0x217EFB0 VA: 0x1821809B0
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x217FC90 Offset: 0x217E290 VA: 0x18217FC90
	public Vector3 get_eulerAngles() { }

	// RVA: 0x2180700 Offset: 0x217ED00 VA: 0x182180700
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x217FEB0 Offset: 0x217E4B0 VA: 0x18217FEB0
	public Vector3 get_localEulerAngles() { }

	// RVA: 0x21808B0 Offset: 0x217EEB0 VA: 0x1821808B0
	public void set_localEulerAngles(Vector3 value) { }

	// RVA: 0x2180310 Offset: 0x217E910 VA: 0x182180310
	public Vector3 get_right() { }

	// RVA: 0x2180C90 Offset: 0x217F290 VA: 0x182180C90
	public void set_right(Vector3 value) { }

	// RVA: 0x2180500 Offset: 0x217EB00 VA: 0x182180500
	public Vector3 get_up() { }

	// RVA: 0x2180E80 Offset: 0x217F480 VA: 0x182180E80
	public void set_up(Vector3 value) { }

	// RVA: 0x217FD20 Offset: 0x217E320 VA: 0x18217FD20
	public Vector3 get_forward() { }

	// RVA: 0x21807B0 Offset: 0x217EDB0 VA: 0x1821807B0
	public void set_forward(Vector3 value) { }

	// RVA: 0x21804B0 Offset: 0x217EAB0 VA: 0x1821804B0
	public Quaternion get_rotation() { }

	// RVA: 0x2180E30 Offset: 0x217F430 VA: 0x182180E30
	public void set_rotation(Quaternion value) { }

	// RVA: 0x2180030 Offset: 0x217E630 VA: 0x182180030
	public Quaternion get_localRotation() { }

	// RVA: 0x2180A50 Offset: 0x217F050 VA: 0x182180A50
	public void set_localRotation(Quaternion value) { }

	// RVA: 0x21800D0 Offset: 0x217E6D0 VA: 0x1821800D0
	public Vector3 get_localScale() { }

	// RVA: 0x2180AF0 Offset: 0x217F0F0 VA: 0x182180AF0
	public void set_localScale(Vector3 value) { }

	// RVA: 0x217E6B0 Offset: 0x217CCB0 VA: 0x18217E6B0
	public Transform get_parent() { }

	// RVA: 0x2180B40 Offset: 0x217F140 VA: 0x182180B40
	public void set_parent(Transform value) { }

	// RVA: 0x217E6B0 Offset: 0x217CCB0 VA: 0x18217E6B0
	internal Transform get_parentInternal() { }

	// RVA: 0x217F690 Offset: 0x217DC90 VA: 0x18217F690
	internal void set_parentInternal(Transform value) { }

	// RVA: 0x217E6B0 Offset: 0x217CCB0 VA: 0x18217E6B0
	private Transform GetParent() { }

	// RVA: 0x217F690 Offset: 0x217DC90 VA: 0x18217F690
	public void SetParent(Transform p) { }

	[FreeFunctionAttribute] // RVA: 0xD0EE0 Offset: 0xD02E0 VA: 0x1800D0EE0
	// RVA: 0x217F630 Offset: 0x217DC30 VA: 0x18217F630
	public void SetParent(Transform parent, bool worldPositionStays) { }

	// RVA: 0x21806A0 Offset: 0x217ECA0 VA: 0x1821806A0
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0x2180170 Offset: 0x217E770 VA: 0x182180170
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x217F740 Offset: 0x217DD40 VA: 0x18217F740
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	// RVA: 0x217FA80 Offset: 0x217E080 VA: 0x18217FA80
	public void Translate(Vector3 translation, Space relativeTo) { }

	// RVA: 0x217FA20 Offset: 0x217E020 VA: 0x18217FA20
	public void Translate(Vector3 translation) { }

	// RVA: 0x217FA50 Offset: 0x217E050 VA: 0x18217FA50
	public void Translate(float x, float y, float z) { }

	// RVA: 0x217F0A0 Offset: 0x217D6A0 VA: 0x18217F0A0
	public void Rotate(Vector3 eulers, Space relativeTo) { }

	// RVA: 0x217F360 Offset: 0x217D960 VA: 0x18217F360
	public void Rotate(Vector3 eulers) { }

	[NativeMethodAttribute] // RVA: 0xD1180 Offset: 0xD0580 VA: 0x1800D1180
	// RVA: 0x217EE00 Offset: 0x217D400 VA: 0x18217EE00
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	// RVA: 0x217F470 Offset: 0x217DA70 VA: 0x18217F470
	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	// RVA: 0x217F390 Offset: 0x217D990 VA: 0x18217F390
	public void Rotate(Vector3 axis, float angle) { }

	// RVA: 0x217EE60 Offset: 0x217D460 VA: 0x18217EE60
	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	// RVA: 0x217EC30 Offset: 0x217D230 VA: 0x18217EC30
	public void LookAt(Transform target) { }

	// RVA: 0x217EAC0 Offset: 0x217D0C0 VA: 0x18217EAC0
	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x217EB30 Offset: 0x217D130 VA: 0x18217EB30
	public void LookAt(Vector3 worldPosition) { }

	[FreeFunctionAttribute] // RVA: 0xD13D0 Offset: 0xD07D0 VA: 0x1800D13D0
	// RVA: 0x217E7D0 Offset: 0x217CDD0 VA: 0x18217E7D0
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x217F840 Offset: 0x217DE40 VA: 0x18217F840
	public Vector3 TransformDirection(Vector3 direction) { }

	// RVA: 0x217E890 Offset: 0x217CE90 VA: 0x18217E890
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	// RVA: 0x217F9C0 Offset: 0x217DFC0 VA: 0x18217F9C0
	public Vector3 TransformVector(Vector3 vector) { }

	// RVA: 0x217EA10 Offset: 0x217D010 VA: 0x18217EA10
	public Vector3 InverseTransformVector(Vector3 vector) { }

	// RVA: 0x217F900 Offset: 0x217DF00 VA: 0x18217F900
	public Vector3 TransformPoint(Vector3 position) { }

	// RVA: 0x217E950 Offset: 0x217CF50 VA: 0x18217E950
	public Vector3 InverseTransformPoint(Vector3 position) { }

	// RVA: 0x217E6F0 Offset: 0x217CCF0 VA: 0x18217E6F0
	public Transform get_root() { }

	// RVA: 0x217E6F0 Offset: 0x217CCF0 VA: 0x18217E6F0
	private Transform GetRoot() { }

	[NativeMethodAttribute] // RVA: 0xD1550 Offset: 0xD0950 VA: 0x1800D1550
	// RVA: 0x217FC50 Offset: 0x217E250 VA: 0x18217FC50
	public int get_childCount() { }

	[FreeFunctionAttribute] // RVA: 0xD15D0 Offset: 0xD09D0 VA: 0x1800D15D0
	// RVA: 0x217E4C0 Offset: 0x217CAC0 VA: 0x18217E4C0
	public void DetachChildren() { }

	// RVA: 0x217F5B0 Offset: 0x217DBB0 VA: 0x18217F5B0
	public void SetAsFirstSibling() { }

	// RVA: 0x217F5F0 Offset: 0x217DBF0 VA: 0x18217F5F0
	public void SetAsLastSibling() { }

	// RVA: 0x217F7A0 Offset: 0x217DDA0 VA: 0x18217F7A0
	public void SetSiblingIndex(int index) { }

	// RVA: 0x217E730 Offset: 0x217CD30 VA: 0x18217E730
	public int GetSiblingIndex() { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x217E500 Offset: 0x217CB00 VA: 0x18217E500
	private static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) { }

	// RVA: 0x217E560 Offset: 0x217CB60 VA: 0x18217E560
	public Transform Find(string n) { }

	[NativeMethodAttribute] // RVA: 0xD1750 Offset: 0xD0B50 VA: 0x1800D1750
	// RVA: 0x2180220 Offset: 0x217E820 VA: 0x182180220
	public Vector3 get_lossyScale() { }

	[FreeFunctionAttribute] // RVA: 0xD1820 Offset: 0xD0C20 VA: 0x1800D1820
	// RVA: 0x217EA70 Offset: 0x217D070 VA: 0x18217EA70
	public bool IsChildOf(Transform parent) { }

	// RVA: 0x217FE70 Offset: 0x217E470 VA: 0x18217FE70
	public bool get_hasChanged() { }

	// RVA: 0x2180860 Offset: 0x217EE60 VA: 0x182180860
	public void set_hasChanged(bool value) { }

	// RVA: 0x217E640 Offset: 0x217CC40 VA: 0x18217E640 Slot: 4
	public IEnumerator GetEnumerator() { }

	[FreeFunctionAttribute] // RVA: 0xD1A00 Offset: 0xD0E00 VA: 0x1800D1A00
	[NativeThrowsAttribute] // RVA: 0xD1A00 Offset: 0xD0E00 VA: 0x1800D1A00
	// RVA: 0x217E600 Offset: 0x217CC00 VA: 0x18217E600
	public Transform GetChild(int index) { }

	// RVA: 0x2180270 Offset: 0x217E870 VA: 0x182180270
	private void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x2180BF0 Offset: 0x217F1F0 VA: 0x182180BF0
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x217FF40 Offset: 0x217E540 VA: 0x18217FF40
	private void get_localPosition_Injected(out Vector3 ret) { }

	// RVA: 0x2180960 Offset: 0x217EF60 VA: 0x182180960
	private void set_localPosition_Injected(ref Vector3 value) { }

	// RVA: 0x2180460 Offset: 0x217EA60 VA: 0x182180460
	private void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x2180DE0 Offset: 0x217F3E0 VA: 0x182180DE0
	private void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0x217FFE0 Offset: 0x217E5E0 VA: 0x18217FFE0
	private void get_localRotation_Injected(out Quaternion ret) { }

	// RVA: 0x2180A00 Offset: 0x217F000 VA: 0x182180A00
	private void set_localRotation_Injected(ref Quaternion value) { }

	// RVA: 0x2180080 Offset: 0x217E680 VA: 0x182180080
	private void get_localScale_Injected(out Vector3 ret) { }

	// RVA: 0x2180AA0 Offset: 0x217F0A0 VA: 0x182180AA0
	private void set_localScale_Injected(ref Vector3 value) { }

	// RVA: 0x2180650 Offset: 0x217EC50 VA: 0x182180650
	private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2180120 Offset: 0x217E720 VA: 0x182180120
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x217F6E0 Offset: 0x217DCE0 VA: 0x18217F6E0
	private void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x217EDA0 Offset: 0x217D3A0 VA: 0x18217EDA0
	private void RotateAroundInternal_Injected(ref Vector3 axis, float angle) { }

	// RVA: 0x217E770 Offset: 0x217CD70 VA: 0x18217E770
	private void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp) { }

	// RVA: 0x217F7E0 Offset: 0x217DDE0 VA: 0x18217F7E0
	private void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x217E830 Offset: 0x217CE30 VA: 0x18217E830
	private void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x217F960 Offset: 0x217DF60 VA: 0x18217F960
	private void TransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x217E9B0 Offset: 0x217CFB0 VA: 0x18217E9B0
	private void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x217F8A0 Offset: 0x217DEA0 VA: 0x18217F8A0
	private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x217E8F0 Offset: 0x217CEF0 VA: 0x18217E8F0
	private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x21801D0 Offset: 0x217E7D0 VA: 0x1821801D0
	private void get_lossyScale_Injected(out Vector3 ret) { }

}

private class Transform.Enumerator : IEnumerator // TypeDefIndex: 3570
{	// Fields
	private Transform outer; // 0x10
	private int currentIndex; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x11BA3C0 Offset: 0x11B89C0 VA: 0x1811BA3C0
	internal void .ctor(Transform outer) { }

	// RVA: 0x2178990 Offset: 0x2176F90 VA: 0x182178990 Slot: 5
	public object get_Current() { }

	// RVA: 0x2178930 Offset: 0x2176F30 VA: 0x182178930 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1180FF0 Offset: 0x117F5F0 VA: 0x181180FF0 Slot: 6
	public void Reset() { }

}

