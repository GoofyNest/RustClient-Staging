public static class GenericsUtil // TypeDefIndex: 4817
{	// Methods

	// RVA: -1 Offset: -1
	public static TDst Cast<TSrc, TDst>(TSrc obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A3EB0 Offset: 0x15A24B0 VA: 0x1815A3EB0
	|-GenericsUtil.Cast<bool, bool>
	|-GenericsUtil.Cast<bool, byte>
	|-GenericsUtil.Cast<bool, sbyte>
	|-GenericsUtil.Cast<byte, bool>
	|-GenericsUtil.Cast<byte, byte>
	|-GenericsUtil.Cast<byte, sbyte>
	|-GenericsUtil.Cast<sbyte, bool>
	|-GenericsUtil.Cast<sbyte, byte>
	|-GenericsUtil.Cast<sbyte, sbyte>
	|
	|-RVA: 0x15A4140 Offset: 0x15A2740 VA: 0x1815A4140
	|-GenericsUtil.Cast<bool, short>
	|-GenericsUtil.Cast<bool, ushort>
	|-GenericsUtil.Cast<byte, short>
	|-GenericsUtil.Cast<byte, ushort>
	|-GenericsUtil.Cast<sbyte, short>
	|-GenericsUtil.Cast<sbyte, ushort>
	|
	|-RVA: 0x15A4280 Offset: 0x15A2880 VA: 0x1815A4280
	|-GenericsUtil.Cast<bool, int>
	|-GenericsUtil.Cast<bool, uint>
	|-GenericsUtil.Cast<byte, int>
	|-GenericsUtil.Cast<byte, uint>
	|-GenericsUtil.Cast<sbyte, int>
	|-GenericsUtil.Cast<sbyte, uint>
	|
	|-RVA: 0x15A43C0 Offset: 0x15A29C0 VA: 0x1815A43C0
	|-GenericsUtil.Cast<bool, long>
	|-GenericsUtil.Cast<bool, object>
	|-GenericsUtil.Cast<bool, ulong>
	|-GenericsUtil.Cast<byte, long>
	|-GenericsUtil.Cast<byte, object>
	|-GenericsUtil.Cast<byte, ulong>
	|-GenericsUtil.Cast<sbyte, long>
	|-GenericsUtil.Cast<sbyte, object>
	|-GenericsUtil.Cast<sbyte, ulong>
	|
	|-RVA: 0x15A4650 Offset: 0x15A2C50 VA: 0x1815A4650
	|-GenericsUtil.Cast<bool, float>
	|-GenericsUtil.Cast<byte, float>
	|-GenericsUtil.Cast<sbyte, float>
	|
	|-RVA: 0x15A3FF0 Offset: 0x15A25F0 VA: 0x1815A3FF0
	|-GenericsUtil.Cast<bool, Color>
	|-GenericsUtil.Cast<byte, Color>
	|-GenericsUtil.Cast<sbyte, Color>
	|
	|-RVA: 0x15A4500 Offset: 0x15A2B00 VA: 0x1815A4500
	|-GenericsUtil.Cast<bool, Ray>
	|-GenericsUtil.Cast<byte, Ray>
	|-GenericsUtil.Cast<sbyte, Ray>
	|
	|-RVA: 0x15A4790 Offset: 0x15A2D90 VA: 0x1815A4790
	|-GenericsUtil.Cast<bool, Vector3>
	|-GenericsUtil.Cast<byte, Vector3>
	|-GenericsUtil.Cast<sbyte, Vector3>
	|
	|-RVA: 0x15A4CB0 Offset: 0x15A32B0 VA: 0x1815A4CB0
	|-GenericsUtil.Cast<Guid, int>
	|-GenericsUtil.Cast<Color, int>
	|-GenericsUtil.Cast<Color, uint>
	|
	|-RVA: 0x15A4DF0 Offset: 0x15A33F0 VA: 0x1815A4DF0
	|-GenericsUtil.Cast<Guid, long>
	|-GenericsUtil.Cast<Guid, object>
	|-GenericsUtil.Cast<Color, long>
	|-GenericsUtil.Cast<Color, object>
	|-GenericsUtil.Cast<Color, ulong>
	|
	|-RVA: 0x15A5330 Offset: 0x15A3930 VA: 0x1815A5330
	|-GenericsUtil.Cast<int, bool>
	|-GenericsUtil.Cast<int, byte>
	|-GenericsUtil.Cast<int, sbyte>
	|-GenericsUtil.Cast<uint, bool>
	|-GenericsUtil.Cast<uint, byte>
	|-GenericsUtil.Cast<uint, sbyte>
	|
	|-RVA: 0x15A55C0 Offset: 0x15A3BC0 VA: 0x1815A55C0
	|-GenericsUtil.Cast<int, double>
	|
	|-RVA: 0x15A5470 Offset: 0x15A3A70 VA: 0x1815A5470
	|-GenericsUtil.Cast<int, Guid>
	|-GenericsUtil.Cast<int, Color>
	|-GenericsUtil.Cast<uint, Color>
	|
	|-RVA: 0x15A5700 Offset: 0x15A3D00 VA: 0x1815A5700
	|-GenericsUtil.Cast<int, short>
	|-GenericsUtil.Cast<int, ushort>
	|-GenericsUtil.Cast<uint, short>
	|-GenericsUtil.Cast<uint, ushort>
	|
	|-RVA: 0x15A5840 Offset: 0x15A3E40 VA: 0x1815A5840
	|-GenericsUtil.Cast<int, int>
	|-GenericsUtil.Cast<int, uint>
	|-GenericsUtil.Cast<uint, int>
	|-GenericsUtil.Cast<uint, uint>
	|
	|-RVA: 0x15A5970 Offset: 0x15A3F70 VA: 0x1815A5970
	|-GenericsUtil.Cast<int, long>
	|-GenericsUtil.Cast<int, object>
	|-GenericsUtil.Cast<int, ulong>
	|-GenericsUtil.Cast<uint, long>
	|-GenericsUtil.Cast<uint, object>
	|-GenericsUtil.Cast<uint, ulong>
	|
	|-RVA: 0x15A5C00 Offset: 0x15A4200 VA: 0x1815A5C00
	|-GenericsUtil.Cast<int, float>
	|-GenericsUtil.Cast<uint, float>
	|
	|-RVA: 0x15A5AB0 Offset: 0x15A40B0 VA: 0x1815A5AB0
	|-GenericsUtil.Cast<int, Ray>
	|-GenericsUtil.Cast<uint, Ray>
	|
	|-RVA: 0x15A5D40 Offset: 0x15A4340 VA: 0x1815A5D40
	|-GenericsUtil.Cast<int, Vector3>
	|-GenericsUtil.Cast<uint, Vector3>
	|
	|-RVA: 0x15A5E90 Offset: 0x15A4490 VA: 0x1815A5E90
	|-GenericsUtil.Cast<long, int>
	|-GenericsUtil.Cast<ulong, int>
	|-GenericsUtil.Cast<ulong, uint>
	|
	|-RVA: 0x15A5FD0 Offset: 0x15A45D0 VA: 0x1815A5FD0
	|-GenericsUtil.Cast<long, long>
	|-GenericsUtil.Cast<long, object>
	|-GenericsUtil.Cast<ulong, long>
	|-GenericsUtil.Cast<ulong, object>
	|-GenericsUtil.Cast<ulong, ulong>
	|
	|-RVA: 0x15A6B80 Offset: 0x15A5180 VA: 0x1815A6B80
	|-GenericsUtil.Cast<object, bool>
	|-GenericsUtil.Cast<object, byte>
	|-GenericsUtil.Cast<object, sbyte>
	|
	|-RVA: 0x15A6E20 Offset: 0x15A5420 VA: 0x1815A6E20
	|-GenericsUtil.Cast<object, double>
	|
	|-RVA: 0x15A6CC0 Offset: 0x15A52C0 VA: 0x1815A6CC0
	|-GenericsUtil.Cast<object, Guid>
	|-GenericsUtil.Cast<object, Color>
	|
	|-RVA: 0x15A6F60 Offset: 0x15A5560 VA: 0x1815A6F60
	|-GenericsUtil.Cast<object, short>
	|-GenericsUtil.Cast<object, ushort>
	|
	|-RVA: 0x15A70A0 Offset: 0x15A56A0 VA: 0x1815A70A0
	|-GenericsUtil.Cast<object, int>
	|-GenericsUtil.Cast<object, uint>
	|
	|-RVA: 0x15A71E0 Offset: 0x15A57E0 VA: 0x1815A71E0
	|-GenericsUtil.Cast<object, long>
	|-GenericsUtil.Cast<object, object>
	|-GenericsUtil.Cast<object, ulong>
	|
	|-RVA: 0x15A7480 Offset: 0x15A5A80 VA: 0x1815A7480
	|-GenericsUtil.Cast<object, float>
	|
	|-RVA: 0x15A7320 Offset: 0x15A5920 VA: 0x1815A7320
	|-GenericsUtil.Cast<object, Ray>
	|
	|-RVA: 0x15A75C0 Offset: 0x15A5BC0 VA: 0x1815A75C0
	|-GenericsUtil.Cast<object, Vector3>
	|
	|-RVA: 0x15A7720 Offset: 0x15A5D20 VA: 0x1815A7720
	|-GenericsUtil.Cast<float, bool>
	|-GenericsUtil.Cast<float, byte>
	|-GenericsUtil.Cast<float, sbyte>
	|
	|-RVA: 0x15A79B0 Offset: 0x15A5FB0 VA: 0x1815A79B0
	|-GenericsUtil.Cast<float, short>
	|-GenericsUtil.Cast<float, ushort>
	|
	|-RVA: 0x15A7AF0 Offset: 0x15A60F0 VA: 0x1815A7AF0
	|-GenericsUtil.Cast<float, int>
	|-GenericsUtil.Cast<float, uint>
	|
	|-RVA: 0x15A7C30 Offset: 0x15A6230 VA: 0x1815A7C30
	|-GenericsUtil.Cast<float, long>
	|-GenericsUtil.Cast<float, object>
	|-GenericsUtil.Cast<float, ulong>
	|
	|-RVA: 0x15A7ED0 Offset: 0x15A64D0 VA: 0x1815A7ED0
	|-GenericsUtil.Cast<float, float>
	|
	|-RVA: 0x15A7860 Offset: 0x15A5E60 VA: 0x1815A7860
	|-GenericsUtil.Cast<float, Color>
	|
	|-RVA: 0x15A7D70 Offset: 0x15A6370 VA: 0x1815A7D70
	|-GenericsUtil.Cast<float, Ray>
	|
	|-RVA: 0x15A8010 Offset: 0x15A6610 VA: 0x1815A8010
	|-GenericsUtil.Cast<float, Vector3>
	|
	|-RVA: 0x15A8160 Offset: 0x15A6760 VA: 0x1815A8160
	|-GenericsUtil.Cast<ulong, bool>
	|-GenericsUtil.Cast<ulong, byte>
	|-GenericsUtil.Cast<ulong, sbyte>
	|
	|-RVA: 0x15A83F0 Offset: 0x15A69F0 VA: 0x1815A83F0
	|-GenericsUtil.Cast<ulong, short>
	|-GenericsUtil.Cast<ulong, ushort>
	|
	|-RVA: 0x15A8680 Offset: 0x15A6C80 VA: 0x1815A8680
	|-GenericsUtil.Cast<ulong, float>
	|
	|-RVA: 0x15A82A0 Offset: 0x15A68A0 VA: 0x1815A82A0
	|-GenericsUtil.Cast<ulong, Color>
	|
	|-RVA: 0x15A8530 Offset: 0x15A6B30 VA: 0x1815A8530
	|-GenericsUtil.Cast<ulong, Ray>
	|
	|-RVA: 0x15A87C0 Offset: 0x15A6DC0 VA: 0x1815A87C0
	|-GenericsUtil.Cast<ulong, Vector3>
	|
	|-RVA: 0x15A48E0 Offset: 0x15A2EE0 VA: 0x1815A48E0
	|-GenericsUtil.Cast<Color, bool>
	|-GenericsUtil.Cast<Color, byte>
	|-GenericsUtil.Cast<Color, sbyte>
	|
	|-RVA: 0x15A4B70 Offset: 0x15A3170 VA: 0x1815A4B70
	|-GenericsUtil.Cast<Color, short>
	|-GenericsUtil.Cast<Color, ushort>
	|
	|-RVA: 0x15A5090 Offset: 0x15A3690 VA: 0x1815A5090
	|-GenericsUtil.Cast<Color, float>
	|
	|-RVA: 0x15A4A20 Offset: 0x15A3020 VA: 0x1815A4A20
	|-GenericsUtil.Cast<Color, Color>
	|
	|-RVA: 0x15A4F30 Offset: 0x15A3530 VA: 0x1815A4F30
	|-GenericsUtil.Cast<Color, Ray>
	|
	|-RVA: 0x15A51D0 Offset: 0x15A37D0 VA: 0x1815A51D0
	|-GenericsUtil.Cast<Color, Vector3>
	|
	|-RVA: 0x15A6110 Offset: 0x15A4710 VA: 0x1815A6110
	|-GenericsUtil.Cast<Ray, bool>
	|-GenericsUtil.Cast<Ray, byte>
	|-GenericsUtil.Cast<Ray, sbyte>
	|
	|-RVA: 0x15A63B0 Offset: 0x15A49B0 VA: 0x1815A63B0
	|-GenericsUtil.Cast<Ray, short>
	|-GenericsUtil.Cast<Ray, ushort>
	|
	|-RVA: 0x15A64F0 Offset: 0x15A4AF0 VA: 0x1815A64F0
	|-GenericsUtil.Cast<Ray, int>
	|-GenericsUtil.Cast<Ray, uint>
	|
	|-RVA: 0x15A6630 Offset: 0x15A4C30 VA: 0x1815A6630
	|-GenericsUtil.Cast<Ray, long>
	|-GenericsUtil.Cast<Ray, object>
	|-GenericsUtil.Cast<Ray, ulong>
	|
	|-RVA: 0x15A68D0 Offset: 0x15A4ED0 VA: 0x1815A68D0
	|-GenericsUtil.Cast<Ray, float>
	|
	|-RVA: 0x15A6250 Offset: 0x15A4850 VA: 0x1815A6250
	|-GenericsUtil.Cast<Ray, Color>
	|
	|-RVA: 0x15A6770 Offset: 0x15A4D70 VA: 0x1815A6770
	|-GenericsUtil.Cast<Ray, Ray>
	|
	|-RVA: 0x15A6A20 Offset: 0x15A5020 VA: 0x1815A6A20
	|-GenericsUtil.Cast<Ray, Vector3>
	|
	|-RVA: 0x15A8910 Offset: 0x15A6F10 VA: 0x1815A8910
	|-GenericsUtil.Cast<Vector3, bool>
	|-GenericsUtil.Cast<Vector3, byte>
	|-GenericsUtil.Cast<Vector3, sbyte>
	|
	|-RVA: 0x15A8BB0 Offset: 0x15A71B0 VA: 0x1815A8BB0
	|-GenericsUtil.Cast<Vector3, short>
	|-GenericsUtil.Cast<Vector3, ushort>
	|
	|-RVA: 0x15A8CF0 Offset: 0x15A72F0 VA: 0x1815A8CF0
	|-GenericsUtil.Cast<Vector3, int>
	|-GenericsUtil.Cast<Vector3, uint>
	|
	|-RVA: 0x15A8E30 Offset: 0x15A7430 VA: 0x1815A8E30
	|-GenericsUtil.Cast<Vector3, long>
	|-GenericsUtil.Cast<Vector3, object>
	|-GenericsUtil.Cast<Vector3, ulong>
	|
	|-RVA: 0x15A90D0 Offset: 0x15A76D0 VA: 0x1815A90D0
	|-GenericsUtil.Cast<Vector3, float>
	|
	|-RVA: 0x15A8A50 Offset: 0x15A7050 VA: 0x1815A8A50
	|-GenericsUtil.Cast<Vector3, Color>
	|
	|-RVA: 0x15A8F70 Offset: 0x15A7570 VA: 0x1815A8F70
	|-GenericsUtil.Cast<Vector3, Ray>
	|
	|-RVA: 0x15A9210 Offset: 0x15A7810 VA: 0x1815A9210
	|-GenericsUtil.Cast<Vector3, Vector3>
	*/

	// RVA: -1 Offset: -1
	public static void Swap<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x570EF0 Offset: 0x56F4F0 VA: 0x180570EF0
	|-GenericsUtil.Swap<List<PlaceMonuments.SpawnInfo>>
	|-GenericsUtil.Swap<List<PlaceMonumentsOffshore.SpawnInfo>>
	|-GenericsUtil.Swap<List<PlaceMonumentsRailside.SpawnInfo>>
	|-GenericsUtil.Swap<List<PlaceMonumentsRoadside.SpawnInfo>>
	|-GenericsUtil.Swap<object>
	|-GenericsUtil.Swap<float[]>
	*/

}

private static class GenericsUtil.CastImpl<TSrc, TDst> // TypeDefIndex: 4818
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public static TSrc Value; // 0xFFFFFFFF

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E3630 Offset: 0x15E1C30 VA: 0x1815E3630
	|-GenericsUtil.CastImpl<bool, bool>..cctor
	|
	|-RVA: 0x15DE1D0 Offset: 0x15DC7D0 VA: 0x1815DE1D0
	|-GenericsUtil.CastImpl<bool, byte>..cctor
	|
	|-RVA: 0x15E3090 Offset: 0x15E1690 VA: 0x1815E3090
	|-GenericsUtil.CastImpl<bool, short>..cctor
	|
	|-RVA: 0x15DD0F0 Offset: 0x15DB6F0 VA: 0x1815DD0F0
	|-GenericsUtil.CastImpl<bool, int>..cctor
	|
	|-RVA: 0x15DD690 Offset: 0x15DBC90 VA: 0x1815DD690
	|-GenericsUtil.CastImpl<bool, long>..cctor
	|
	|-RVA: 0x15DE680 Offset: 0x15DCC80 VA: 0x1815DE680
	|-GenericsUtil.CastImpl<bool, object>..cctor
	|
	|-RVA: 0x15E3BD0 Offset: 0x15E21D0 VA: 0x1815E3BD0
	|-GenericsUtil.CastImpl<bool, sbyte>..cctor
	|
	|-RVA: 0x15E4620 Offset: 0x15E2C20 VA: 0x1815E4620
	|-GenericsUtil.CastImpl<bool, float>..cctor
	|
	|-RVA: 0x15E0660 Offset: 0x15DEC60 VA: 0x1815E0660
	|-GenericsUtil.CastImpl<bool, ushort>..cctor
	|
	|-RVA: 0x15DDC30 Offset: 0x15DC230 VA: 0x1815DDC30
	|-GenericsUtil.CastImpl<bool, uint>..cctor
	|
	|-RVA: 0x15E3720 Offset: 0x15E1D20 VA: 0x1815E3720
	|-GenericsUtil.CastImpl<bool, ulong>..cctor
	|
	|-RVA: 0x15DEB30 Offset: 0x15DD130 VA: 0x1815DEB30
	|-GenericsUtil.CastImpl<bool, Color>..cctor
	|
	|-RVA: 0x15DF1C0 Offset: 0x15DD7C0 VA: 0x1815DF1C0
	|-GenericsUtil.CastImpl<bool, Ray>..cctor
	|
	|-RVA: 0x15DD780 Offset: 0x15DBD80 VA: 0x1815DD780
	|-GenericsUtil.CastImpl<bool, Vector3>..cctor
	|
	|-RVA: 0x15DFC10 Offset: 0x15DE210 VA: 0x1815DFC10
	|-GenericsUtil.CastImpl<byte, bool>..cctor
	|
	|-RVA: 0x15DE950 Offset: 0x15DCF50 VA: 0x1815DE950
	|-GenericsUtil.CastImpl<byte, byte>..cctor
	|
	|-RVA: 0x15E4530 Offset: 0x15E2B30 VA: 0x1815E4530
	|-GenericsUtil.CastImpl<byte, short>..cctor
	|
	|-RVA: 0x15DEFE0 Offset: 0x15DD5E0 VA: 0x1815DEFE0
	|-GenericsUtil.CastImpl<byte, int>..cctor
	|
	|-RVA: 0x15E1CE0 Offset: 0x15E02E0 VA: 0x1815E1CE0
	|-GenericsUtil.CastImpl<byte, long>..cctor
	|
	|-RVA: 0x15E1830 Offset: 0x15DFE30 VA: 0x1815E1830
	|-GenericsUtil.CastImpl<byte, object>..cctor
	|
	|-RVA: 0x15DD000 Offset: 0x15DB600 VA: 0x1815DD000
	|-GenericsUtil.CastImpl<byte, sbyte>..cctor
	|
	|-RVA: 0x15DEC20 Offset: 0x15DD220 VA: 0x1815DEC20
	|-GenericsUtil.CastImpl<byte, float>..cctor
	|
	|-RVA: 0x15E2730 Offset: 0x15E0D30 VA: 0x1815E2730
	|-GenericsUtil.CastImpl<byte, ushort>..cctor
	|
	|-RVA: 0x15DDF00 Offset: 0x15DC500 VA: 0x1815DDF00
	|-GenericsUtil.CastImpl<byte, uint>..cctor
	|
	|-RVA: 0x15DD870 Offset: 0x15DBE70 VA: 0x1815DD870
	|-GenericsUtil.CastImpl<byte, ulong>..cctor
	|
	|-RVA: 0x15E0390 Offset: 0x15DE990 VA: 0x1815E0390
	|-GenericsUtil.CastImpl<byte, Color>..cctor
	|
	|-RVA: 0x15DD1E0 Offset: 0x15DB7E0 VA: 0x1815DD1E0
	|-GenericsUtil.CastImpl<byte, Ray>..cctor
	|
	|-RVA: 0x15E0C00 Offset: 0x15DF200 VA: 0x1815E0C00
	|-GenericsUtil.CastImpl<byte, Vector3>..cctor
	|
	|-RVA: 0x15E2550 Offset: 0x15E0B50 VA: 0x1815E2550
	|-GenericsUtil.CastImpl<double, int>..cctor
	|
	|-RVA: 0x15E3810 Offset: 0x15E1E10 VA: 0x1815E3810
	|-GenericsUtil.CastImpl<double, object>..cctor
	|
	|-RVA: 0x15E1290 Offset: 0x15DF890 VA: 0x1815E1290
	|-GenericsUtil.CastImpl<Guid, int>..cctor
	|
	|-RVA: 0x15DF580 Offset: 0x15DDB80 VA: 0x1815DF580
	|-GenericsUtil.CastImpl<Guid, long>..cctor
	|
	|-RVA: 0x15DDD20 Offset: 0x15DC320 VA: 0x1815DDD20
	|-GenericsUtil.CastImpl<Guid, object>..cctor
	|
	|-RVA: 0x15E4350 Offset: 0x15E2950 VA: 0x1815E4350
	|-GenericsUtil.CastImpl<short, bool>..cctor
	|
	|-RVA: 0x15E0750 Offset: 0x15DED50 VA: 0x1815E0750
	|-GenericsUtil.CastImpl<short, byte>..cctor
	|
	|-RVA: 0x15DEE00 Offset: 0x15DD400 VA: 0x1815DEE00
	|-GenericsUtil.CastImpl<short, int>..cctor
	|
	|-RVA: 0x15DF490 Offset: 0x15DDA90 VA: 0x1815DF490
	|-GenericsUtil.CastImpl<short, object>..cctor
	|
	|-RVA: 0x15E2910 Offset: 0x15E0F10 VA: 0x1815E2910
	|-GenericsUtil.CastImpl<short, sbyte>..cctor
	|
	|-RVA: 0x15E1FB0 Offset: 0x15E05B0 VA: 0x1815E1FB0
	|-GenericsUtil.CastImpl<short, float>..cctor
	|
	|-RVA: 0x15E20A0 Offset: 0x15E06A0 VA: 0x1815E20A0
	|-GenericsUtil.CastImpl<short, uint>..cctor
	|
	|-RVA: 0x15E2460 Offset: 0x15E0A60 VA: 0x1815E2460
	|-GenericsUtil.CastImpl<short, ulong>..cctor
	|
	|-RVA: 0x15DF670 Offset: 0x15DDC70 VA: 0x1815DF670
	|-GenericsUtil.CastImpl<short, Color>..cctor
	|
	|-RVA: 0x15E2A00 Offset: 0x15E1000 VA: 0x1815E2A00
	|-GenericsUtil.CastImpl<short, Ray>..cctor
	|
	|-RVA: 0x15DE860 Offset: 0x15DCE60 VA: 0x1815DE860
	|-GenericsUtil.CastImpl<short, Vector3>..cctor
	|
	|-RVA: 0x15E2FA0 Offset: 0x15E15A0 VA: 0x1815E2FA0
	|-GenericsUtil.CastImpl<int, bool>..cctor
	|
	|-RVA: 0x15E39F0 Offset: 0x15E1FF0 VA: 0x1815E39F0
	|-GenericsUtil.CastImpl<int, byte>..cctor
	|
	|-RVA: 0x15DF850 Offset: 0x15DDE50 VA: 0x1815DF850
	|-GenericsUtil.CastImpl<int, double>..cctor
	|
	|-RVA: 0x15E1BF0 Offset: 0x15E01F0 VA: 0x1815E1BF0
	|-GenericsUtil.CastImpl<int, Guid>..cctor
	|
	|-RVA: 0x15E1740 Offset: 0x15DFD40 VA: 0x1815E1740
	|-GenericsUtil.CastImpl<int, short>..cctor
	|
	|-RVA: 0x15DFD00 Offset: 0x15DE300 VA: 0x1815DFD00
	|-GenericsUtil.CastImpl<int, int>..cctor
	|
	|-RVA: 0x15E11A0 Offset: 0x15DF7A0 VA: 0x1815E11A0
	|-GenericsUtil.CastImpl<int, long>..cctor
	|
	|-RVA: 0x15E10B0 Offset: 0x15DF6B0 VA: 0x1815E10B0
	|-GenericsUtil.CastImpl<int, object>..cctor
	|
	|-RVA: 0x15E3F90 Offset: 0x15E2590 VA: 0x1815E3F90
	|-GenericsUtil.CastImpl<int, sbyte>..cctor
	|
	|-RVA: 0x15E3CC0 Offset: 0x15E22C0 VA: 0x1815E3CC0
	|-GenericsUtil.CastImpl<int, float>..cctor
	|
	|-RVA: 0x15E2190 Offset: 0x15E0790 VA: 0x1815E2190
	|-GenericsUtil.CastImpl<int, ushort>..cctor
	|
	|-RVA: 0x15E0480 Offset: 0x15DEA80 VA: 0x1815E0480
	|-GenericsUtil.CastImpl<int, uint>..cctor
	|
	|-RVA: 0x15E3540 Offset: 0x15E1B40 VA: 0x1815E3540
	|-GenericsUtil.CastImpl<int, ulong>..cctor
	|
	|-RVA: 0x15DFEE0 Offset: 0x15DE4E0 VA: 0x1815DFEE0
	|-GenericsUtil.CastImpl<int, Color>..cctor
	|
	|-RVA: 0x15E01B0 Offset: 0x15DE7B0 VA: 0x1815E01B0
	|-GenericsUtil.CastImpl<int, Ray>..cctor
	|
	|-RVA: 0x15E0DE0 Offset: 0x15DF3E0 VA: 0x1815E0DE0
	|-GenericsUtil.CastImpl<int, Vector3>..cctor
	|
	|-RVA: 0x15E00C0 Offset: 0x15DE6C0 VA: 0x1815E00C0
	|-GenericsUtil.CastImpl<long, bool>..cctor
	|
	|-RVA: 0x15E1B00 Offset: 0x15E0100 VA: 0x1815E1B00
	|-GenericsUtil.CastImpl<long, byte>..cctor
	|
	|-RVA: 0x15E3360 Offset: 0x15E1960 VA: 0x1815E3360
	|-GenericsUtil.CastImpl<long, Guid>..cctor
	|
	|-RVA: 0x15E1DD0 Offset: 0x15E03D0 VA: 0x1815E1DD0
	|-GenericsUtil.CastImpl<long, int>..cctor
	|
	|-RVA: 0x15E4170 Offset: 0x15E2770 VA: 0x1815E4170
	|-GenericsUtil.CastImpl<long, long>..cctor
	|
	|-RVA: 0x15E3EA0 Offset: 0x15E24A0 VA: 0x1815E3EA0
	|-GenericsUtil.CastImpl<long, object>..cctor
	|
	|-RVA: 0x15E02A0 Offset: 0x15DE8A0 VA: 0x1815E02A0
	|-GenericsUtil.CastImpl<long, sbyte>..cctor
	|
	|-RVA: 0x15E1560 Offset: 0x15DFB60 VA: 0x1815E1560
	|-GenericsUtil.CastImpl<long, float>..cctor
	|
	|-RVA: 0x15DFB20 Offset: 0x15DE120 VA: 0x1815DFB20
	|-GenericsUtil.CastImpl<long, uint>..cctor
	|
	|-RVA: 0x15E2EB0 Offset: 0x15E14B0 VA: 0x1815E2EB0
	|-GenericsUtil.CastImpl<long, ulong>..cctor
	|
	|-RVA: 0x15E0930 Offset: 0x15DEF30 VA: 0x1815E0930
	|-GenericsUtil.CastImpl<long, Color>..cctor
	|
	|-RVA: 0x15E0FC0 Offset: 0x15DF5C0 VA: 0x1815E0FC0
	|-GenericsUtil.CastImpl<long, Ray>..cctor
	|
	|-RVA: 0x15DDB40 Offset: 0x15DC140 VA: 0x1815DDB40
	|-GenericsUtil.CastImpl<long, Vector3>..cctor
	|
	|-RVA: 0x15E2280 Offset: 0x15E0880 VA: 0x1815E2280
	|-GenericsUtil.CastImpl<object, bool>..cctor
	|
	|-RVA: 0x15DE3B0 Offset: 0x15DC9B0 VA: 0x1815DE3B0
	|-GenericsUtil.CastImpl<object, byte>..cctor
	|
	|-RVA: 0x15E3900 Offset: 0x15E1F00 VA: 0x1815E3900
	|-GenericsUtil.CastImpl<object, double>..cctor
	|
	|-RVA: 0x15DF940 Offset: 0x15DDF40 VA: 0x1815DF940
	|-GenericsUtil.CastImpl<object, Guid>..cctor
	|
	|-RVA: 0x15E3450 Offset: 0x15E1A50 VA: 0x1815E3450
	|-GenericsUtil.CastImpl<object, short>..cctor
	|
	|-RVA: 0x15E0B10 Offset: 0x15DF110 VA: 0x1815E0B10
	|-GenericsUtil.CastImpl<object, int>..cctor
	|
	|-RVA: 0x15DE0E0 Offset: 0x15DC6E0 VA: 0x1815DE0E0
	|-GenericsUtil.CastImpl<object, long>..cctor
	|
	|-RVA: 0x15E2640 Offset: 0x15E0C40 VA: 0x1815E2640
	|-GenericsUtil.CastImpl<object, object>..cctor
	|
	|-RVA: 0x15E0A20 Offset: 0x15DF020 VA: 0x1815E0A20
	|-GenericsUtil.CastImpl<object, sbyte>..cctor
	|
	|-RVA: 0x15DDE10 Offset: 0x15DC410 VA: 0x1815DDE10
	|-GenericsUtil.CastImpl<object, float>..cctor
	|
	|-RVA: 0x15E2DC0 Offset: 0x15E13C0 VA: 0x1815E2DC0
	|-GenericsUtil.CastImpl<object, ushort>..cctor
	|
	|-RVA: 0x15E4440 Offset: 0x15E2A40 VA: 0x1815E4440
	|-GenericsUtil.CastImpl<object, uint>..cctor
	|
	|-RVA: 0x15DED10 Offset: 0x15DD310 VA: 0x1815DED10
	|-GenericsUtil.CastImpl<object, ulong>..cctor
	|
	|-RVA: 0x15DD3C0 Offset: 0x15DB9C0 VA: 0x1815DD3C0
	|-GenericsUtil.CastImpl<object, Color>..cctor
	|
	|-RVA: 0x15E1650 Offset: 0x15DFC50 VA: 0x1815E1650
	|-GenericsUtil.CastImpl<object, Ray>..cctor
	|
	|-RVA: 0x15DF2B0 Offset: 0x15DD8B0 VA: 0x1815DF2B0
	|-GenericsUtil.CastImpl<object, Vector3>..cctor
	|
	|-RVA: 0x15E3DB0 Offset: 0x15E23B0 VA: 0x1815E3DB0
	|-GenericsUtil.CastImpl<sbyte, bool>..cctor
	|
	|-RVA: 0x15E1470 Offset: 0x15DFA70 VA: 0x1815E1470
	|-GenericsUtil.CastImpl<sbyte, byte>..cctor
	|
	|-RVA: 0x15DE2C0 Offset: 0x15DC8C0 VA: 0x1815DE2C0
	|-GenericsUtil.CastImpl<sbyte, short>..cctor
	|
	|-RVA: 0x15DDA50 Offset: 0x15DC050 VA: 0x1815DDA50
	|-GenericsUtil.CastImpl<sbyte, int>..cctor
	|
	|-RVA: 0x15DD960 Offset: 0x15DBF60 VA: 0x1815DD960
	|-GenericsUtil.CastImpl<sbyte, long>..cctor
	|
	|-RVA: 0x15E3AE0 Offset: 0x15E20E0 VA: 0x1815E3AE0
	|-GenericsUtil.CastImpl<sbyte, object>..cctor
	|
	|-RVA: 0x15E0840 Offset: 0x15DEE40 VA: 0x1815E0840
	|-GenericsUtil.CastImpl<sbyte, sbyte>..cctor
	|
	|-RVA: 0x15E0CF0 Offset: 0x15DF2F0 VA: 0x1815E0CF0
	|-GenericsUtil.CastImpl<sbyte, float>..cctor
	|
	|-RVA: 0x15DE770 Offset: 0x15DCD70 VA: 0x1815DE770
	|-GenericsUtil.CastImpl<sbyte, ushort>..cctor
	|
	|-RVA: 0x15DF0D0 Offset: 0x15DD6D0 VA: 0x1815DF0D0
	|-GenericsUtil.CastImpl<sbyte, uint>..cctor
	|
	|-RVA: 0x15E4260 Offset: 0x15E2860 VA: 0x1815E4260
	|-GenericsUtil.CastImpl<sbyte, ulong>..cctor
	|
	|-RVA: 0x15E1380 Offset: 0x15DF980 VA: 0x1815E1380
	|-GenericsUtil.CastImpl<sbyte, Color>..cctor
	|
	|-RVA: 0x15E4710 Offset: 0x15E2D10 VA: 0x1815E4710
	|-GenericsUtil.CastImpl<sbyte, Ray>..cctor
	|
	|-RVA: 0x15DEEF0 Offset: 0x15DD4F0 VA: 0x1815DEEF0
	|-GenericsUtil.CastImpl<sbyte, Vector3>..cctor
	|
	|-RVA: 0x15DEA40 Offset: 0x15DD040 VA: 0x1815DEA40
	|-GenericsUtil.CastImpl<float, bool>..cctor
	|
	|-RVA: 0x15DD2D0 Offset: 0x15DB8D0 VA: 0x1815DD2D0
	|-GenericsUtil.CastImpl<float, byte>..cctor
	|
	|-RVA: 0x15DFDF0 Offset: 0x15DE3F0 VA: 0x1815DFDF0
	|-GenericsUtil.CastImpl<float, short>..cctor
	|
	|-RVA: 0x15E3180 Offset: 0x15E1780 VA: 0x1815E3180
	|-GenericsUtil.CastImpl<float, int>..cctor
	|
	|-RVA: 0x15E2CD0 Offset: 0x15E12D0 VA: 0x1815E2CD0
	|-GenericsUtil.CastImpl<float, long>..cctor
	|
	|-RVA: 0x15DE590 Offset: 0x15DCB90 VA: 0x1815DE590
	|-GenericsUtil.CastImpl<float, object>..cctor
	|
	|-RVA: 0x15DD4B0 Offset: 0x15DBAB0 VA: 0x1815DD4B0
	|-GenericsUtil.CastImpl<float, sbyte>..cctor
	|
	|-RVA: 0x15E0570 Offset: 0x15DEB70 VA: 0x1815E0570
	|-GenericsUtil.CastImpl<float, float>..cctor
	|
	|-RVA: 0x15DE4A0 Offset: 0x15DCAA0 VA: 0x1815DE4A0
	|-GenericsUtil.CastImpl<float, ushort>..cctor
	|
	|-RVA: 0x15E0ED0 Offset: 0x15DF4D0 VA: 0x1815E0ED0
	|-GenericsUtil.CastImpl<float, uint>..cctor
	|
	|-RVA: 0x15DF3A0 Offset: 0x15DD9A0 VA: 0x1815DF3A0
	|-GenericsUtil.CastImpl<float, ulong>..cctor
	|
	|-RVA: 0x15E2370 Offset: 0x15E0970 VA: 0x1815E2370
	|-GenericsUtil.CastImpl<float, Color>..cctor
	|
	|-RVA: 0x15DDFF0 Offset: 0x15DC5F0 VA: 0x1815DDFF0
	|-GenericsUtil.CastImpl<float, Ray>..cctor
	|
	|-RVA: 0x15E2AF0 Offset: 0x15E10F0 VA: 0x1815E2AF0
	|-GenericsUtil.CastImpl<float, Vector3>..cctor
	|
	|-RVA: 0x15E2820 Offset: 0x15E0E20 VA: 0x1815E2820
	|-GenericsUtil.CastImpl<ushort, bool>..cctor
	|
	|-RVA: 0x15DFFD0 Offset: 0x15DE5D0 VA: 0x1815DFFD0
	|-GenericsUtil.CastImpl<ushort, byte>..cctor
	|
	|-RVA: 0x15E1920 Offset: 0x15DFF20 VA: 0x1815E1920
	|-GenericsUtil.CastImpl<ushort, int>..cctor
	|
	|-RVA: 0x15E3270 Offset: 0x15E1870 VA: 0x1815E3270
	|-GenericsUtil.CastImpl<ushort, object>..cctor
	|
	|-RVA: 0x15E1EC0 Offset: 0x15E04C0 VA: 0x1815E1EC0
	|-GenericsUtil.CastImpl<ushort, sbyte>..cctor
	|
	|-RVA: 0x15E2BE0 Offset: 0x15E11E0 VA: 0x1815E2BE0
	|-GenericsUtil.CastImpl<ushort, float>..cctor
	|
	|-RVA: 0x15DD5A0 Offset: 0x15DBBA0 VA: 0x1815DD5A0
	|-GenericsUtil.CastImpl<ushort, uint>..cctor
	|
	|-RVA: 0x15DFA30 Offset: 0x15DE030 VA: 0x1815DFA30
	|-GenericsUtil.CastImpl<ushort, ulong>..cctor
	|
	|-RVA: 0x15DF760 Offset: 0x15DDD60 VA: 0x1815DF760
	|-GenericsUtil.CastImpl<ushort, Color>..cctor
	|
	|-RVA: 0x15E4080 Offset: 0x15E2680 VA: 0x1815E4080
	|-GenericsUtil.CastImpl<ushort, Ray>..cctor
	|
	|-RVA: 0x15E1A10 Offset: 0x15E0010 VA: 0x1815E1A10
	|-GenericsUtil.CastImpl<ushort, Vector3>..cctor
	|
	|-RVA: 0x15DCF10 Offset: 0x15DB510 VA: 0x1815DCF10
	|-GenericsUtil.CastImpl<uint, bool>..cctor
	|
	|-RVA: 0x17EEB10 Offset: 0x17ED110 VA: 0x1817EEB10
	|-GenericsUtil.CastImpl<uint, byte>..cctor
	|
	|-RVA: 0x17EEA20 Offset: 0x17ED020 VA: 0x1817EEA20
	|-GenericsUtil.CastImpl<uint, short>..cctor
	|
	|-RVA: 0x17F0820 Offset: 0x17EEE20 VA: 0x1817F0820
	|-GenericsUtil.CastImpl<uint, int>..cctor
	|
	|-RVA: 0x17EEDE0 Offset: 0x17ED3E0 VA: 0x1817EEDE0
	|-GenericsUtil.CastImpl<uint, long>..cctor
	|
	|-RVA: 0x17EE0C0 Offset: 0x17EC6C0 VA: 0x1817EE0C0
	|-GenericsUtil.CastImpl<uint, object>..cctor
	|
	|-RVA: 0x17EF560 Offset: 0x17EDB60 VA: 0x1817EF560
	|-GenericsUtil.CastImpl<uint, sbyte>..cctor
	|
	|-RVA: 0x17EF380 Offset: 0x17ED980 VA: 0x1817EF380
	|-GenericsUtil.CastImpl<uint, float>..cctor
	|
	|-RVA: 0x17EFDD0 Offset: 0x17EE3D0 VA: 0x1817EFDD0
	|-GenericsUtil.CastImpl<uint, ushort>..cctor
	|
	|-RVA: 0x17F0A00 Offset: 0x17EF000 VA: 0x1817F0A00
	|-GenericsUtil.CastImpl<uint, uint>..cctor
	|
	|-RVA: 0x17EFFB0 Offset: 0x17EE5B0 VA: 0x1817EFFB0
	|-GenericsUtil.CastImpl<uint, ulong>..cctor
	|
	|-RVA: 0x17EE840 Offset: 0x17ECE40 VA: 0x1817EE840
	|-GenericsUtil.CastImpl<uint, Color>..cctor
	|
	|-RVA: 0x17F0460 Offset: 0x17EEA60 VA: 0x1817F0460
	|-GenericsUtil.CastImpl<uint, Ray>..cctor
	|
	|-RVA: 0x17EFA10 Offset: 0x17EE010 VA: 0x1817EFA10
	|-GenericsUtil.CastImpl<uint, Vector3>..cctor
	|
	|-RVA: 0x17F0CD0 Offset: 0x17EF2D0 VA: 0x1817F0CD0
	|-GenericsUtil.CastImpl<ulong, bool>..cctor
	|
	|-RVA: 0x17EEC00 Offset: 0x17ED200 VA: 0x1817EEC00
	|-GenericsUtil.CastImpl<ulong, byte>..cctor
	|
	|-RVA: 0x17EEFC0 Offset: 0x17ED5C0 VA: 0x1817EEFC0
	|-GenericsUtil.CastImpl<ulong, short>..cctor
	|
	|-RVA: 0x17F0BE0 Offset: 0x17EF1E0 VA: 0x1817F0BE0
	|-GenericsUtil.CastImpl<ulong, int>..cctor
	|
	|-RVA: 0x17F00A0 Offset: 0x17EE6A0 VA: 0x1817F00A0
	|-GenericsUtil.CastImpl<ulong, long>..cctor
	|
	|-RVA: 0x17EE1B0 Offset: 0x17EC7B0 VA: 0x1817EE1B0
	|-GenericsUtil.CastImpl<ulong, object>..cctor
	|
	|-RVA: 0x17EE570 Offset: 0x17ECB70 VA: 0x1817EE570
	|-GenericsUtil.CastImpl<ulong, sbyte>..cctor
	|
	|-RVA: 0x17F0280 Offset: 0x17EE880 VA: 0x1817F0280
	|-GenericsUtil.CastImpl<ulong, float>..cctor
	|
	|-RVA: 0x17EECF0 Offset: 0x17ED2F0 VA: 0x1817EECF0
	|-GenericsUtil.CastImpl<ulong, ushort>..cctor
	|
	|-RVA: 0x17F1270 Offset: 0x17EF870 VA: 0x1817F1270
	|-GenericsUtil.CastImpl<ulong, uint>..cctor
	|
	|-RVA: 0x17EF920 Offset: 0x17EDF20 VA: 0x1817EF920
	|-GenericsUtil.CastImpl<ulong, ulong>..cctor
	|
	|-RVA: 0x17F1450 Offset: 0x17EFA50 VA: 0x1817F1450
	|-GenericsUtil.CastImpl<ulong, Color>..cctor
	|
	|-RVA: 0x17EF740 Offset: 0x17EDD40 VA: 0x1817EF740
	|-GenericsUtil.CastImpl<ulong, Ray>..cctor
	|
	|-RVA: 0x17EF1A0 Offset: 0x17ED7A0 VA: 0x1817EF1A0
	|-GenericsUtil.CastImpl<ulong, Vector3>..cctor
	|
	|-RVA: 0x17EFBF0 Offset: 0x17EE1F0 VA: 0x1817EFBF0
	|-GenericsUtil.CastImpl<Color, bool>..cctor
	|
	|-RVA: 0x17F0FA0 Offset: 0x17EF5A0 VA: 0x1817F0FA0
	|-GenericsUtil.CastImpl<Color, byte>..cctor
	|
	|-RVA: 0x17F0370 Offset: 0x17EE970 VA: 0x1817F0370
	|-GenericsUtil.CastImpl<Color, short>..cctor
	|
	|-RVA: 0x17EE750 Offset: 0x17ECD50 VA: 0x1817EE750
	|-GenericsUtil.CastImpl<Color, int>..cctor
	|
	|-RVA: 0x17F1720 Offset: 0x17EFD20 VA: 0x1817F1720
	|-GenericsUtil.CastImpl<Color, long>..cctor
	|
	|-RVA: 0x17ED940 Offset: 0x17EBF40 VA: 0x1817ED940
	|-GenericsUtil.CastImpl<Color, object>..cctor
	|
	|-RVA: 0x17F0640 Offset: 0x17EEC40 VA: 0x1817F0640
	|-GenericsUtil.CastImpl<Color, sbyte>..cctor
	|
	|-RVA: 0x17F1630 Offset: 0x17EFC30 VA: 0x1817F1630
	|-GenericsUtil.CastImpl<Color, float>..cctor
	|
	|-RVA: 0x17F1090 Offset: 0x17EF690 VA: 0x1817F1090
	|-GenericsUtil.CastImpl<Color, ushort>..cctor
	|
	|-RVA: 0x17EE480 Offset: 0x17ECA80 VA: 0x1817EE480
	|-GenericsUtil.CastImpl<Color, uint>..cctor
	|
	|-RVA: 0x17F0910 Offset: 0x17EEF10 VA: 0x1817F0910
	|-GenericsUtil.CastImpl<Color, ulong>..cctor
	|
	|-RVA: 0x17F1360 Offset: 0x17EF960 VA: 0x1817F1360
	|-GenericsUtil.CastImpl<Color, Color>..cctor
	|
	|-RVA: 0x17EFCE0 Offset: 0x17EE2E0 VA: 0x1817EFCE0
	|-GenericsUtil.CastImpl<Color, Ray>..cctor
	|
	|-RVA: 0x17EF470 Offset: 0x17EDA70 VA: 0x1817EF470
	|-GenericsUtil.CastImpl<Color, Vector3>..cctor
	|
	|-RVA: 0x17F0550 Offset: 0x17EEB50 VA: 0x1817F0550
	|-GenericsUtil.CastImpl<Ray, bool>..cctor
	|
	|-RVA: 0x17EDFD0 Offset: 0x17EC5D0 VA: 0x1817EDFD0
	|-GenericsUtil.CastImpl<Ray, byte>..cctor
	|
	|-RVA: 0x17EDD00 Offset: 0x17EC300 VA: 0x1817EDD00
	|-GenericsUtil.CastImpl<Ray, short>..cctor
	|
	|-RVA: 0x17EDB20 Offset: 0x17EC120 VA: 0x1817EDB20
	|-GenericsUtil.CastImpl<Ray, int>..cctor
	|
	|-RVA: 0x17F0730 Offset: 0x17EED30 VA: 0x1817F0730
	|-GenericsUtil.CastImpl<Ray, long>..cctor
	|
	|-RVA: 0x17F0AF0 Offset: 0x17EF0F0 VA: 0x1817F0AF0
	|-GenericsUtil.CastImpl<Ray, object>..cctor
	|
	|-RVA: 0x17F0DC0 Offset: 0x17EF3C0 VA: 0x1817F0DC0
	|-GenericsUtil.CastImpl<Ray, sbyte>..cctor
	|
	|-RVA: 0x17EF650 Offset: 0x17EDC50 VA: 0x1817EF650
	|-GenericsUtil.CastImpl<Ray, float>..cctor
	|
	|-RVA: 0x17F0EB0 Offset: 0x17EF4B0 VA: 0x1817F0EB0
	|-GenericsUtil.CastImpl<Ray, ushort>..cctor
	|
	|-RVA: 0x17EE2A0 Offset: 0x17EC8A0 VA: 0x1817EE2A0
	|-GenericsUtil.CastImpl<Ray, uint>..cctor
	|
	|-RVA: 0x17EF0B0 Offset: 0x17ED6B0 VA: 0x1817EF0B0
	|-GenericsUtil.CastImpl<Ray, ulong>..cctor
	|
	|-RVA: 0x17EDEE0 Offset: 0x17EC4E0 VA: 0x1817EDEE0
	|-GenericsUtil.CastImpl<Ray, Color>..cctor
	|
	|-RVA: 0x17EEED0 Offset: 0x17ED4D0 VA: 0x1817EEED0
	|-GenericsUtil.CastImpl<Ray, Ray>..cctor
	|
	|-RVA: 0x17EF290 Offset: 0x17ED890 VA: 0x1817EF290
	|-GenericsUtil.CastImpl<Ray, Vector3>..cctor
	|
	|-RVA: 0x17EDDF0 Offset: 0x17EC3F0 VA: 0x1817EDDF0
	|-GenericsUtil.CastImpl<Vector3, bool>..cctor
	|
	|-RVA: 0x17EFEC0 Offset: 0x17EE4C0 VA: 0x1817EFEC0
	|-GenericsUtil.CastImpl<Vector3, byte>..cctor
	|
	|-RVA: 0x17EFB00 Offset: 0x17EE100 VA: 0x1817EFB00
	|-GenericsUtil.CastImpl<Vector3, short>..cctor
	|
	|-RVA: 0x17EF830 Offset: 0x17EDE30 VA: 0x1817EF830
	|-GenericsUtil.CastImpl<Vector3, int>..cctor
	|
	|-RVA: 0x17EE930 Offset: 0x17ECF30 VA: 0x1817EE930
	|-GenericsUtil.CastImpl<Vector3, long>..cctor
	|
	|-RVA: 0x17ED760 Offset: 0x17EBD60 VA: 0x1817ED760
	|-GenericsUtil.CastImpl<Vector3, object>..cctor
	|
	|-RVA: 0x17ED850 Offset: 0x17EBE50 VA: 0x1817ED850
	|-GenericsUtil.CastImpl<Vector3, sbyte>..cctor
	|
	|-RVA: 0x17F0190 Offset: 0x17EE790 VA: 0x1817F0190
	|-GenericsUtil.CastImpl<Vector3, float>..cctor
	|
	|-RVA: 0x17EDA30 Offset: 0x17EC030 VA: 0x1817EDA30
	|-GenericsUtil.CastImpl<Vector3, ushort>..cctor
	|
	|-RVA: 0x17EE390 Offset: 0x17EC990 VA: 0x1817EE390
	|-GenericsUtil.CastImpl<Vector3, uint>..cctor
	|
	|-RVA: 0x17F1540 Offset: 0x17EFB40 VA: 0x1817F1540
	|-GenericsUtil.CastImpl<Vector3, ulong>..cctor
	|
	|-RVA: 0x17F1180 Offset: 0x17EF780 VA: 0x1817F1180
	|-GenericsUtil.CastImpl<Vector3, Color>..cctor
	|
	|-RVA: 0x17EDC10 Offset: 0x17EC210 VA: 0x1817EDC10
	|-GenericsUtil.CastImpl<Vector3, Ray>..cctor
	|
	|-RVA: 0x17EE660 Offset: 0x17ECC60 VA: 0x1817EE660
	|-GenericsUtil.CastImpl<Vector3, Vector3>..cctor
	*/

}

