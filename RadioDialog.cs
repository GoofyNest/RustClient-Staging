public class RadioDialog : UIDialog // TypeDefIndex: 10906
{	// Fields
	public RustInput IpInput; // 0x30
	public GameObjectRef FavouritePrefab; // 0x38
	public Transform FavouritesContainer; // 0x40
	public GameObject HasCassetteRoot; // 0x48
	public static RadioDialog Instance; // 0x0
	private BoomBox currentBox; // 0x50
	private List<FavouriteRadioStation> spawnedFavourites; // 0x58
	private string selectedUrl; // 0x60

	// Methods

	// RVA: 0x6A2D90 Offset: 0x6A1390 VA: 0x1806A2D90
	public void SetBoomBox(BoomBox box) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnURLChanged(string newUrl) { }

	// RVA: 0x6A2A40 Offset: 0x6A1040 VA: 0x1806A2A40
	public void OnClickedConfirm() { }

	// RVA: 0x6A2F00 Offset: 0x6A1500 VA: 0x1806A2F00
	public void UpdateFavourites(Dictionary<string, string> globalUrls, Dictionary<string, string> serverUrls) { }

	// RVA: 0x6A2AB0 Offset: 0x6A10B0 VA: 0x1806A2AB0
	private void PopulateFavouritesFromList(Dictionary<string, string> urls) { }

	// RVA: 0x6A28A0 Offset: 0x6A0EA0 VA: 0x1806A28A0
	private void ClearFavourites() { }

	// RVA: 0x6A2F50 Offset: 0x6A1550 VA: 0x1806A2F50
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

private sealed class RadioDialog.<>c__DisplayClass12_0 // TypeDefIndex: 10907
{	// Fields
	public KeyValuePair<string, string> favourite; // 0x10
	public RadioDialog <>4__this; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x6AD330 Offset: 0x6AB930 VA: 0x1806AD330
	internal void <PopulateFavouritesFromList>b__0(string s) { }

}

