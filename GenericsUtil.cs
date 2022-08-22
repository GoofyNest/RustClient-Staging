public static class GenericsUtil // TypeDefIndex: 4817
{	// Methods

	// RVA: -1 Offset: -1
	public static TDst Cast<TSrc, TDst>(TSrc obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A3240 Offset: 0x15A1840 VA: 0x1815A3240
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
	|-RVA: 0x15A34D0 Offset: 0x15A1AD0 VA: 0x1815A34D0
	|-GenericsUtil.Cast<bool, short>
	|-GenericsUtil.Cast<bool, ushort>
	|-GenericsUtil.Cast<byte, short>
	|-GenericsUtil.Cast<byte, ushort>
	|-GenericsUtil.Cast<sbyte, short>
	|-GenericsUtil.Cast<sbyte, ushort>
	|
	|-RVA: 0x15A3610 Offset: 0x15A1C10 VA: 0x1815A3610
	|-GenericsUtil.Cast<bool, int>
	|-GenericsUtil.Cast<bool, uint>
	|-GenericsUtil.Cast<byte, int>
	|-GenericsUtil.Cast<byte, uint>
	|-GenericsUtil.Cast<sbyte, int>
	|-GenericsUtil.Cast<sbyte, uint>
	|
	|-RVA: 0x15A3750 Offset: 0x15A1D50 VA: 0x1815A3750
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
	|-RVA: 0x15A39E0 Offset: 0x15A1FE0 VA: 0x1815A39E0
	|-GenericsUtil.Cast<bool, float>
	|-GenericsUtil.Cast<byte, float>
	|-GenericsUtil.Cast<sbyte, float>
	|
	|-RVA: 0x15A3380 Offset: 0x15A1980 VA: 0x1815A3380
	|-GenericsUtil.Cast<bool, Color>
	|-GenericsUtil.Cast<byte, Color>
	|-GenericsUtil.Cast<sbyte, Color>
	|
	|-RVA: 0x15A3890 Offset: 0x15A1E90 VA: 0x1815A3890
	|-GenericsUtil.Cast<bool, Ray>
	|-GenericsUtil.Cast<byte, Ray>
	|-GenericsUtil.Cast<sbyte, Ray>
	|
	|-RVA: 0x15A3B20 Offset: 0x15A2120 VA: 0x1815A3B20
	|-GenericsUtil.Cast<bool, Vector3>
	|-GenericsUtil.Cast<byte, Vector3>
	|-GenericsUtil.Cast<sbyte, Vector3>
	|
	|-RVA: 0x15A4040 Offset: 0x15A2640 VA: 0x1815A4040
	|-GenericsUtil.Cast<Guid, int>
	|-GenericsUtil.Cast<Color, int>
	|-GenericsUtil.Cast<Color, uint>
	|
	|-RVA: 0x15A4180 Offset: 0x15A2780 VA: 0x1815A4180
	|-GenericsUtil.Cast<Guid, long>
	|-GenericsUtil.Cast<Guid, object>
	|-GenericsUtil.Cast<Color, long>
	|-GenericsUtil.Cast<Color, object>
	|-GenericsUtil.Cast<Color, ulong>
	|
	|-RVA: 0x15A46C0 Offset: 0x15A2CC0 VA: 0x1815A46C0
	|-GenericsUtil.Cast<int, bool>
	|-GenericsUtil.Cast<int, byte>
	|-GenericsUtil.Cast<int, sbyte>
	|-GenericsUtil.Cast<uint, bool>
	|-GenericsUtil.Cast<uint, byte>
	|-GenericsUtil.Cast<uint, sbyte>
	|
	|-RVA: 0x15A4950 Offset: 0x15A2F50 VA: 0x1815A4950
	|-GenericsUtil.Cast<int, double>
	|
	|-RVA: 0x15A4800 Offset: 0x15A2E00 VA: 0x1815A4800
	|-GenericsUtil.Cast<int, Guid>
	|-GenericsUtil.Cast<int, Color>
	|-GenericsUtil.Cast<uint, Color>
	|
	|-RVA: 0x15A4A90 Offset: 0x15A3090 VA: 0x1815A4A90
	|-GenericsUtil.Cast<int, short>
	|-GenericsUtil.Cast<int, ushort>
	|-GenericsUtil.Cast<uint, short>
	|-GenericsUtil.Cast<uint, ushort>
	|
	|-RVA: 0x15A4BD0 Offset: 0x15A31D0 VA: 0x1815A4BD0
	|-GenericsUtil.Cast<int, int>
	|-GenericsUtil.Cast<int, uint>
	|-GenericsUtil.Cast<uint, int>
	|-GenericsUtil.Cast<uint, uint>
	|
	|-RVA: 0x15A4D00 Offset: 0x15A3300 VA: 0x1815A4D00
	|-GenericsUtil.Cast<int, long>
	|-GenericsUtil.Cast<int, object>
	|-GenericsUtil.Cast<int, ulong>
	|-GenericsUtil.Cast<uint, long>
	|-GenericsUtil.Cast<uint, object>
	|-GenericsUtil.Cast<uint, ulong>
	|
	|-RVA: 0x15A4F90 Offset: 0x15A3590 VA: 0x1815A4F90
	|-GenericsUtil.Cast<int, float>
	|-GenericsUtil.Cast<uint, float>
	|
	|-RVA: 0x15A4E40 Offset: 0x15A3440 VA: 0x1815A4E40
	|-GenericsUtil.Cast<int, Ray>
	|-GenericsUtil.Cast<uint, Ray>
	|
	|-RVA: 0x15A50D0 Offset: 0x15A36D0 VA: 0x1815A50D0
	|-GenericsUtil.Cast<int, Vector3>
	|-GenericsUtil.Cast<uint, Vector3>
	|
	|-RVA: 0x15A5220 Offset: 0x15A3820 VA: 0x1815A5220
	|-GenericsUtil.Cast<long, int>
	|-GenericsUtil.Cast<ulong, int>
	|-GenericsUtil.Cast<ulong, uint>
	|
	|-RVA: 0x15A5360 Offset: 0x15A3960 VA: 0x1815A5360
	|-GenericsUtil.Cast<long, long>
	|-GenericsUtil.Cast<long, object>
	|-GenericsUtil.Cast<ulong, long>
	|-GenericsUtil.Cast<ulong, object>
	|-GenericsUtil.Cast<ulong, ulong>
	|
	|-RVA: 0x15A5F10 Offset: 0x15A4510 VA: 0x1815A5F10
	|-GenericsUtil.Cast<object, bool>
	|-GenericsUtil.Cast<object, byte>
	|-GenericsUtil.Cast<object, sbyte>
	|
	|-RVA: 0x15A61B0 Offset: 0x15A47B0 VA: 0x1815A61B0
	|-GenericsUtil.Cast<object, double>
	|
	|-RVA: 0x15A6050 Offset: 0x15A4650 VA: 0x1815A6050
	|-GenericsUtil.Cast<object, Guid>
	|-GenericsUtil.Cast<object, Color>
	|
	|-RVA: 0x15A62F0 Offset: 0x15A48F0 VA: 0x1815A62F0
	|-GenericsUtil.Cast<object, short>
	|-GenericsUtil.Cast<object, ushort>
	|
	|-RVA: 0x15A6430 Offset: 0x15A4A30 VA: 0x1815A6430
	|-GenericsUtil.Cast<object, int>
	|-GenericsUtil.Cast<object, uint>
	|
	|-RVA: 0x15A6570 Offset: 0x15A4B70 VA: 0x1815A6570
	|-GenericsUtil.Cast<object, long>
	|-GenericsUtil.Cast<object, object>
	|-GenericsUtil.Cast<object, ulong>
	|
	|-RVA: 0x15A6810 Offset: 0x15A4E10 VA: 0x1815A6810
	|-GenericsUtil.Cast<object, float>
	|
	|-RVA: 0x15A66B0 Offset: 0x15A4CB0 VA: 0x1815A66B0
	|-GenericsUtil.Cast<object, Ray>
	|
	|-RVA: 0x15A6950 Offset: 0x15A4F50 VA: 0x1815A6950
	|-GenericsUtil.Cast<object, Vector3>
	|
	|-RVA: 0x15A6AB0 Offset: 0x15A50B0 VA: 0x1815A6AB0
	|-GenericsUtil.Cast<float, bool>
	|-GenericsUtil.Cast<float, byte>
	|-GenericsUtil.Cast<float, sbyte>
	|
	|-RVA: 0x15A6D40 Offset: 0x15A5340 VA: 0x1815A6D40
	|-GenericsUtil.Cast<float, short>
	|-GenericsUtil.Cast<float, ushort>
	|
	|-RVA: 0x15A6E80 Offset: 0x15A5480 VA: 0x1815A6E80
	|-GenericsUtil.Cast<float, int>
	|-GenericsUtil.Cast<float, uint>
	|
	|-RVA: 0x15A6FC0 Offset: 0x15A55C0 VA: 0x1815A6FC0
	|-GenericsUtil.Cast<float, long>
	|-GenericsUtil.Cast<float, object>
	|-GenericsUtil.Cast<float, ulong>
	|
	|-RVA: 0x15A7260 Offset: 0x15A5860 VA: 0x1815A7260
	|-GenericsUtil.Cast<float, float>
	|
	|-RVA: 0x15A6BF0 Offset: 0x15A51F0 VA: 0x1815A6BF0
	|-GenericsUtil.Cast<float, Color>
	|
	|-RVA: 0x15A7100 Offset: 0x15A5700 VA: 0x1815A7100
	|-GenericsUtil.Cast<float, Ray>
	|
	|-RVA: 0x15A73A0 Offset: 0x15A59A0 VA: 0x1815A73A0
	|-GenericsUtil.Cast<float, Vector3>
	|
	|-RVA: 0x15A74F0 Offset: 0x15A5AF0 VA: 0x1815A74F0
	|-GenericsUtil.Cast<ulong, bool>
	|-GenericsUtil.Cast<ulong, byte>
	|-GenericsUtil.Cast<ulong, sbyte>
	|
	|-RVA: 0x15A7780 Offset: 0x15A5D80 VA: 0x1815A7780
	|-GenericsUtil.Cast<ulong, short>
	|-GenericsUtil.Cast<ulong, ushort>
	|
	|-RVA: 0x15A7A10 Offset: 0x15A6010 VA: 0x1815A7A10
	|-GenericsUtil.Cast<ulong, float>
	|
	|-RVA: 0x15A7630 Offset: 0x15A5C30 VA: 0x1815A7630
	|-GenericsUtil.Cast<ulong, Color>
	|
	|-RVA: 0x15A78C0 Offset: 0x15A5EC0 VA: 0x1815A78C0
	|-GenericsUtil.Cast<ulong, Ray>
	|
	|-RVA: 0x15A7B50 Offset: 0x15A6150 VA: 0x1815A7B50
	|-GenericsUtil.Cast<ulong, Vector3>
	|
	|-RVA: 0x15A3C70 Offset: 0x15A2270 VA: 0x1815A3C70
	|-GenericsUtil.Cast<Color, bool>
	|-GenericsUtil.Cast<Color, byte>
	|-GenericsUtil.Cast<Color, sbyte>
	|
	|-RVA: 0x15A3F00 Offset: 0x15A2500 VA: 0x1815A3F00
	|-GenericsUtil.Cast<Color, short>
	|-GenericsUtil.Cast<Color, ushort>
	|
	|-RVA: 0x15A4420 Offset: 0x15A2A20 VA: 0x1815A4420
	|-GenericsUtil.Cast<Color, float>
	|
	|-RVA: 0x15A3DB0 Offset: 0x15A23B0 VA: 0x1815A3DB0
	|-GenericsUtil.Cast<Color, Color>
	|
	|-RVA: 0x15A42C0 Offset: 0x15A28C0 VA: 0x1815A42C0
	|-GenericsUtil.Cast<Color, Ray>
	|
	|-RVA: 0x15A4560 Offset: 0x15A2B60 VA: 0x1815A4560
	|-GenericsUtil.Cast<Color, Vector3>
	|
	|-RVA: 0x15A54A0 Offset: 0x15A3AA0 VA: 0x1815A54A0
	|-GenericsUtil.Cast<Ray, bool>
	|-GenericsUtil.Cast<Ray, byte>
	|-GenericsUtil.Cast<Ray, sbyte>
	|
	|-RVA: 0x15A5740 Offset: 0x15A3D40 VA: 0x1815A5740
	|-GenericsUtil.Cast<Ray, short>
	|-GenericsUtil.Cast<Ray, ushort>
	|
	|-RVA: 0x15A5880 Offset: 0x15A3E80 VA: 0x1815A5880
	|-GenericsUtil.Cast<Ray, int>
	|-GenericsUtil.Cast<Ray, uint>
	|
	|-RVA: 0x15A59C0 Offset: 0x15A3FC0 VA: 0x1815A59C0
	|-GenericsUtil.Cast<Ray, long>
	|-GenericsUtil.Cast<Ray, object>
	|-GenericsUtil.Cast<Ray, ulong>
	|
	|-RVA: 0x15A5C60 Offset: 0x15A4260 VA: 0x1815A5C60
	|-GenericsUtil.Cast<Ray, float>
	|
	|-RVA: 0x15A55E0 Offset: 0x15A3BE0 VA: 0x1815A55E0
	|-GenericsUtil.Cast<Ray, Color>
	|
	|-RVA: 0x15A5B00 Offset: 0x15A4100 VA: 0x1815A5B00
	|-GenericsUtil.Cast<Ray, Ray>
	|
	|-RVA: 0x15A5DB0 Offset: 0x15A43B0 VA: 0x1815A5DB0
	|-GenericsUtil.Cast<Ray, Vector3>
	|
	|-RVA: 0x15A7CA0 Offset: 0x15A62A0 VA: 0x1815A7CA0
	|-GenericsUtil.Cast<Vector3, bool>
	|-GenericsUtil.Cast<Vector3, byte>
	|-GenericsUtil.Cast<Vector3, sbyte>
	|
	|-RVA: 0x15A7F40 Offset: 0x15A6540 VA: 0x1815A7F40
	|-GenericsUtil.Cast<Vector3, short>
	|-GenericsUtil.Cast<Vector3, ushort>
	|
	|-RVA: 0x15A8080 Offset: 0x15A6680 VA: 0x1815A8080
	|-GenericsUtil.Cast<Vector3, int>
	|-GenericsUtil.Cast<Vector3, uint>
	|
	|-RVA: 0x15A81C0 Offset: 0x15A67C0 VA: 0x1815A81C0
	|-GenericsUtil.Cast<Vector3, long>
	|-GenericsUtil.Cast<Vector3, object>
	|-GenericsUtil.Cast<Vector3, ulong>
	|
	|-RVA: 0x15A8460 Offset: 0x15A6A60 VA: 0x1815A8460
	|-GenericsUtil.Cast<Vector3, float>
	|
	|-RVA: 0x15A7DE0 Offset: 0x15A63E0 VA: 0x1815A7DE0
	|-GenericsUtil.Cast<Vector3, Color>
	|
	|-RVA: 0x15A8300 Offset: 0x15A6900 VA: 0x1815A8300
	|-GenericsUtil.Cast<Vector3, Ray>
	|
	|-RVA: 0x15A85A0 Offset: 0x15A6BA0 VA: 0x1815A85A0
	|-GenericsUtil.Cast<Vector3, Vector3>
	*/

	// RVA: -1 Offset: -1
	public static void Swap<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x570E80 Offset: 0x56F480 VA: 0x180570E80
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
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSrc Value; // 0xFFFFFFFF

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1890470 Offset: 0x188EA70 VA: 0x181890470
	|-GenericsUtil.CastImpl<bool, bool>..cctor
	|
	|-RVA: 0x188A5C0 Offset: 0x1888BC0 VA: 0x18188A5C0
	|-GenericsUtil.CastImpl<bool, byte>..cctor
	|
	|-RVA: 0x188FCF0 Offset: 0x188E2F0 VA: 0x18188FCF0
	|-GenericsUtil.CastImpl<bool, short>..cctor
	|
	|-RVA: 0x18893F0 Offset: 0x18879F0 VA: 0x1818893F0
	|-GenericsUtil.CastImpl<bool, int>..cctor
	|
	|-RVA: 0x1889990 Offset: 0x1887F90 VA: 0x181889990
	|-GenericsUtil.CastImpl<bool, long>..cctor
	|
	|-RVA: 0x188AA70 Offset: 0x1889070 VA: 0x18188AA70
	|-GenericsUtil.CastImpl<bool, object>..cctor
	|
	|-RVA: 0x1890BF0 Offset: 0x188F1F0 VA: 0x181890BF0
	|-GenericsUtil.CastImpl<bool, sbyte>..cctor
	|
	|-RVA: 0x1891640 Offset: 0x188FC40 VA: 0x181891640
	|-GenericsUtil.CastImpl<bool, float>..cctor
	|
	|-RVA: 0x188CFF0 Offset: 0x188B5F0 VA: 0x18188CFF0
	|-GenericsUtil.CastImpl<bool, ushort>..cctor
	|
	|-RVA: 0x1889F30 Offset: 0x1888530 VA: 0x181889F30
	|-GenericsUtil.CastImpl<bool, uint>..cctor
	|
	|-RVA: 0x1890560 Offset: 0x188EB60 VA: 0x181890560
	|-GenericsUtil.CastImpl<bool, ulong>..cctor
	|
	|-RVA: 0x188B010 Offset: 0x1889610 VA: 0x18188B010
	|-GenericsUtil.CastImpl<bool, Color>..cctor
	|
	|-RVA: 0x188B880 Offset: 0x1889E80 VA: 0x18188B880
	|-GenericsUtil.CastImpl<bool, Ray>..cctor
	|
	|-RVA: 0x1889A80 Offset: 0x1888080 VA: 0x181889A80
	|-GenericsUtil.CastImpl<bool, Vector3>..cctor
	|
	|-RVA: 0x188C3C0 Offset: 0x188A9C0 VA: 0x18188C3C0
	|-GenericsUtil.CastImpl<byte, bool>..cctor
	|
	|-RVA: 0x188AD40 Offset: 0x1889340 VA: 0x18188AD40
	|-GenericsUtil.CastImpl<byte, byte>..cctor
	|
	|-RVA: 0x1891550 Offset: 0x188FB50 VA: 0x181891550
	|-GenericsUtil.CastImpl<byte, short>..cctor
	|
	|-RVA: 0x188B4C0 Offset: 0x1889AC0 VA: 0x18188B4C0
	|-GenericsUtil.CastImpl<byte, int>..cctor
	|
	|-RVA: 0x188E760 Offset: 0x188CD60 VA: 0x18188E760
	|-GenericsUtil.CastImpl<byte, long>..cctor
	|
	|-RVA: 0x188E2B0 Offset: 0x188C8B0 VA: 0x18188E2B0
	|-GenericsUtil.CastImpl<byte, object>..cctor
	|
	|-RVA: 0x1889300 Offset: 0x1887900 VA: 0x181889300
	|-GenericsUtil.CastImpl<byte, sbyte>..cctor
	|
	|-RVA: 0x188B100 Offset: 0x1889700 VA: 0x18188B100
	|-GenericsUtil.CastImpl<byte, float>..cctor
	|
	|-RVA: 0x188F2A0 Offset: 0x188D8A0 VA: 0x18188F2A0
	|-GenericsUtil.CastImpl<byte, ushort>..cctor
	|
	|-RVA: 0x188A2F0 Offset: 0x18888F0 VA: 0x18188A2F0
	|-GenericsUtil.CastImpl<byte, uint>..cctor
	|
	|-RVA: 0x1889B70 Offset: 0x1888170 VA: 0x181889B70
	|-GenericsUtil.CastImpl<byte, ulong>..cctor
	|
	|-RVA: 0x188CC30 Offset: 0x188B230 VA: 0x18188CC30
	|-GenericsUtil.CastImpl<byte, Color>..cctor
	|
	|-RVA: 0x18894E0 Offset: 0x1887AE0 VA: 0x1818894E0
	|-GenericsUtil.CastImpl<byte, Ray>..cctor
	|
	|-RVA: 0x188D590 Offset: 0x188BB90 VA: 0x18188D590
	|-GenericsUtil.CastImpl<byte, Vector3>..cctor
	|
	|-RVA: 0x188EFD0 Offset: 0x188D5D0 VA: 0x18188EFD0
	|-GenericsUtil.CastImpl<double, int>..cctor
	|
	|-RVA: 0x1890650 Offset: 0x188EC50 VA: 0x181890650
	|-GenericsUtil.CastImpl<double, object>..cctor
	|
	|-RVA: 0x188DC20 Offset: 0x188C220 VA: 0x18188DC20
	|-GenericsUtil.CastImpl<Guid, int>..cctor
	|
	|-RVA: 0x188BC40 Offset: 0x188A240 VA: 0x18188BC40
	|-GenericsUtil.CastImpl<Guid, long>..cctor
	|
	|-RVA: 0x188A020 Offset: 0x1888620 VA: 0x18188A020
	|-GenericsUtil.CastImpl<Guid, object>..cctor
	|
	|-RVA: 0x1891370 Offset: 0x188F970 VA: 0x181891370
	|-GenericsUtil.CastImpl<short, bool>..cctor
	|
	|-RVA: 0x188D0E0 Offset: 0x188B6E0 VA: 0x18188D0E0
	|-GenericsUtil.CastImpl<short, byte>..cctor
	|
	|-RVA: 0x188B2E0 Offset: 0x18898E0 VA: 0x18188B2E0
	|-GenericsUtil.CastImpl<short, int>..cctor
	|
	|-RVA: 0x188BB50 Offset: 0x188A150 VA: 0x18188BB50
	|-GenericsUtil.CastImpl<short, object>..cctor
	|
	|-RVA: 0x188F480 Offset: 0x188DA80 VA: 0x18188F480
	|-GenericsUtil.CastImpl<short, sbyte>..cctor
	|
	|-RVA: 0x188EA30 Offset: 0x188D030 VA: 0x18188EA30
	|-GenericsUtil.CastImpl<short, float>..cctor
	|
	|-RVA: 0x188EB20 Offset: 0x188D120 VA: 0x18188EB20
	|-GenericsUtil.CastImpl<short, uint>..cctor
	|
	|-RVA: 0x188EEE0 Offset: 0x188D4E0 VA: 0x18188EEE0
	|-GenericsUtil.CastImpl<short, ulong>..cctor
	|
	|-RVA: 0x188BD30 Offset: 0x188A330 VA: 0x18188BD30
	|-GenericsUtil.CastImpl<short, Color>..cctor
	|
	|-RVA: 0x188F660 Offset: 0x188DC60 VA: 0x18188F660
	|-GenericsUtil.CastImpl<short, Ray>..cctor
	|
	|-RVA: 0x188AC50 Offset: 0x1889250 VA: 0x18188AC50
	|-GenericsUtil.CastImpl<short, Vector3>..cctor
	|
	|-RVA: 0x188FC00 Offset: 0x188E200 VA: 0x18188FC00
	|-GenericsUtil.CastImpl<int, bool>..cctor
	|
	|-RVA: 0x1890920 Offset: 0x188EF20 VA: 0x181890920
	|-GenericsUtil.CastImpl<int, byte>..cctor
	|
	|-RVA: 0x188BF10 Offset: 0x188A510 VA: 0x18188BF10
	|-GenericsUtil.CastImpl<int, double>..cctor
	|
	|-RVA: 0x188E670 Offset: 0x188CC70 VA: 0x18188E670
	|-GenericsUtil.CastImpl<int, Guid>..cctor
	|
	|-RVA: 0x188E1C0 Offset: 0x188C7C0 VA: 0x18188E1C0
	|-GenericsUtil.CastImpl<int, short>..cctor
	|
	|-RVA: 0x188C4B0 Offset: 0x188AAB0 VA: 0x18188C4B0
	|-GenericsUtil.CastImpl<int, int>..cctor
	|
	|-RVA: 0x188DB30 Offset: 0x188C130 VA: 0x18188DB30
	|-GenericsUtil.CastImpl<int, long>..cctor
	|
	|-RVA: 0x188DA40 Offset: 0x188C040 VA: 0x18188DA40
	|-GenericsUtil.CastImpl<int, object>..cctor
	|
	|-RVA: 0x1890FB0 Offset: 0x188F5B0 VA: 0x181890FB0
	|-GenericsUtil.CastImpl<int, sbyte>..cctor
	|
	|-RVA: 0x1890CE0 Offset: 0x188F2E0 VA: 0x181890CE0
	|-GenericsUtil.CastImpl<int, float>..cctor
	|
	|-RVA: 0x188EC10 Offset: 0x188D210 VA: 0x18188EC10
	|-GenericsUtil.CastImpl<int, ushort>..cctor
	|
	|-RVA: 0x188CD20 Offset: 0x188B320 VA: 0x18188CD20
	|-GenericsUtil.CastImpl<int, uint>..cctor
	|
	|-RVA: 0x1890380 Offset: 0x188E980 VA: 0x181890380
	|-GenericsUtil.CastImpl<int, ulong>..cctor
	|
	|-RVA: 0x188C690 Offset: 0x188AC90 VA: 0x18188C690
	|-GenericsUtil.CastImpl<int, Color>..cctor
	|
	|-RVA: 0x188C960 Offset: 0x188AF60 VA: 0x18188C960
	|-GenericsUtil.CastImpl<int, Ray>..cctor
	|
	|-RVA: 0x188D770 Offset: 0x188BD70 VA: 0x18188D770
	|-GenericsUtil.CastImpl<int, Vector3>..cctor
	|
	|-RVA: 0x188C870 Offset: 0x188AE70 VA: 0x18188C870
	|-GenericsUtil.CastImpl<long, bool>..cctor
	|
	|-RVA: 0x188E580 Offset: 0x188CB80 VA: 0x18188E580
	|-GenericsUtil.CastImpl<long, byte>..cctor
	|
	|-RVA: 0x18900B0 Offset: 0x188E6B0 VA: 0x1818900B0
	|-GenericsUtil.CastImpl<long, Guid>..cctor
	|
	|-RVA: 0x188E850 Offset: 0x188CE50 VA: 0x18188E850
	|-GenericsUtil.CastImpl<long, int>..cctor
	|
	|-RVA: 0x1891190 Offset: 0x188F790 VA: 0x181891190
	|-GenericsUtil.CastImpl<long, long>..cctor
	|
	|-RVA: 0x1890EC0 Offset: 0x188F4C0 VA: 0x181890EC0
	|-GenericsUtil.CastImpl<long, object>..cctor
	|
	|-RVA: 0x188CA50 Offset: 0x188B050 VA: 0x18188CA50
	|-GenericsUtil.CastImpl<long, sbyte>..cctor
	|
	|-RVA: 0x188DFE0 Offset: 0x188C5E0 VA: 0x18188DFE0
	|-GenericsUtil.CastImpl<long, float>..cctor
	|
	|-RVA: 0x188C2D0 Offset: 0x188A8D0 VA: 0x18188C2D0
	|-GenericsUtil.CastImpl<long, uint>..cctor
	|
	|-RVA: 0x188FB10 Offset: 0x188E110 VA: 0x18188FB10
	|-GenericsUtil.CastImpl<long, ulong>..cctor
	|
	|-RVA: 0x188D2C0 Offset: 0x188B8C0 VA: 0x18188D2C0
	|-GenericsUtil.CastImpl<long, Color>..cctor
	|
	|-RVA: 0x188D950 Offset: 0x188BF50 VA: 0x18188D950
	|-GenericsUtil.CastImpl<long, Ray>..cctor
	|
	|-RVA: 0x1889E40 Offset: 0x1888440 VA: 0x181889E40
	|-GenericsUtil.CastImpl<long, Vector3>..cctor
	|
	|-RVA: 0x188ED00 Offset: 0x188D300 VA: 0x18188ED00
	|-GenericsUtil.CastImpl<object, bool>..cctor
	|
	|-RVA: 0x188A7A0 Offset: 0x1888DA0 VA: 0x18188A7A0
	|-GenericsUtil.CastImpl<object, byte>..cctor
	|
	|-RVA: 0x1890740 Offset: 0x188ED40 VA: 0x181890740
	|-GenericsUtil.CastImpl<object, double>..cctor
	|
	|-RVA: 0x188C000 Offset: 0x188A600 VA: 0x18188C000
	|-GenericsUtil.CastImpl<object, Guid>..cctor
	|
	|-RVA: 0x1890290 Offset: 0x188E890 VA: 0x181890290
	|-GenericsUtil.CastImpl<object, short>..cctor
	|
	|-RVA: 0x188D4A0 Offset: 0x188BAA0 VA: 0x18188D4A0
	|-GenericsUtil.CastImpl<object, int>..cctor
	|
	|-RVA: 0x188A4D0 Offset: 0x1888AD0 VA: 0x18188A4D0
	|-GenericsUtil.CastImpl<object, long>..cctor
	|
	|-RVA: 0x188F0C0 Offset: 0x188D6C0 VA: 0x18188F0C0
	|-GenericsUtil.CastImpl<object, object>..cctor
	|
	|-RVA: 0x188D3B0 Offset: 0x188B9B0 VA: 0x18188D3B0
	|-GenericsUtil.CastImpl<object, sbyte>..cctor
	|
	|-RVA: 0x188A110 Offset: 0x1888710 VA: 0x18188A110
	|-GenericsUtil.CastImpl<object, float>..cctor
	|
	|-RVA: 0x188FA20 Offset: 0x188E020 VA: 0x18188FA20
	|-GenericsUtil.CastImpl<object, ushort>..cctor
	|
	|-RVA: 0x1891460 Offset: 0x188FA60 VA: 0x181891460
	|-GenericsUtil.CastImpl<object, uint>..cctor
	|
	|-RVA: 0x188B1F0 Offset: 0x18897F0 VA: 0x18188B1F0
	|-GenericsUtil.CastImpl<object, ulong>..cctor
	|
	|-RVA: 0x18896C0 Offset: 0x1887CC0 VA: 0x1818896C0
	|-GenericsUtil.CastImpl<object, Color>..cctor
	|
	|-RVA: 0x188E0D0 Offset: 0x188C6D0 VA: 0x18188E0D0
	|-GenericsUtil.CastImpl<object, Ray>..cctor
	|
	|-RVA: 0x188B970 Offset: 0x1889F70 VA: 0x18188B970
	|-GenericsUtil.CastImpl<object, Vector3>..cctor
	|
	|-RVA: 0x1890DD0 Offset: 0x188F3D0 VA: 0x181890DD0
	|-GenericsUtil.CastImpl<sbyte, bool>..cctor
	|
	|-RVA: 0x188DE00 Offset: 0x188C400 VA: 0x18188DE00
	|-GenericsUtil.CastImpl<sbyte, byte>..cctor
	|
	|-RVA: 0x188A6B0 Offset: 0x1888CB0 VA: 0x18188A6B0
	|-GenericsUtil.CastImpl<sbyte, short>..cctor
	|
	|-RVA: 0x1889D50 Offset: 0x1888350 VA: 0x181889D50
	|-GenericsUtil.CastImpl<sbyte, int>..cctor
	|
	|-RVA: 0x1889C60 Offset: 0x1888260 VA: 0x181889C60
	|-GenericsUtil.CastImpl<sbyte, long>..cctor
	|
	|-RVA: 0x1890A10 Offset: 0x188F010 VA: 0x181890A10
	|-GenericsUtil.CastImpl<sbyte, object>..cctor
	|
	|-RVA: 0x188D1D0 Offset: 0x188B7D0 VA: 0x18188D1D0
	|-GenericsUtil.CastImpl<sbyte, sbyte>..cctor
	|
	|-RVA: 0x188D680 Offset: 0x188BC80 VA: 0x18188D680
	|-GenericsUtil.CastImpl<sbyte, float>..cctor
	|
	|-RVA: 0x188AB60 Offset: 0x1889160 VA: 0x18188AB60
	|-GenericsUtil.CastImpl<sbyte, ushort>..cctor
	|
	|-RVA: 0x188B5B0 Offset: 0x1889BB0 VA: 0x18188B5B0
	|-GenericsUtil.CastImpl<sbyte, uint>..cctor
	|
	|-RVA: 0x1891280 Offset: 0x188F880 VA: 0x181891280
	|-GenericsUtil.CastImpl<sbyte, ulong>..cctor
	|
	|-RVA: 0x188DD10 Offset: 0x188C310 VA: 0x18188DD10
	|-GenericsUtil.CastImpl<sbyte, Color>..cctor
	|
	|-RVA: 0x1891730 Offset: 0x188FD30 VA: 0x181891730
	|-GenericsUtil.CastImpl<sbyte, Ray>..cctor
	|
	|-RVA: 0x188B3D0 Offset: 0x18899D0 VA: 0x18188B3D0
	|-GenericsUtil.CastImpl<sbyte, Vector3>..cctor
	|
	|-RVA: 0x188AE30 Offset: 0x1889430 VA: 0x18188AE30
	|-GenericsUtil.CastImpl<float, bool>..cctor
	|
	|-RVA: 0x18895D0 Offset: 0x1887BD0 VA: 0x1818895D0
	|-GenericsUtil.CastImpl<float, byte>..cctor
	|
	|-RVA: 0x188C5A0 Offset: 0x188ABA0 VA: 0x18188C5A0
	|-GenericsUtil.CastImpl<float, short>..cctor
	|
	|-RVA: 0x188FED0 Offset: 0x188E4D0 VA: 0x18188FED0
	|-GenericsUtil.CastImpl<float, int>..cctor
	|
	|-RVA: 0x188F930 Offset: 0x188DF30 VA: 0x18188F930
	|-GenericsUtil.CastImpl<float, long>..cctor
	|
	|-RVA: 0x188A980 Offset: 0x1888F80 VA: 0x18188A980
	|-GenericsUtil.CastImpl<float, object>..cctor
	|
	|-RVA: 0x18897B0 Offset: 0x1887DB0 VA: 0x1818897B0
	|-GenericsUtil.CastImpl<float, sbyte>..cctor
	|
	|-RVA: 0x188CE10 Offset: 0x188B410 VA: 0x18188CE10
	|-GenericsUtil.CastImpl<float, float>..cctor
	|
	|-RVA: 0x188A890 Offset: 0x1888E90 VA: 0x18188A890
	|-GenericsUtil.CastImpl<float, ushort>..cctor
	|
	|-RVA: 0x188D860 Offset: 0x188BE60 VA: 0x18188D860
	|-GenericsUtil.CastImpl<float, uint>..cctor
	|
	|-RVA: 0x188BA60 Offset: 0x188A060 VA: 0x18188BA60
	|-GenericsUtil.CastImpl<float, ulong>..cctor
	|
	|-RVA: 0x188EDF0 Offset: 0x188D3F0 VA: 0x18188EDF0
	|-GenericsUtil.CastImpl<float, Color>..cctor
	|
	|-RVA: 0x188A3E0 Offset: 0x18889E0 VA: 0x18188A3E0
	|-GenericsUtil.CastImpl<float, Ray>..cctor
	|
	|-RVA: 0x188F750 Offset: 0x188DD50 VA: 0x18188F750
	|-GenericsUtil.CastImpl<float, Vector3>..cctor
	|
	|-RVA: 0x188F390 Offset: 0x188D990 VA: 0x18188F390
	|-GenericsUtil.CastImpl<ushort, bool>..cctor
	|
	|-RVA: 0x188C780 Offset: 0x188AD80 VA: 0x18188C780
	|-GenericsUtil.CastImpl<ushort, byte>..cctor
	|
	|-RVA: 0x188E3A0 Offset: 0x188C9A0 VA: 0x18188E3A0
	|-GenericsUtil.CastImpl<ushort, int>..cctor
	|
	|-RVA: 0x188FFC0 Offset: 0x188E5C0 VA: 0x18188FFC0
	|-GenericsUtil.CastImpl<ushort, object>..cctor
	|
	|-RVA: 0x188E940 Offset: 0x188CF40 VA: 0x18188E940
	|-GenericsUtil.CastImpl<ushort, sbyte>..cctor
	|
	|-RVA: 0x188F840 Offset: 0x188DE40 VA: 0x18188F840
	|-GenericsUtil.CastImpl<ushort, float>..cctor
	|
	|-RVA: 0x18898A0 Offset: 0x1887EA0 VA: 0x1818898A0
	|-GenericsUtil.CastImpl<ushort, uint>..cctor
	|
	|-RVA: 0x188C1E0 Offset: 0x188A7E0 VA: 0x18188C1E0
	|-GenericsUtil.CastImpl<ushort, ulong>..cctor
	|
	|-RVA: 0x188BE20 Offset: 0x188A420 VA: 0x18188BE20
	|-GenericsUtil.CastImpl<ushort, Color>..cctor
	|
	|-RVA: 0x18910A0 Offset: 0x188F6A0 VA: 0x1818910A0
	|-GenericsUtil.CastImpl<ushort, Ray>..cctor
	|
	|-RVA: 0x188E490 Offset: 0x188CA90 VA: 0x18188E490
	|-GenericsUtil.CastImpl<ushort, Vector3>..cctor
	|
	|-RVA: 0x1889210 Offset: 0x1887810 VA: 0x181889210
	|-GenericsUtil.CastImpl<uint, bool>..cctor
	|
	|-RVA: 0x188B790 Offset: 0x1889D90 VA: 0x18188B790
	|-GenericsUtil.CastImpl<uint, byte>..cctor
	|
	|-RVA: 0x188B6A0 Offset: 0x1889CA0 VA: 0x18188B6A0
	|-GenericsUtil.CastImpl<uint, short>..cctor
	|
	|-RVA: 0x18901A0 Offset: 0x188E7A0 VA: 0x1818901A0
	|-GenericsUtil.CastImpl<uint, int>..cctor
	|
	|-RVA: 0x188C0F0 Offset: 0x188A6F0 VA: 0x18188C0F0
	|-GenericsUtil.CastImpl<uint, long>..cctor
	|
	|-RVA: 0x188A200 Offset: 0x1888800 VA: 0x18188A200
	|-GenericsUtil.CastImpl<uint, object>..cctor
	|
	|-RVA: 0x188CF00 Offset: 0x188B500 VA: 0x18188CF00
	|-GenericsUtil.CastImpl<uint, sbyte>..cctor
	|
	|-RVA: 0x188CB40 Offset: 0x188B140 VA: 0x18188CB40
	|-GenericsUtil.CastImpl<uint, float>..cctor
	|
	|-RVA: 0x188F1B0 Offset: 0x188D7B0 VA: 0x18188F1B0
	|-GenericsUtil.CastImpl<uint, ushort>..cctor
	|
	|-RVA: 0x1890830 Offset: 0x188EE30 VA: 0x181890830
	|-GenericsUtil.CastImpl<uint, uint>..cctor
	|
	|-RVA: 0x188F570 Offset: 0x188DB70 VA: 0x18188F570
	|-GenericsUtil.CastImpl<uint, ulong>..cctor
	|
	|-RVA: 0x188AF20 Offset: 0x1889520 VA: 0x18188AF20
	|-GenericsUtil.CastImpl<uint, Color>..cctor
	|
	|-RVA: 0x188FDE0 Offset: 0x188E3E0 VA: 0x18188FDE0
	|-GenericsUtil.CastImpl<uint, Ray>..cctor
	|
	|-RVA: 0x188DEF0 Offset: 0x188C4F0 VA: 0x18188DEF0
	|-GenericsUtil.CastImpl<uint, Vector3>..cctor
	|
	|-RVA: 0x1890B00 Offset: 0x188F100 VA: 0x181890B00
	|-GenericsUtil.CastImpl<ulong, bool>..cctor
	|
	|-RVA: 0x1642840 Offset: 0x1640E40 VA: 0x181642840
	|-GenericsUtil.CastImpl<ulong, byte>..cctor
	|
	|-RVA: 0x1642B10 Offset: 0x1641110 VA: 0x181642B10
	|-GenericsUtil.CastImpl<ulong, short>..cctor
	|
	|-RVA: 0x1643FB0 Offset: 0x16425B0 VA: 0x181643FB0
	|-GenericsUtil.CastImpl<ulong, int>..cctor
	|
	|-RVA: 0x1643740 Offset: 0x1641D40 VA: 0x181643740
	|-GenericsUtil.CastImpl<ulong, long>..cctor
	|
	|-RVA: 0x16420C0 Offset: 0x16406C0 VA: 0x1816420C0
	|-GenericsUtil.CastImpl<ulong, object>..cctor
	|
	|-RVA: 0x1642480 Offset: 0x1640A80 VA: 0x181642480
	|-GenericsUtil.CastImpl<ulong, sbyte>..cctor
	|
	|-RVA: 0x1643920 Offset: 0x1641F20 VA: 0x181643920
	|-GenericsUtil.CastImpl<ulong, float>..cctor
	|
	|-RVA: 0x1642930 Offset: 0x1640F30 VA: 0x181642930
	|-GenericsUtil.CastImpl<ulong, ushort>..cctor
	|
	|-RVA: 0x1644550 Offset: 0x1642B50 VA: 0x181644550
	|-GenericsUtil.CastImpl<ulong, uint>..cctor
	|
	|-RVA: 0x1643290 Offset: 0x1641890 VA: 0x181643290
	|-GenericsUtil.CastImpl<ulong, ulong>..cctor
	|
	|-RVA: 0x1644730 Offset: 0x1642D30 VA: 0x181644730
	|-GenericsUtil.CastImpl<ulong, Color>..cctor
	|
	|-RVA: 0x16430B0 Offset: 0x16416B0 VA: 0x1816430B0
	|-GenericsUtil.CastImpl<ulong, Ray>..cctor
	|
	|-RVA: 0x1642CF0 Offset: 0x16412F0 VA: 0x181642CF0
	|-GenericsUtil.CastImpl<ulong, Vector3>..cctor
	|
	|-RVA: 0x1643470 Offset: 0x1641A70 VA: 0x181643470
	|-GenericsUtil.CastImpl<Color, bool>..cctor
	|
	|-RVA: 0x1644280 Offset: 0x1642880 VA: 0x181644280
	|-GenericsUtil.CastImpl<Color, byte>..cctor
	|
	|-RVA: 0x1643A10 Offset: 0x1642010 VA: 0x181643A10
	|-GenericsUtil.CastImpl<Color, short>..cctor
	|
	|-RVA: 0x1642660 Offset: 0x1640C60 VA: 0x181642660
	|-GenericsUtil.CastImpl<Color, int>..cctor
	|
	|-RVA: 0x1644A00 Offset: 0x1643000 VA: 0x181644A00
	|-GenericsUtil.CastImpl<Color, long>..cctor
	|
	|-RVA: 0x1641940 Offset: 0x163FF40 VA: 0x181641940
	|-GenericsUtil.CastImpl<Color, object>..cctor
	|
	|-RVA: 0x1643BF0 Offset: 0x16421F0 VA: 0x181643BF0
	|-GenericsUtil.CastImpl<Color, sbyte>..cctor
	|
	|-RVA: 0x1644910 Offset: 0x1642F10 VA: 0x181644910
	|-GenericsUtil.CastImpl<Color, float>..cctor
	|
	|-RVA: 0x1644370 Offset: 0x1642970 VA: 0x181644370
	|-GenericsUtil.CastImpl<Color, ushort>..cctor
	|
	|-RVA: 0x1642390 Offset: 0x1640990 VA: 0x181642390
	|-GenericsUtil.CastImpl<Color, uint>..cctor
	|
	|-RVA: 0x1643DD0 Offset: 0x16423D0 VA: 0x181643DD0
	|-GenericsUtil.CastImpl<Color, ulong>..cctor
	|
	|-RVA: 0x1644640 Offset: 0x1642C40 VA: 0x181644640
	|-GenericsUtil.CastImpl<Color, Color>..cctor
	|
	|-RVA: 0x1643560 Offset: 0x1641B60 VA: 0x181643560
	|-GenericsUtil.CastImpl<Color, Ray>..cctor
	|
	|-RVA: 0x1642ED0 Offset: 0x16414D0 VA: 0x181642ED0
	|-GenericsUtil.CastImpl<Color, Vector3>..cctor
	|
	|-RVA: 0x1643B00 Offset: 0x1642100 VA: 0x181643B00
	|-GenericsUtil.CastImpl<Ray, bool>..cctor
	|
	|-RVA: 0x1641FD0 Offset: 0x16405D0 VA: 0x181641FD0
	|-GenericsUtil.CastImpl<Ray, byte>..cctor
	|
	|-RVA: 0x1641D00 Offset: 0x1640300 VA: 0x181641D00
	|-GenericsUtil.CastImpl<Ray, short>..cctor
	|
	|-RVA: 0x1641B20 Offset: 0x1640120 VA: 0x181641B20
	|-GenericsUtil.CastImpl<Ray, int>..cctor
	|
	|-RVA: 0x1643CE0 Offset: 0x16422E0 VA: 0x181643CE0
	|-GenericsUtil.CastImpl<Ray, long>..cctor
	|
	|-RVA: 0x1643EC0 Offset: 0x16424C0 VA: 0x181643EC0
	|-GenericsUtil.CastImpl<Ray, object>..cctor
	|
	|-RVA: 0x16440A0 Offset: 0x16426A0 VA: 0x1816440A0
	|-GenericsUtil.CastImpl<Ray, sbyte>..cctor
	|
	|-RVA: 0x1642FC0 Offset: 0x16415C0 VA: 0x181642FC0
	|-GenericsUtil.CastImpl<Ray, float>..cctor
	|
	|-RVA: 0x1644190 Offset: 0x1642790 VA: 0x181644190
	|-GenericsUtil.CastImpl<Ray, ushort>..cctor
	|
	|-RVA: 0x16421B0 Offset: 0x16407B0 VA: 0x1816421B0
	|-GenericsUtil.CastImpl<Ray, uint>..cctor
	|
	|-RVA: 0x1642C00 Offset: 0x1641200 VA: 0x181642C00
	|-GenericsUtil.CastImpl<Ray, ulong>..cctor
	|
	|-RVA: 0x1641EE0 Offset: 0x16404E0 VA: 0x181641EE0
	|-GenericsUtil.CastImpl<Ray, Color>..cctor
	|
	|-RVA: 0x1642A20 Offset: 0x1641020 VA: 0x181642A20
	|-GenericsUtil.CastImpl<Ray, Ray>..cctor
	|
	|-RVA: 0x1642DE0 Offset: 0x16413E0 VA: 0x181642DE0
	|-GenericsUtil.CastImpl<Ray, Vector3>..cctor
	|
	|-RVA: 0x1641DF0 Offset: 0x16403F0 VA: 0x181641DF0
	|-GenericsUtil.CastImpl<Vector3, bool>..cctor
	|
	|-RVA: 0x1643650 Offset: 0x1641C50 VA: 0x181643650
	|-GenericsUtil.CastImpl<Vector3, byte>..cctor
	|
	|-RVA: 0x1643380 Offset: 0x1641980 VA: 0x181643380
	|-GenericsUtil.CastImpl<Vector3, short>..cctor
	|
	|-RVA: 0x16431A0 Offset: 0x16417A0 VA: 0x1816431A0
	|-GenericsUtil.CastImpl<Vector3, int>..cctor
	|
	|-RVA: 0x1642750 Offset: 0x1640D50 VA: 0x181642750
	|-GenericsUtil.CastImpl<Vector3, long>..cctor
	|
	|-RVA: 0x1641760 Offset: 0x163FD60 VA: 0x181641760
	|-GenericsUtil.CastImpl<Vector3, object>..cctor
	|
	|-RVA: 0x1641850 Offset: 0x163FE50 VA: 0x181641850
	|-GenericsUtil.CastImpl<Vector3, sbyte>..cctor
	|
	|-RVA: 0x1643830 Offset: 0x1641E30 VA: 0x181643830
	|-GenericsUtil.CastImpl<Vector3, float>..cctor
	|
	|-RVA: 0x1641A30 Offset: 0x1640030 VA: 0x181641A30
	|-GenericsUtil.CastImpl<Vector3, ushort>..cctor
	|
	|-RVA: 0x16422A0 Offset: 0x16408A0 VA: 0x1816422A0
	|-GenericsUtil.CastImpl<Vector3, uint>..cctor
	|
	|-RVA: 0x1644820 Offset: 0x1642E20 VA: 0x181644820
	|-GenericsUtil.CastImpl<Vector3, ulong>..cctor
	|
	|-RVA: 0x1644460 Offset: 0x1642A60 VA: 0x181644460
	|-GenericsUtil.CastImpl<Vector3, Color>..cctor
	|
	|-RVA: 0x1641C10 Offset: 0x1640210 VA: 0x181641C10
	|-GenericsUtil.CastImpl<Vector3, Ray>..cctor
	|
	|-RVA: 0x1642570 Offset: 0x1640B70 VA: 0x181642570
	|-GenericsUtil.CastImpl<Vector3, Vector3>..cctor
	*/

}

