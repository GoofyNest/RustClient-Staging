internal struct HTML_BrowserReady_t : ICallbackData // TypeDefIndex: 5451
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E97B0 Offset: 0x1E8BB0 VA: 0x1801E97B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E97A0 Offset: 0x1E8BA0 VA: 0x1801E97A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371B80 Offset: 0x1370180 VA: 0x181371B80
	private static void .cctor() { }

}

internal struct HTML_NeedsPaint_t : ICallbackData // TypeDefIndex: 5452
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PBGRA; // 0x8
	internal uint UnWide; // 0x10
	internal uint UnTall; // 0x14
	internal uint UnUpdateX; // 0x18
	internal uint UnUpdateY; // 0x1C
	internal uint UnUpdateWide; // 0x20
	internal uint UnUpdateTall; // 0x24
	internal uint UnScrollX; // 0x28
	internal uint UnScrollY; // 0x2C
	internal float FlPageScale; // 0x30
	internal uint UnPageSerial; // 0x34
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9E80 Offset: 0x1E9280 VA: 0x1801E9E80 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9E70 Offset: 0x1E9270 VA: 0x1801E9E70 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372300 Offset: 0x1370900 VA: 0x181372300
	private static void .cctor() { }

}

internal struct HTML_StartRequest_t : ICallbackData // TypeDefIndex: 5453
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchURL; // 0x8
	internal string PchTarget; // 0x10
	internal string PchPostData; // 0x18
	internal bool BIsRedirect; // 0x20
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA2C0 Offset: 0x1E96C0 VA: 0x1801EA2C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA2B0 Offset: 0x1E96B0 VA: 0x1801EA2B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13726C0 Offset: 0x1370CC0 VA: 0x1813726C0
	private static void .cctor() { }

}

internal struct HTML_CloseBrowser_t : ICallbackData // TypeDefIndex: 5454
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E99C0 Offset: 0x1E8DC0 VA: 0x1801E99C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E99B0 Offset: 0x1E8DB0 VA: 0x1801E99B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371E00 Offset: 0x1370400 VA: 0x181371E00
	private static void .cctor() { }

}

internal struct HTML_URLChanged_t : ICallbackData // TypeDefIndex: 5455
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchURL; // 0x8
	internal string PchPostData; // 0x10
	internal bool BIsRedirect; // 0x18
	internal string PchPageTitle; // 0x20
	internal bool BNewNavigation; // 0x28
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA4C0 Offset: 0x1E98C0 VA: 0x1801EA4C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA4B0 Offset: 0x1E98B0 VA: 0x1801EA4B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372800 Offset: 0x1370E00 VA: 0x181372800
	private static void .cctor() { }

}

internal struct HTML_FinishedRequest_t : ICallbackData // TypeDefIndex: 5456
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchURL; // 0x8
	internal string PchPageTitle; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9B30 Offset: 0x1E8F30 VA: 0x1801E9B30 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9B20 Offset: 0x1E8F20 VA: 0x1801E9B20 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371F40 Offset: 0x1370540 VA: 0x181371F40
	private static void .cctor() { }

}

internal struct HTML_OpenLinkInNewTab_t : ICallbackData // TypeDefIndex: 5457
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchURL; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA100 Offset: 0x1E9500 VA: 0x1801EA100 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA0F0 Offset: 0x1E94F0 VA: 0x1801EA0F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372440 Offset: 0x1370A40 VA: 0x181372440
	private static void .cctor() { }

}

internal struct HTML_ChangedTitle_t : ICallbackData // TypeDefIndex: 5458
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchTitle; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9900 Offset: 0x1E8D00 VA: 0x1801E9900 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E98F0 Offset: 0x1E8CF0 VA: 0x1801E98F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371D60 Offset: 0x1370360 VA: 0x181371D60
	private static void .cctor() { }

}

internal struct HTML_SearchResults_t : ICallbackData // TypeDefIndex: 5459
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal uint UnResults; // 0x4
	internal uint UnCurrentMatch; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA170 Offset: 0x1E9570 VA: 0x1801EA170 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA160 Offset: 0x1E9560 VA: 0x1801EA160 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13724E0 Offset: 0x1370AE0 VA: 0x1813724E0
	private static void .cctor() { }

}

internal struct HTML_CanGoBackAndForward_t : ICallbackData // TypeDefIndex: 5460
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal bool BCanGoBack; // 0x4
	internal bool BCanGoForward; // 0x5
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9890 Offset: 0x1E8C90 VA: 0x1801E9890 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9880 Offset: 0x1E8C80 VA: 0x1801E9880 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371CC0 Offset: 0x13702C0 VA: 0x181371CC0
	private static void .cctor() { }

}

internal struct HTML_HorizontalScroll_t : ICallbackData // TypeDefIndex: 5461
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal uint UnScrollMax; // 0x4
	internal uint UnScrollCurrent; // 0x8
	internal float FlPageScale; // 0xC
	internal bool BVisible; // 0x10
	internal uint UnPageSize; // 0x14
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9C10 Offset: 0x1E9010 VA: 0x1801E9C10 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9C00 Offset: 0x1E9000 VA: 0x1801E9C00 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372080 Offset: 0x1370680 VA: 0x181372080
	private static void .cctor() { }

}

