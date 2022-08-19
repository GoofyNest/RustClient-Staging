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

	// RVA: 0x6A2CF0 Offset: 0x6A12F0 VA: 0x1806A2CF0
	public void SetBoomBox(BoomBox box) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnURLChanged(string newUrl) { }

	// RVA: 0x6A29A0 Offset: 0x6A0FA0 VA: 0x1806A29A0
	public void OnClickedConfirm() { }

	// RVA: 0x6A2E60 Offset: 0x6A1460 VA: 0x1806A2E60
	public void UpdateFavourites(Dictionary<string, string> globalUrls, Dictionary<string, string> serverUrls) { }

	// RVA: 0x6A2A10 Offset: 0x6A1010 VA: 0x1806A2A10
	private void PopulateFavouritesFromList(Dictionary<string, string> urls) { }

	// RVA: 0x6A2800 Offset: 0x6A0E00 VA: 0x1806A2800
	private void ClearFavourites() { }

	// RVA: 0x6A2EB0 Offset: 0x6A14B0 VA: 0x1806A2EB0
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

	// RVA: 0x6AD290 Offset: 0x6AB890 VA: 0x1806AD290
	internal void <PopulateFavouritesFromList>b__0(string s) { }

}

