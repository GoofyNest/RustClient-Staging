public static class ComponentExtensions // TypeDefIndex: 6223
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static T Duplicate<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB4B0 Offset: 0x5C9AB0 VA: 0x1805CB4B0
	|-ComponentExtensions.Duplicate<RustText>
	|-ComponentExtensions.Duplicate<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static T[] Duplicate<T>(T obj, int amount, bool includeOriginalInArray = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A36C10 Offset: 0x1A35210 VA: 0x181A36C10
	|-ComponentExtensions.Duplicate<ESPPlayerInfo>
	|-ComponentExtensions.Duplicate<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void SetActive<T>(T obj, bool active) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15709F0 Offset: 0x156EFF0 VA: 0x1815709F0
	|-ComponentExtensions.SetActive<HttpImage>
	|-ComponentExtensions.SetActive<RustImageButton>
	|-ComponentExtensions.SetActive<RustLayout>
	|-ComponentExtensions.SetActive<RustText>
	|-ComponentExtensions.SetActive<ServerBrowserTag>
	|-ComponentExtensions.SetActive<object>
	|-ComponentExtensions.SetActive<RectTransform>
	|-ComponentExtensions.SetActive<Image>
	|-ComponentExtensions.SetActive<RawImage>
	|-ComponentExtensions.SetActive<ScrollRect>
	|-ComponentExtensions.SetActive<Text>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Vector2 WorldToRectTransform<T>(T obj, Vector2 worldPos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A36EF0 Offset: 0x1A354F0 VA: 0x181A36EF0
	|-ComponentExtensions.WorldToRectTransform<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static Rect GetWorldRect<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A36CD0 Offset: 0x1A352D0 VA: 0x181A36CD0
	|-ComponentExtensions.GetWorldRect<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool GetComponent<T, U>(T obj, out U value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D5B0 Offset: 0x125BBB0 VA: 0x18125D5B0
	|-ComponentExtensions.GetComponent<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool GetComponentInParent<T, U>(T obj, out U value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D5B0 Offset: 0x125BBB0 VA: 0x18125D5B0
	|-ComponentExtensions.GetComponentInParent<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool GetComponentInChildren<T, U>(T obj, out U value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D5B0 Offset: 0x125BBB0 VA: 0x18125D5B0
	|-ComponentExtensions.GetComponentInChildren<object, object>
	*/

}