internal struct HTML_VerticalScroll_t : ICallbackData // TypeDefIndex: 5462
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal uint UnScrollMax; // 0x4
	internal uint UnScrollCurrent; // 0x8
	internal float FlPageScale; // 0xC
	internal bool BVisible; // 0x10
	internal uint UnPageSize; // 0x14
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA6D0 Offset: 0x1E9AD0 VA: 0x1801EA6D0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA6C0 Offset: 0x1E9AC0 VA: 0x1801EA6C0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372940 Offset: 0x1370F40 VA: 0x181372940
	private static void .cctor() { }

}

internal struct HTML_LinkAtPosition_t : ICallbackData // TypeDefIndex: 5463
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal uint X; // 0x4
	internal uint Y; // 0x8
	internal string PchURL; // 0x10
	internal bool BInput; // 0x18
	internal bool BLiveLink; // 0x19
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9D60 Offset: 0x1E9160 VA: 0x1801E9D60 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9D50 Offset: 0x1E9150 VA: 0x1801E9D50 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372260 Offset: 0x1370860 VA: 0x181372260
	private static void .cctor() { }

}

internal struct HTML_JSAlert_t : ICallbackData // TypeDefIndex: 5464
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchMessage; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9C80 Offset: 0x1E9080 VA: 0x1801E9C80 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9C70 Offset: 0x1E9070 VA: 0x1801E9C70 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372120 Offset: 0x1370720 VA: 0x181372120
	private static void .cctor() { }

}

internal struct HTML_JSConfirm_t : ICallbackData // TypeDefIndex: 5465
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchMessage; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9CF0 Offset: 0x1E90F0 VA: 0x1801E9CF0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9CE0 Offset: 0x1E90E0 VA: 0x1801E9CE0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13721C0 Offset: 0x13707C0 VA: 0x1813721C0
	private static void .cctor() { }

}

internal struct HTML_FileOpenDialog_t : ICallbackData // TypeDefIndex: 5466
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchTitle; // 0x8
	internal string PchInitialFile; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9A30 Offset: 0x1E8E30 VA: 0x1801E9A30 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9A20 Offset: 0x1E8E20 VA: 0x1801E9A20 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371EA0 Offset: 0x13704A0 VA: 0x181371EA0
	private static void .cctor() { }

}

internal struct HTML_NewWindow_t : ICallbackData // TypeDefIndex: 5467
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchURL; // 0x8
	internal uint UnX; // 0x10
	internal uint UnY; // 0x14
	internal uint UnWide; // 0x18
	internal uint UnTall; // 0x1C
	internal uint UnNewWindow_BrowserHandle_IGNORE; // 0x20
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9FE0 Offset: 0x1E93E0 VA: 0x1801E9FE0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9FD0 Offset: 0x1E93D0 VA: 0x1801E9FD0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13723A0 Offset: 0x13709A0 VA: 0x1813723A0
	private static void .cctor() { }

}

internal struct HTML_SetCursor_t : ICallbackData // TypeDefIndex: 5468
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal uint EMouseCursor; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA1E0 Offset: 0x1E95E0 VA: 0x1801EA1E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA1D0 Offset: 0x1E95D0 VA: 0x1801EA1D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372580 Offset: 0x1370B80 VA: 0x181372580
	private static void .cctor() { }

}

internal struct HTML_StatusText_t : ICallbackData // TypeDefIndex: 5469
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchMsg; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA450 Offset: 0x1E9850 VA: 0x1801EA450 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA440 Offset: 0x1E9840 VA: 0x1801EA440 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372760 Offset: 0x1370D60 VA: 0x181372760
	private static void .cctor() { }

}

internal struct HTML_ShowToolTip_t : ICallbackData // TypeDefIndex: 5470
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchMsg; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA250 Offset: 0x1E9650 VA: 0x1801EA250 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA240 Offset: 0x1E9640 VA: 0x1801EA240 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372620 Offset: 0x1370C20 VA: 0x181372620
	private static void .cctor() { }

}

internal struct HTML_UpdateToolTip_t : ICallbackData // TypeDefIndex: 5471
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal string PchMsg; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA660 Offset: 0x1E9A60 VA: 0x1801EA660 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA650 Offset: 0x1E9A50 VA: 0x1801EA650 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x13728A0 Offset: 0x1370EA0 VA: 0x1813728A0
	private static void .cctor() { }

}

internal struct HTML_HideToolTip_t : ICallbackData // TypeDefIndex: 5472
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9BA0 Offset: 0x1E8FA0 VA: 0x1801E9BA0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9B90 Offset: 0x1E8F90 VA: 0x1801E9B90 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371FE0 Offset: 0x13705E0 VA: 0x181371FE0
	private static void .cctor() { }

}

internal struct HTML_BrowserRestarted_t : ICallbackData // TypeDefIndex: 5473
{	// Fields
	internal uint UnBrowserHandle; // 0x0
	internal uint UnOldBrowserHandle; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9820 Offset: 0x1E8C20 VA: 0x1801E9820 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9810 Offset: 0x1E8C10 VA: 0x1801E9810 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1371C20 Offset: 0x1370220 VA: 0x181371C20
	private static void .cctor() { }

}

