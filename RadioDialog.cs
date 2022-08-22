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

	// RVA: 0x6A2E00 Offset: 0x6A1400 VA: 0x1806A2E00
	public void SetBoomBox(BoomBox box) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnURLChanged(string newUrl) { }

	// RVA: 0x6A2AB0 Offset: 0x6A10B0 VA: 0x1806A2AB0
	public void OnClickedConfirm() { }

	// RVA: 0x6A2F70 Offset: 0x6A1570 VA: 0x1806A2F70
	public void UpdateFavourites(Dictionary<string, string> globalUrls, Dictionary<string, string> serverUrls) { }

	// RVA: 0x6A2B20 Offset: 0x6A1120 VA: 0x1806A2B20
	private void PopulateFavouritesFromList(Dictionary<string, string> urls) { }

	// RVA: 0x6A2910 Offset: 0x6A0F10 VA: 0x1806A2910
	private void ClearFavourites() { }

	// RVA: 0x6A2FC0 Offset: 0x6A15C0 VA: 0x1806A2FC0
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

	// RVA: 0x6AD3A0 Offset: 0x6AB9A0 VA: 0x1806AD3A0
	internal void <PopulateFavouritesFromList>b__0(string s) { }

}

