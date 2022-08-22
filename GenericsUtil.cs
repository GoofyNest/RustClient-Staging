public static class GenericsUtil // TypeDefIndex: 4817
{	// Methods

	// RVA: -1 Offset: -1
	public static TDst Cast<TSrc, TDst>(TSrc obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A4170 Offset: 0x15A2770 VA: 0x1815A4170
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
	|-RVA: 0x15A4400 Offset: 0x15A2A00 VA: 0x1815A4400
	|-GenericsUtil.Cast<bool, short>
	|-GenericsUtil.Cast<bool, ushort>
	|-GenericsUtil.Cast<byte, short>
	|-GenericsUtil.Cast<byte, ushort>
	|-GenericsUtil.Cast<sbyte, short>
	|-GenericsUtil.Cast<sbyte, ushort>
	|
	|-RVA: 0x15A4540 Offset: 0x15A2B40 VA: 0x1815A4540
	|-GenericsUtil.Cast<bool, int>
	|-GenericsUtil.Cast<bool, uint>
	|-GenericsUtil.Cast<byte, int>
	|-GenericsUtil.Cast<byte, uint>
	|-GenericsUtil.Cast<sbyte, int>
	|-GenericsUtil.Cast<sbyte, uint>
	|
	|-RVA: 0x15A4680 Offset: 0x15A2C80 VA: 0x1815A4680
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
	|-RVA: 0x15A4910 Offset: 0x15A2F10 VA: 0x1815A4910
	|-GenericsUtil.Cast<bool, float>
	|-GenericsUtil.Cast<byte, float>
	|-GenericsUtil.Cast<sbyte, float>
	|
	|-RVA: 0x15A42B0 Offset: 0x15A28B0 VA: 0x1815A42B0
	|-GenericsUtil.Cast<bool, Color>
	|-GenericsUtil.Cast<byte, Color>
	|-GenericsUtil.Cast<sbyte, Color>
	|
	|-RVA: 0x15A47C0 Offset: 0x15A2DC0 VA: 0x1815A47C0
	|-GenericsUtil.Cast<bool, Ray>
	|-GenericsUtil.Cast<byte, Ray>
	|-GenericsUtil.Cast<sbyte, Ray>
	|
	|-RVA: 0x15A4A50 Offset: 0x15A3050 VA: 0x1815A4A50
	|-GenericsUtil.Cast<bool, Vector3>
	|-GenericsUtil.Cast<byte, Vector3>
	|-GenericsUtil.Cast<sbyte, Vector3>
	|
	|-RVA: 0x15A4F70 Offset: 0x15A3570 VA: 0x1815A4F70
	|-GenericsUtil.Cast<Guid, int>
	|-GenericsUtil.Cast<Color, int>
	|-GenericsUtil.Cast<Color, uint>
	|
	|-RVA: 0x15A50B0 Offset: 0x15A36B0 VA: 0x1815A50B0
	|-GenericsUtil.Cast<Guid, long>
	|-GenericsUtil.Cast<Guid, object>
	|-GenericsUtil.Cast<Color, long>
	|-GenericsUtil.Cast<Color, object>
	|-GenericsUtil.Cast<Color, ulong>
	|
	|-RVA: 0x15A55F0 Offset: 0x15A3BF0 VA: 0x1815A55F0
	|-GenericsUtil.Cast<int, bool>
	|-GenericsUtil.Cast<int, byte>
	|-GenericsUtil.Cast<int, sbyte>
	|-GenericsUtil.Cast<uint, bool>
	|-GenericsUtil.Cast<uint, byte>
	|-GenericsUtil.Cast<uint, sbyte>
	|
	|-RVA: 0x15A5880 Offset: 0x15A3E80 VA: 0x1815A5880
	|-GenericsUtil.Cast<int, double>
	|
	|-RVA: 0x15A5730 Offset: 0x15A3D30 VA: 0x1815A5730
	|-GenericsUtil.Cast<int, Guid>
	|-GenericsUtil.Cast<int, Color>
	|-GenericsUtil.Cast<uint, Color>
	|
	|-RVA: 0x15A59C0 Offset: 0x15A3FC0 VA: 0x1815A59C0
	|-GenericsUtil.Cast<int, short>
	|-GenericsUtil.Cast<int, ushort>
	|-GenericsUtil.Cast<uint, short>
	|-GenericsUtil.Cast<uint, ushort>
	|
	|-RVA: 0x15A5B00 Offset: 0x15A4100 VA: 0x1815A5B00
	|-GenericsUtil.Cast<int, int>
	|-GenericsUtil.Cast<int, uint>
	|-GenericsUtil.Cast<uint, int>
	|-GenericsUtil.Cast<uint, uint>
	|
	|-RVA: 0x15A5C30 Offset: 0x15A4230 VA: 0x1815A5C30
	|-GenericsUtil.Cast<int, long>
	|-GenericsUtil.Cast<int, object>
	|-GenericsUtil.Cast<int, ulong>
	|-GenericsUtil.Cast<uint, long>
	|-GenericsUtil.Cast<uint, object>
	|-GenericsUtil.Cast<uint, ulong>
	|
	|-RVA: 0x15A5EC0 Offset: 0x15A44C0 VA: 0x1815A5EC0
	|-GenericsUtil.Cast<int, float>
	|-GenericsUtil.Cast<uint, float>
	|
	|-RVA: 0x15A5D70 Offset: 0x15A4370 VA: 0x1815A5D70
	|-GenericsUtil.Cast<int, Ray>
	|-GenericsUtil.Cast<uint, Ray>
	|
	|-RVA: 0x15A6000 Offset: 0x15A4600 VA: 0x1815A6000
	|-GenericsUtil.Cast<int, Vector3>
	|-GenericsUtil.Cast<uint, Vector3>
	|
	|-RVA: 0x15A6150 Offset: 0x15A4750 VA: 0x1815A6150
	|-GenericsUtil.Cast<long, int>
	|-GenericsUtil.Cast<ulong, int>
	|-GenericsUtil.Cast<ulong, uint>
	|
	|-RVA: 0x15A6290 Offset: 0x15A4890 VA: 0x1815A6290
	|-GenericsUtil.Cast<long, long>
	|-GenericsUtil.Cast<long, object>
	|-GenericsUtil.Cast<ulong, long>
	|-GenericsUtil.Cast<ulong, object>
	|-GenericsUtil.Cast<ulong, ulong>
	|
	|-RVA: 0x15A6E40 Offset: 0x15A5440 VA: 0x1815A6E40
	|-GenericsUtil.Cast<object, bool>
	|-GenericsUtil.Cast<object, byte>
	|-GenericsUtil.Cast<object, sbyte>
	|
	|-RVA: 0x15A70E0 Offset: 0x15A56E0 VA: 0x1815A70E0
	|-GenericsUtil.Cast<object, double>
	|
	|-RVA: 0x15A6F80 Offset: 0x15A5580 VA: 0x1815A6F80
	|-GenericsUtil.Cast<object, Guid>
	|-GenericsUtil.Cast<object, Color>
	|
	|-RVA: 0x15A7220 Offset: 0x15A5820 VA: 0x1815A7220
	|-GenericsUtil.Cast<object, short>
	|-GenericsUtil.Cast<object, ushort>
	|
	|-RVA: 0x15A7360 Offset: 0x15A5960 VA: 0x1815A7360
	|-GenericsUtil.Cast<object, int>
	|-GenericsUtil.Cast<object, uint>
	|
	|-RVA: 0x15A74A0 Offset: 0x15A5AA0 VA: 0x1815A74A0
	|-GenericsUtil.Cast<object, long>
	|-GenericsUtil.Cast<object, object>
	|-GenericsUtil.Cast<object, ulong>
	|
	|-RVA: 0x15A7740 Offset: 0x15A5D40 VA: 0x1815A7740
	|-GenericsUtil.Cast<object, float>
	|
	|-RVA: 0x15A75E0 Offset: 0x15A5BE0 VA: 0x1815A75E0
	|-GenericsUtil.Cast<object, Ray>
	|
	|-RVA: 0x15A7880 Offset: 0x15A5E80 VA: 0x1815A7880
	|-GenericsUtil.Cast<object, Vector3>
	|
	|-RVA: 0x15A79E0 Offset: 0x15A5FE0 VA: 0x1815A79E0
	|-GenericsUtil.Cast<float, bool>
	|-GenericsUtil.Cast<float, byte>
	|-GenericsUtil.Cast<float, sbyte>
	|
	|-RVA: 0x15A7C70 Offset: 0x15A6270 VA: 0x1815A7C70
	|-GenericsUtil.Cast<float, short>
	|-GenericsUtil.Cast<float, ushort>
	|
	|-RVA: 0x15A7DB0 Offset: 0x15A63B0 VA: 0x1815A7DB0
	|-GenericsUtil.Cast<float, int>
	|-GenericsUtil.Cast<float, uint>
	|
	|-RVA: 0x15A7EF0 Offset: 0x15A64F0 VA: 0x1815A7EF0
	|-GenericsUtil.Cast<float, long>
	|-GenericsUtil.Cast<float, object>
	|-GenericsUtil.Cast<float, ulong>
	|
	|-RVA: 0x15A8190 Offset: 0x15A6790 VA: 0x1815A8190
	|-GenericsUtil.Cast<float, float>
	|
	|-RVA: 0x15A7B20 Offset: 0x15A6120 VA: 0x1815A7B20
	|-GenericsUtil.Cast<float, Color>
	|
	|-RVA: 0x15A8030 Offset: 0x15A6630 VA: 0x1815A8030
	|-GenericsUtil.Cast<float, Ray>
	|
	|-RVA: 0x15A82D0 Offset: 0x15A68D0 VA: 0x1815A82D0
	|-GenericsUtil.Cast<float, Vector3>
	|
	|-RVA: 0x15A8420 Offset: 0x15A6A20 VA: 0x1815A8420
	|-GenericsUtil.Cast<ulong, bool>
	|-GenericsUtil.Cast<ulong, byte>
	|-GenericsUtil.Cast<ulong, sbyte>
	|
	|-RVA: 0x15A86B0 Offset: 0x15A6CB0 VA: 0x1815A86B0
	|-GenericsUtil.Cast<ulong, short>
	|-GenericsUtil.Cast<ulong, ushort>
	|
	|-RVA: 0x15A8940 Offset: 0x15A6F40 VA: 0x1815A8940
	|-GenericsUtil.Cast<ulong, float>
	|
	|-RVA: 0x15A8560 Offset: 0x15A6B60 VA: 0x1815A8560
	|-GenericsUtil.Cast<ulong, Color>
	|
	|-RVA: 0x15A87F0 Offset: 0x15A6DF0 VA: 0x1815A87F0
	|-GenericsUtil.Cast<ulong, Ray>
	|
	|-RVA: 0x15A8A80 Offset: 0x15A7080 VA: 0x1815A8A80
	|-GenericsUtil.Cast<ulong, Vector3>
	|
	|-RVA: 0x15A4BA0 Offset: 0x15A31A0 VA: 0x1815A4BA0
	|-GenericsUtil.Cast<Color, bool>
	|-GenericsUtil.Cast<Color, byte>
	|-GenericsUtil.Cast<Color, sbyte>
	|
	|-RVA: 0x15A4E30 Offset: 0x15A3430 VA: 0x1815A4E30
	|-GenericsUtil.Cast<Color, short>
	|-GenericsUtil.Cast<Color, ushort>
	|
	|-RVA: 0x15A5350 Offset: 0x15A3950 VA: 0x1815A5350
	|-GenericsUtil.Cast<Color, float>
	|
	|-RVA: 0x15A4CE0 Offset: 0x15A32E0 VA: 0x1815A4CE0
	|-GenericsUtil.Cast<Color, Color>
	|
	|-RVA: 0x15A51F0 Offset: 0x15A37F0 VA: 0x1815A51F0
	|-GenericsUtil.Cast<Color, Ray>
	|
	|-RVA: 0x15A5490 Offset: 0x15A3A90 VA: 0x1815A5490
	|-GenericsUtil.Cast<Color, Vector3>
	|
	|-RVA: 0x15A63D0 Offset: 0x15A49D0 VA: 0x1815A63D0
	|-GenericsUtil.Cast<Ray, bool>
	|-GenericsUtil.Cast<Ray, byte>
	|-GenericsUtil.Cast<Ray, sbyte>
	|
	|-RVA: 0x15A6670 Offset: 0x15A4C70 VA: 0x1815A6670
	|-GenericsUtil.Cast<Ray, short>
	|-GenericsUtil.Cast<Ray, ushort>
	|
	|-RVA: 0x15A67B0 Offset: 0x15A4DB0 VA: 0x1815A67B0
	|-GenericsUtil.Cast<Ray, int>
	|-GenericsUtil.Cast<Ray, uint>
	|
	|-RVA: 0x15A68F0 Offset: 0x15A4EF0 VA: 0x1815A68F0
	|-GenericsUtil.Cast<Ray, long>
	|-GenericsUtil.Cast<Ray, object>
	|-GenericsUtil.Cast<Ray, ulong>
	|
	|-RVA: 0x15A6B90 Offset: 0x15A5190 VA: 0x1815A6B90
	|-GenericsUtil.Cast<Ray, float>
	|
	|-RVA: 0x15A6510 Offset: 0x15A4B10 VA: 0x1815A6510
	|-GenericsUtil.Cast<Ray, Color>
	|
	|-RVA: 0x15A6A30 Offset: 0x15A5030 VA: 0x1815A6A30
	|-GenericsUtil.Cast<Ray, Ray>
	|
	|-RVA: 0x15A6CE0 Offset: 0x15A52E0 VA: 0x1815A6CE0
	|-GenericsUtil.Cast<Ray, Vector3>
	|
	|-RVA: 0x15A8BD0 Offset: 0x15A71D0 VA: 0x1815A8BD0
	|-GenericsUtil.Cast<Vector3, bool>
	|-GenericsUtil.Cast<Vector3, byte>
	|-GenericsUtil.Cast<Vector3, sbyte>
	|
	|-RVA: 0x15A8E70 Offset: 0x15A7470 VA: 0x1815A8E70
	|-GenericsUtil.Cast<Vector3, short>
	|-GenericsUtil.Cast<Vector3, ushort>
	|
	|-RVA: 0x15A8FB0 Offset: 0x15A75B0 VA: 0x1815A8FB0
	|-GenericsUtil.Cast<Vector3, int>
	|-GenericsUtil.Cast<Vector3, uint>
	|
	|-RVA: 0x15A90F0 Offset: 0x15A76F0 VA: 0x1815A90F0
	|-GenericsUtil.Cast<Vector3, long>
	|-GenericsUtil.Cast<Vector3, object>
	|-GenericsUtil.Cast<Vector3, ulong>
	|
	|-RVA: 0x15A9390 Offset: 0x15A7990 VA: 0x1815A9390
	|-GenericsUtil.Cast<Vector3, float>
	|
	|-RVA: 0x15A8D10 Offset: 0x15A7310 VA: 0x1815A8D10
	|-GenericsUtil.Cast<Vector3, Color>
	|
	|-RVA: 0x15A9230 Offset: 0x15A7830 VA: 0x1815A9230
	|-GenericsUtil.Cast<Vector3, Ray>
	|
	|-RVA: 0x15A94D0 Offset: 0x15A7AD0 VA: 0x1815A94D0
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
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSrc Value; // 0xFFFFFFFF

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E38F0 Offset: 0x15E1EF0 VA: 0x1815E38F0
	|-GenericsUtil.CastImpl<bool, bool>..cctor
	|
	|-RVA: 0x15DE490 Offset: 0x15DCA90 VA: 0x1815DE490
	|-GenericsUtil.CastImpl<bool, byte>..cctor
	|
	|-RVA: 0x15E3350 Offset: 0x15E1950 VA: 0x1815E3350
	|-GenericsUtil.CastImpl<bool, short>..cctor
	|
	|-RVA: 0x15DD3B0 Offset: 0x15DB9B0 VA: 0x1815DD3B0
	|-GenericsUtil.CastImpl<bool, int>..cctor
	|
	|-RVA: 0x15DD950 Offset: 0x15DBF50 VA: 0x1815DD950
	|-GenericsUtil.CastImpl<bool, long>..cctor
	|
	|-RVA: 0x15DE940 Offset: 0x15DCF40 VA: 0x1815DE940
	|-GenericsUtil.CastImpl<bool, object>..cctor
	|
	|-RVA: 0x15E3E90 Offset: 0x15E2490 VA: 0x1815E3E90
	|-GenericsUtil.CastImpl<bool, sbyte>..cctor
	|
	|-RVA: 0x15E48E0 Offset: 0x15E2EE0 VA: 0x1815E48E0
	|-GenericsUtil.CastImpl<bool, float>..cctor
	|
	|-RVA: 0x15E0920 Offset: 0x15DEF20 VA: 0x1815E0920
	|-GenericsUtil.CastImpl<bool, ushort>..cctor
	|
	|-RVA: 0x15DDEF0 Offset: 0x15DC4F0 VA: 0x1815DDEF0
	|-GenericsUtil.CastImpl<bool, uint>..cctor
	|
	|-RVA: 0x15E39E0 Offset: 0x15E1FE0 VA: 0x1815E39E0
	|-GenericsUtil.CastImpl<bool, ulong>..cctor
	|
	|-RVA: 0x15DEDF0 Offset: 0x15DD3F0 VA: 0x1815DEDF0
	|-GenericsUtil.CastImpl<bool, Color>..cctor
	|
	|-RVA: 0x15DF480 Offset: 0x15DDA80 VA: 0x1815DF480
	|-GenericsUtil.CastImpl<bool, Ray>..cctor
	|
	|-RVA: 0x15DDA40 Offset: 0x15DC040 VA: 0x1815DDA40
	|-GenericsUtil.CastImpl<bool, Vector3>..cctor
	|
	|-RVA: 0x15DFED0 Offset: 0x15DE4D0 VA: 0x1815DFED0
	|-GenericsUtil.CastImpl<byte, bool>..cctor
	|
	|-RVA: 0x15DEC10 Offset: 0x15DD210 VA: 0x1815DEC10
	|-GenericsUtil.CastImpl<byte, byte>..cctor
	|
	|-RVA: 0x15E47F0 Offset: 0x15E2DF0 VA: 0x1815E47F0
	|-GenericsUtil.CastImpl<byte, short>..cctor
	|
	|-RVA: 0x15DF2A0 Offset: 0x15DD8A0 VA: 0x1815DF2A0
	|-GenericsUtil.CastImpl<byte, int>..cctor
	|
	|-RVA: 0x15E1FA0 Offset: 0x15E05A0 VA: 0x1815E1FA0
	|-GenericsUtil.CastImpl<byte, long>..cctor
	|
	|-RVA: 0x15E1AF0 Offset: 0x15E00F0 VA: 0x1815E1AF0
	|-GenericsUtil.CastImpl<byte, object>..cctor
	|
	|-RVA: 0x15DD2C0 Offset: 0x15DB8C0 VA: 0x1815DD2C0
	|-GenericsUtil.CastImpl<byte, sbyte>..cctor
	|
	|-RVA: 0x15DEEE0 Offset: 0x15DD4E0 VA: 0x1815DEEE0
	|-GenericsUtil.CastImpl<byte, float>..cctor
	|
	|-RVA: 0x15E29F0 Offset: 0x15E0FF0 VA: 0x1815E29F0
	|-GenericsUtil.CastImpl<byte, ushort>..cctor
	|
	|-RVA: 0x15DE1C0 Offset: 0x15DC7C0 VA: 0x1815DE1C0
	|-GenericsUtil.CastImpl<byte, uint>..cctor
	|
	|-RVA: 0x15DDB30 Offset: 0x15DC130 VA: 0x1815DDB30
	|-GenericsUtil.CastImpl<byte, ulong>..cctor
	|
	|-RVA: 0x15E0650 Offset: 0x15DEC50 VA: 0x1815E0650
	|-GenericsUtil.CastImpl<byte, Color>..cctor
	|
	|-RVA: 0x15DD4A0 Offset: 0x15DBAA0 VA: 0x1815DD4A0
	|-GenericsUtil.CastImpl<byte, Ray>..cctor
	|
	|-RVA: 0x15E0EC0 Offset: 0x15DF4C0 VA: 0x1815E0EC0
	|-GenericsUtil.CastImpl<byte, Vector3>..cctor
	|
	|-RVA: 0x15E2810 Offset: 0x15E0E10 VA: 0x1815E2810
	|-GenericsUtil.CastImpl<double, int>..cctor
	|
	|-RVA: 0x15E3AD0 Offset: 0x15E20D0 VA: 0x1815E3AD0
	|-GenericsUtil.CastImpl<double, object>..cctor
	|
	|-RVA: 0x15E1550 Offset: 0x15DFB50 VA: 0x1815E1550
	|-GenericsUtil.CastImpl<Guid, int>..cctor
	|
	|-RVA: 0x15DF840 Offset: 0x15DDE40 VA: 0x1815DF840
	|-GenericsUtil.CastImpl<Guid, long>..cctor
	|
	|-RVA: 0x15DDFE0 Offset: 0x15DC5E0 VA: 0x1815DDFE0
	|-GenericsUtil.CastImpl<Guid, object>..cctor
	|
	|-RVA: 0x15E4610 Offset: 0x15E2C10 VA: 0x1815E4610
	|-GenericsUtil.CastImpl<short, bool>..cctor
	|
	|-RVA: 0x15E0A10 Offset: 0x15DF010 VA: 0x1815E0A10
	|-GenericsUtil.CastImpl<short, byte>..cctor
	|
	|-RVA: 0x15DF0C0 Offset: 0x15DD6C0 VA: 0x1815DF0C0
	|-GenericsUtil.CastImpl<short, int>..cctor
	|
	|-RVA: 0x15DF750 Offset: 0x15DDD50 VA: 0x1815DF750
	|-GenericsUtil.CastImpl<short, object>..cctor
	|
	|-RVA: 0x15E2BD0 Offset: 0x15E11D0 VA: 0x1815E2BD0
	|-GenericsUtil.CastImpl<short, sbyte>..cctor
	|
	|-RVA: 0x15E2270 Offset: 0x15E0870 VA: 0x1815E2270
	|-GenericsUtil.CastImpl<short, float>..cctor
	|
	|-RVA: 0x15E2360 Offset: 0x15E0960 VA: 0x1815E2360
	|-GenericsUtil.CastImpl<short, uint>..cctor
	|
	|-RVA: 0x15E2720 Offset: 0x15E0D20 VA: 0x1815E2720
	|-GenericsUtil.CastImpl<short, ulong>..cctor
	|
	|-RVA: 0x15DF930 Offset: 0x15DDF30 VA: 0x1815DF930
	|-GenericsUtil.CastImpl<short, Color>..cctor
	|
	|-RVA: 0x15E2CC0 Offset: 0x15E12C0 VA: 0x1815E2CC0
	|-GenericsUtil.CastImpl<short, Ray>..cctor
	|
	|-RVA: 0x15DEB20 Offset: 0x15DD120 VA: 0x1815DEB20
	|-GenericsUtil.CastImpl<short, Vector3>..cctor
	|
	|-RVA: 0x15E3260 Offset: 0x15E1860 VA: 0x1815E3260
	|-GenericsUtil.CastImpl<int, bool>..cctor
	|
	|-RVA: 0x15E3CB0 Offset: 0x15E22B0 VA: 0x1815E3CB0
	|-GenericsUtil.CastImpl<int, byte>..cctor
	|
	|-RVA: 0x15DFB10 Offset: 0x15DE110 VA: 0x1815DFB10
	|-GenericsUtil.CastImpl<int, double>..cctor
	|
	|-RVA: 0x15E1EB0 Offset: 0x15E04B0 VA: 0x1815E1EB0
	|-GenericsUtil.CastImpl<int, Guid>..cctor
	|
	|-RVA: 0x15E1A00 Offset: 0x15E0000 VA: 0x1815E1A00
	|-GenericsUtil.CastImpl<int, short>..cctor
	|
	|-RVA: 0x15DFFC0 Offset: 0x15DE5C0 VA: 0x1815DFFC0
	|-GenericsUtil.CastImpl<int, int>..cctor
	|
	|-RVA: 0x15E1460 Offset: 0x15DFA60 VA: 0x1815E1460
	|-GenericsUtil.CastImpl<int, long>..cctor
	|
	|-RVA: 0x15E1370 Offset: 0x15DF970 VA: 0x1815E1370
	|-GenericsUtil.CastImpl<int, object>..cctor
	|
	|-RVA: 0x15E4250 Offset: 0x15E2850 VA: 0x1815E4250
	|-GenericsUtil.CastImpl<int, sbyte>..cctor
	|
	|-RVA: 0x15E3F80 Offset: 0x15E2580 VA: 0x1815E3F80
	|-GenericsUtil.CastImpl<int, float>..cctor
	|
	|-RVA: 0x15E2450 Offset: 0x15E0A50 VA: 0x1815E2450
	|-GenericsUtil.CastImpl<int, ushort>..cctor
	|
	|-RVA: 0x15E0740 Offset: 0x15DED40 VA: 0x1815E0740
	|-GenericsUtil.CastImpl<int, uint>..cctor
	|
	|-RVA: 0x15E3800 Offset: 0x15E1E00 VA: 0x1815E3800
	|-GenericsUtil.CastImpl<int, ulong>..cctor
	|
	|-RVA: 0x15E01A0 Offset: 0x15DE7A0 VA: 0x1815E01A0
	|-GenericsUtil.CastImpl<int, Color>..cctor
	|
	|-RVA: 0x15E0470 Offset: 0x15DEA70 VA: 0x1815E0470
	|-GenericsUtil.CastImpl<int, Ray>..cctor
	|
	|-RVA: 0x15E10A0 Offset: 0x15DF6A0 VA: 0x1815E10A0
	|-GenericsUtil.CastImpl<int, Vector3>..cctor
	|
	|-RVA: 0x15E0380 Offset: 0x15DE980 VA: 0x1815E0380
	|-GenericsUtil.CastImpl<long, bool>..cctor
	|
	|-RVA: 0x15E1DC0 Offset: 0x15E03C0 VA: 0x1815E1DC0
	|-GenericsUtil.CastImpl<long, byte>..cctor
	|
	|-RVA: 0x15E3620 Offset: 0x15E1C20 VA: 0x1815E3620
	|-GenericsUtil.CastImpl<long, Guid>..cctor
	|
	|-RVA: 0x15E2090 Offset: 0x15E0690 VA: 0x1815E2090
	|-GenericsUtil.CastImpl<long, int>..cctor
	|
	|-RVA: 0x15E4430 Offset: 0x15E2A30 VA: 0x1815E4430
	|-GenericsUtil.CastImpl<long, long>..cctor
	|
	|-RVA: 0x15E4160 Offset: 0x15E2760 VA: 0x1815E4160
	|-GenericsUtil.CastImpl<long, object>..cctor
	|
	|-RVA: 0x15E0560 Offset: 0x15DEB60 VA: 0x1815E0560
	|-GenericsUtil.CastImpl<long, sbyte>..cctor
	|
	|-RVA: 0x15E1820 Offset: 0x15DFE20 VA: 0x1815E1820
	|-GenericsUtil.CastImpl<long, float>..cctor
	|
	|-RVA: 0x15DFDE0 Offset: 0x15DE3E0 VA: 0x1815DFDE0
	|-GenericsUtil.CastImpl<long, uint>..cctor
	|
	|-RVA: 0x15E3170 Offset: 0x15E1770 VA: 0x1815E3170
	|-GenericsUtil.CastImpl<long, ulong>..cctor
	|
	|-RVA: 0x15E0BF0 Offset: 0x15DF1F0 VA: 0x1815E0BF0
	|-GenericsUtil.CastImpl<long, Color>..cctor
	|
	|-RVA: 0x15E1280 Offset: 0x15DF880 VA: 0x1815E1280
	|-GenericsUtil.CastImpl<long, Ray>..cctor
	|
	|-RVA: 0x15DDE00 Offset: 0x15DC400 VA: 0x1815DDE00
	|-GenericsUtil.CastImpl<long, Vector3>..cctor
	|
	|-RVA: 0x15E2540 Offset: 0x15E0B40 VA: 0x1815E2540
	|-GenericsUtil.CastImpl<object, bool>..cctor
	|
	|-RVA: 0x15DE670 Offset: 0x15DCC70 VA: 0x1815DE670
	|-GenericsUtil.CastImpl<object, byte>..cctor
	|
	|-RVA: 0x15E3BC0 Offset: 0x15E21C0 VA: 0x1815E3BC0
	|-GenericsUtil.CastImpl<object, double>..cctor
	|
	|-RVA: 0x15DFC00 Offset: 0x15DE200 VA: 0x1815DFC00
	|-GenericsUtil.CastImpl<object, Guid>..cctor
	|
	|-RVA: 0x15E3710 Offset: 0x15E1D10 VA: 0x1815E3710
	|-GenericsUtil.CastImpl<object, short>..cctor
	|
	|-RVA: 0x15E0DD0 Offset: 0x15DF3D0 VA: 0x1815E0DD0
	|-GenericsUtil.CastImpl<object, int>..cctor
	|
	|-RVA: 0x15DE3A0 Offset: 0x15DC9A0 VA: 0x1815DE3A0
	|-GenericsUtil.CastImpl<object, long>..cctor
	|
	|-RVA: 0x15E2900 Offset: 0x15E0F00 VA: 0x1815E2900
	|-GenericsUtil.CastImpl<object, object>..cctor
	|
	|-RVA: 0x15E0CE0 Offset: 0x15DF2E0 VA: 0x1815E0CE0
	|-GenericsUtil.CastImpl<object, sbyte>..cctor
	|
	|-RVA: 0x15DE0D0 Offset: 0x15DC6D0 VA: 0x1815DE0D0
	|-GenericsUtil.CastImpl<object, float>..cctor
	|
	|-RVA: 0x15E3080 Offset: 0x15E1680 VA: 0x1815E3080
	|-GenericsUtil.CastImpl<object, ushort>..cctor
	|
	|-RVA: 0x15E4700 Offset: 0x15E2D00 VA: 0x1815E4700
	|-GenericsUtil.CastImpl<object, uint>..cctor
	|
	|-RVA: 0x15DEFD0 Offset: 0x15DD5D0 VA: 0x1815DEFD0
	|-GenericsUtil.CastImpl<object, ulong>..cctor
	|
	|-RVA: 0x15DD680 Offset: 0x15DBC80 VA: 0x1815DD680
	|-GenericsUtil.CastImpl<object, Color>..cctor
	|
	|-RVA: 0x15E1910 Offset: 0x15DFF10 VA: 0x1815E1910
	|-GenericsUtil.CastImpl<object, Ray>..cctor
	|
	|-RVA: 0x15DF570 Offset: 0x15DDB70 VA: 0x1815DF570
	|-GenericsUtil.CastImpl<object, Vector3>..cctor
	|
	|-RVA: 0x15E4070 Offset: 0x15E2670 VA: 0x1815E4070
	|-GenericsUtil.CastImpl<sbyte, bool>..cctor
	|
	|-RVA: 0x15E1730 Offset: 0x15DFD30 VA: 0x1815E1730
	|-GenericsUtil.CastImpl<sbyte, byte>..cctor
	|
	|-RVA: 0x15DE580 Offset: 0x15DCB80 VA: 0x1815DE580
	|-GenericsUtil.CastImpl<sbyte, short>..cctor
	|
	|-RVA: 0x15DDD10 Offset: 0x15DC310 VA: 0x1815DDD10
	|-GenericsUtil.CastImpl<sbyte, int>..cctor
	|
	|-RVA: 0x15DDC20 Offset: 0x15DC220 VA: 0x1815DDC20
	|-GenericsUtil.CastImpl<sbyte, long>..cctor
	|
	|-RVA: 0x15E3DA0 Offset: 0x15E23A0 VA: 0x1815E3DA0
	|-GenericsUtil.CastImpl<sbyte, object>..cctor
	|
	|-RVA: 0x15E0B00 Offset: 0x15DF100 VA: 0x1815E0B00
	|-GenericsUtil.CastImpl<sbyte, sbyte>..cctor
	|
	|-RVA: 0x15E0FB0 Offset: 0x15DF5B0 VA: 0x1815E0FB0
	|-GenericsUtil.CastImpl<sbyte, float>..cctor
	|
	|-RVA: 0x15DEA30 Offset: 0x15DD030 VA: 0x1815DEA30
	|-GenericsUtil.CastImpl<sbyte, ushort>..cctor
	|
	|-RVA: 0x15DF390 Offset: 0x15DD990 VA: 0x1815DF390
	|-GenericsUtil.CastImpl<sbyte, uint>..cctor
	|
	|-RVA: 0x15E4520 Offset: 0x15E2B20 VA: 0x1815E4520
	|-GenericsUtil.CastImpl<sbyte, ulong>..cctor
	|
	|-RVA: 0x15E1640 Offset: 0x15DFC40 VA: 0x1815E1640
	|-GenericsUtil.CastImpl<sbyte, Color>..cctor
	|
	|-RVA: 0x15E49D0 Offset: 0x15E2FD0 VA: 0x1815E49D0
	|-GenericsUtil.CastImpl<sbyte, Ray>..cctor
	|
	|-RVA: 0x15DF1B0 Offset: 0x15DD7B0 VA: 0x1815DF1B0
	|-GenericsUtil.CastImpl<sbyte, Vector3>..cctor
	|
	|-RVA: 0x15DED00 Offset: 0x15DD300 VA: 0x1815DED00
	|-GenericsUtil.CastImpl<float, bool>..cctor
	|
	|-RVA: 0x15DD590 Offset: 0x15DBB90 VA: 0x1815DD590
	|-GenericsUtil.CastImpl<float, byte>..cctor
	|
	|-RVA: 0x15E00B0 Offset: 0x15DE6B0 VA: 0x1815E00B0
	|-GenericsUtil.CastImpl<float, short>..cctor
	|
	|-RVA: 0x15E3440 Offset: 0x15E1A40 VA: 0x1815E3440
	|-GenericsUtil.CastImpl<float, int>..cctor
	|
	|-RVA: 0x15E2F90 Offset: 0x15E1590 VA: 0x1815E2F90
	|-GenericsUtil.CastImpl<float, long>..cctor
	|
	|-RVA: 0x15DE850 Offset: 0x15DCE50 VA: 0x1815DE850
	|-GenericsUtil.CastImpl<float, object>..cctor
	|
	|-RVA: 0x15DD770 Offset: 0x15DBD70 VA: 0x1815DD770
	|-GenericsUtil.CastImpl<float, sbyte>..cctor
	|
	|-RVA: 0x15E0830 Offset: 0x15DEE30 VA: 0x1815E0830
	|-GenericsUtil.CastImpl<float, float>..cctor
	|
	|-RVA: 0x15DE760 Offset: 0x15DCD60 VA: 0x1815DE760
	|-GenericsUtil.CastImpl<float, ushort>..cctor
	|
	|-RVA: 0x15E1190 Offset: 0x15DF790 VA: 0x1815E1190
	|-GenericsUtil.CastImpl<float, uint>..cctor
	|
	|-RVA: 0x15DF660 Offset: 0x15DDC60 VA: 0x1815DF660
	|-GenericsUtil.CastImpl<float, ulong>..cctor
	|
	|-RVA: 0x15E2630 Offset: 0x15E0C30 VA: 0x1815E2630
	|-GenericsUtil.CastImpl<float, Color>..cctor
	|
	|-RVA: 0x15DE2B0 Offset: 0x15DC8B0 VA: 0x1815DE2B0
	|-GenericsUtil.CastImpl<float, Ray>..cctor
	|
	|-RVA: 0x15E2DB0 Offset: 0x15E13B0 VA: 0x1815E2DB0
	|-GenericsUtil.CastImpl<float, Vector3>..cctor
	|
	|-RVA: 0x15E2AE0 Offset: 0x15E10E0 VA: 0x1815E2AE0
	|-GenericsUtil.CastImpl<ushort, bool>..cctor
	|
	|-RVA: 0x15E0290 Offset: 0x15DE890 VA: 0x1815E0290
	|-GenericsUtil.CastImpl<ushort, byte>..cctor
	|
	|-RVA: 0x15E1BE0 Offset: 0x15E01E0 VA: 0x1815E1BE0
	|-GenericsUtil.CastImpl<ushort, int>..cctor
	|
	|-RVA: 0x15E3530 Offset: 0x15E1B30 VA: 0x1815E3530
	|-GenericsUtil.CastImpl<ushort, object>..cctor
	|
	|-RVA: 0x15E2180 Offset: 0x15E0780 VA: 0x1815E2180
	|-GenericsUtil.CastImpl<ushort, sbyte>..cctor
	|
	|-RVA: 0x15E2EA0 Offset: 0x15E14A0 VA: 0x1815E2EA0
	|-GenericsUtil.CastImpl<ushort, float>..cctor
	|
	|-RVA: 0x15DD860 Offset: 0x15DBE60 VA: 0x1815DD860
	|-GenericsUtil.CastImpl<ushort, uint>..cctor
	|
	|-RVA: 0x15DFCF0 Offset: 0x15DE2F0 VA: 0x1815DFCF0
	|-GenericsUtil.CastImpl<ushort, ulong>..cctor
	|
	|-RVA: 0x15DFA20 Offset: 0x15DE020 VA: 0x1815DFA20
	|-GenericsUtil.CastImpl<ushort, Color>..cctor
	|
	|-RVA: 0x15E4340 Offset: 0x15E2940 VA: 0x1815E4340
	|-GenericsUtil.CastImpl<ushort, Ray>..cctor
	|
	|-RVA: 0x15E1CD0 Offset: 0x15E02D0 VA: 0x1815E1CD0
	|-GenericsUtil.CastImpl<ushort, Vector3>..cctor
	|
	|-RVA: 0x15DD1D0 Offset: 0x15DB7D0 VA: 0x1815DD1D0
	|-GenericsUtil.CastImpl<uint, bool>..cctor
	|
	|-RVA: 0x17EEDD0 Offset: 0x17ED3D0 VA: 0x1817EEDD0
	|-GenericsUtil.CastImpl<uint, byte>..cctor
	|
	|-RVA: 0x17EECE0 Offset: 0x17ED2E0 VA: 0x1817EECE0
	|-GenericsUtil.CastImpl<uint, short>..cctor
	|
	|-RVA: 0x17F0AE0 Offset: 0x17EF0E0 VA: 0x1817F0AE0
	|-GenericsUtil.CastImpl<uint, int>..cctor
	|
	|-RVA: 0x17EF0A0 Offset: 0x17ED6A0 VA: 0x1817EF0A0
	|-GenericsUtil.CastImpl<uint, long>..cctor
	|
	|-RVA: 0x17EE380 Offset: 0x17EC980 VA: 0x1817EE380
	|-GenericsUtil.CastImpl<uint, object>..cctor
	|
	|-RVA: 0x17EF820 Offset: 0x17EDE20 VA: 0x1817EF820
	|-GenericsUtil.CastImpl<uint, sbyte>..cctor
	|
	|-RVA: 0x17EF640 Offset: 0x17EDC40 VA: 0x1817EF640
	|-GenericsUtil.CastImpl<uint, float>..cctor
	|
	|-RVA: 0x17F0090 Offset: 0x17EE690 VA: 0x1817F0090
	|-GenericsUtil.CastImpl<uint, ushort>..cctor
	|
	|-RVA: 0x17F0CC0 Offset: 0x17EF2C0 VA: 0x1817F0CC0
	|-GenericsUtil.CastImpl<uint, uint>..cctor
	|
	|-RVA: 0x17F0270 Offset: 0x17EE870 VA: 0x1817F0270
	|-GenericsUtil.CastImpl<uint, ulong>..cctor
	|
	|-RVA: 0x17EEB00 Offset: 0x17ED100 VA: 0x1817EEB00
	|-GenericsUtil.CastImpl<uint, Color>..cctor
	|
	|-RVA: 0x17F0720 Offset: 0x17EED20 VA: 0x1817F0720
	|-GenericsUtil.CastImpl<uint, Ray>..cctor
	|
	|-RVA: 0x17EFCD0 Offset: 0x17EE2D0 VA: 0x1817EFCD0
	|-GenericsUtil.CastImpl<uint, Vector3>..cctor
	|
	|-RVA: 0x17F0F90 Offset: 0x17EF590 VA: 0x1817F0F90
	|-GenericsUtil.CastImpl<ulong, bool>..cctor
	|
	|-RVA: 0x17EEEC0 Offset: 0x17ED4C0 VA: 0x1817EEEC0
	|-GenericsUtil.CastImpl<ulong, byte>..cctor
	|
	|-RVA: 0x17EF280 Offset: 0x17ED880 VA: 0x1817EF280
	|-GenericsUtil.CastImpl<ulong, short>..cctor
	|
	|-RVA: 0x17F0EA0 Offset: 0x17EF4A0 VA: 0x1817F0EA0
	|-GenericsUtil.CastImpl<ulong, int>..cctor
	|
	|-RVA: 0x17F0360 Offset: 0x17EE960 VA: 0x1817F0360
	|-GenericsUtil.CastImpl<ulong, long>..cctor
	|
	|-RVA: 0x17EE470 Offset: 0x17ECA70 VA: 0x1817EE470
	|-GenericsUtil.CastImpl<ulong, object>..cctor
	|
	|-RVA: 0x17EE830 Offset: 0x17ECE30 VA: 0x1817EE830
	|-GenericsUtil.CastImpl<ulong, sbyte>..cctor
	|
	|-RVA: 0x17F0540 Offset: 0x17EEB40 VA: 0x1817F0540
	|-GenericsUtil.CastImpl<ulong, float>..cctor
	|
	|-RVA: 0x17EEFB0 Offset: 0x17ED5B0 VA: 0x1817EEFB0
	|-GenericsUtil.CastImpl<ulong, ushort>..cctor
	|
	|-RVA: 0x17F1530 Offset: 0x17EFB30 VA: 0x1817F1530
	|-GenericsUtil.CastImpl<ulong, uint>..cctor
	|
	|-RVA: 0x17EFBE0 Offset: 0x17EE1E0 VA: 0x1817EFBE0
	|-GenericsUtil.CastImpl<ulong, ulong>..cctor
	|
	|-RVA: 0x17F1710 Offset: 0x17EFD10 VA: 0x1817F1710
	|-GenericsUtil.CastImpl<ulong, Color>..cctor
	|
	|-RVA: 0x17EFA00 Offset: 0x17EE000 VA: 0x1817EFA00
	|-GenericsUtil.CastImpl<ulong, Ray>..cctor
	|
	|-RVA: 0x17EF460 Offset: 0x17EDA60 VA: 0x1817EF460
	|-GenericsUtil.CastImpl<ulong, Vector3>..cctor
	|
	|-RVA: 0x17EFEB0 Offset: 0x17EE4B0 VA: 0x1817EFEB0
	|-GenericsUtil.CastImpl<Color, bool>..cctor
	|
	|-RVA: 0x17F1260 Offset: 0x17EF860 VA: 0x1817F1260
	|-GenericsUtil.CastImpl<Color, byte>..cctor
	|
	|-RVA: 0x17F0630 Offset: 0x17EEC30 VA: 0x1817F0630
	|-GenericsUtil.CastImpl<Color, short>..cctor
	|
	|-RVA: 0x17EEA10 Offset: 0x17ED010 VA: 0x1817EEA10
	|-GenericsUtil.CastImpl<Color, int>..cctor
	|
	|-RVA: 0x17F19E0 Offset: 0x17EFFE0 VA: 0x1817F19E0
	|-GenericsUtil.CastImpl<Color, long>..cctor
	|
	|-RVA: 0x17EDC00 Offset: 0x17EC200 VA: 0x1817EDC00
	|-GenericsUtil.CastImpl<Color, object>..cctor
	|
	|-RVA: 0x17F0900 Offset: 0x17EEF00 VA: 0x1817F0900
	|-GenericsUtil.CastImpl<Color, sbyte>..cctor
	|
	|-RVA: 0x17F18F0 Offset: 0x17EFEF0 VA: 0x1817F18F0
	|-GenericsUtil.CastImpl<Color, float>..cctor
	|
	|-RVA: 0x17F1350 Offset: 0x17EF950 VA: 0x1817F1350
	|-GenericsUtil.CastImpl<Color, ushort>..cctor
	|
	|-RVA: 0x17EE740 Offset: 0x17ECD40 VA: 0x1817EE740
	|-GenericsUtil.CastImpl<Color, uint>..cctor
	|
	|-RVA: 0x17F0BD0 Offset: 0x17EF1D0 VA: 0x1817F0BD0
	|-GenericsUtil.CastImpl<Color, ulong>..cctor
	|
	|-RVA: 0x17F1620 Offset: 0x17EFC20 VA: 0x1817F1620
	|-GenericsUtil.CastImpl<Color, Color>..cctor
	|
	|-RVA: 0x17EFFA0 Offset: 0x17EE5A0 VA: 0x1817EFFA0
	|-GenericsUtil.CastImpl<Color, Ray>..cctor
	|
	|-RVA: 0x17EF730 Offset: 0x17EDD30 VA: 0x1817EF730
	|-GenericsUtil.CastImpl<Color, Vector3>..cctor
	|
	|-RVA: 0x17F0810 Offset: 0x17EEE10 VA: 0x1817F0810
	|-GenericsUtil.CastImpl<Ray, bool>..cctor
	|
	|-RVA: 0x17EE290 Offset: 0x17EC890 VA: 0x1817EE290
	|-GenericsUtil.CastImpl<Ray, byte>..cctor
	|
	|-RVA: 0x17EDFC0 Offset: 0x17EC5C0 VA: 0x1817EDFC0
	|-GenericsUtil.CastImpl<Ray, short>..cctor
	|
	|-RVA: 0x17EDDE0 Offset: 0x17EC3E0 VA: 0x1817EDDE0
	|-GenericsUtil.CastImpl<Ray, int>..cctor
	|
	|-RVA: 0x17F09F0 Offset: 0x17EEFF0 VA: 0x1817F09F0
	|-GenericsUtil.CastImpl<Ray, long>..cctor
	|
	|-RVA: 0x17F0DB0 Offset: 0x17EF3B0 VA: 0x1817F0DB0
	|-GenericsUtil.CastImpl<Ray, object>..cctor
	|
	|-RVA: 0x17F1080 Offset: 0x17EF680 VA: 0x1817F1080
	|-GenericsUtil.CastImpl<Ray, sbyte>..cctor
	|
	|-RVA: 0x17EF910 Offset: 0x17EDF10 VA: 0x1817EF910
	|-GenericsUtil.CastImpl<Ray, float>..cctor
	|
	|-RVA: 0x17F1170 Offset: 0x17EF770 VA: 0x1817F1170
	|-GenericsUtil.CastImpl<Ray, ushort>..cctor
	|
	|-RVA: 0x17EE560 Offset: 0x17ECB60 VA: 0x1817EE560
	|-GenericsUtil.CastImpl<Ray, uint>..cctor
	|
	|-RVA: 0x17EF370 Offset: 0x17ED970 VA: 0x1817EF370
	|-GenericsUtil.CastImpl<Ray, ulong>..cctor
	|
	|-RVA: 0x17EE1A0 Offset: 0x17EC7A0 VA: 0x1817EE1A0
	|-GenericsUtil.CastImpl<Ray, Color>..cctor
	|
	|-RVA: 0x17EF190 Offset: 0x17ED790 VA: 0x1817EF190
	|-GenericsUtil.CastImpl<Ray, Ray>..cctor
	|
	|-RVA: 0x17EF550 Offset: 0x17EDB50 VA: 0x1817EF550
	|-GenericsUtil.CastImpl<Ray, Vector3>..cctor
	|
	|-RVA: 0x17EE0B0 Offset: 0x17EC6B0 VA: 0x1817EE0B0
	|-GenericsUtil.CastImpl<Vector3, bool>..cctor
	|
	|-RVA: 0x17F0180 Offset: 0x17EE780 VA: 0x1817F0180
	|-GenericsUtil.CastImpl<Vector3, byte>..cctor
	|
	|-RVA: 0x17EFDC0 Offset: 0x17EE3C0 VA: 0x1817EFDC0
	|-GenericsUtil.CastImpl<Vector3, short>..cctor
	|
	|-RVA: 0x17EFAF0 Offset: 0x17EE0F0 VA: 0x1817EFAF0
	|-GenericsUtil.CastImpl<Vector3, int>..cctor
	|
	|-RVA: 0x17EEBF0 Offset: 0x17ED1F0 VA: 0x1817EEBF0
	|-GenericsUtil.CastImpl<Vector3, long>..cctor
	|
	|-RVA: 0x17EDA20 Offset: 0x17EC020 VA: 0x1817EDA20
	|-GenericsUtil.CastImpl<Vector3, object>..cctor
	|
	|-RVA: 0x17EDB10 Offset: 0x17EC110 VA: 0x1817EDB10
	|-GenericsUtil.CastImpl<Vector3, sbyte>..cctor
	|
	|-RVA: 0x17F0450 Offset: 0x17EEA50 VA: 0x1817F0450
	|-GenericsUtil.CastImpl<Vector3, float>..cctor
	|
	|-RVA: 0x17EDCF0 Offset: 0x17EC2F0 VA: 0x1817EDCF0
	|-GenericsUtil.CastImpl<Vector3, ushort>..cctor
	|
	|-RVA: 0x17EE650 Offset: 0x17ECC50 VA: 0x1817EE650
	|-GenericsUtil.CastImpl<Vector3, uint>..cctor
	|
	|-RVA: 0x17F1800 Offset: 0x17EFE00 VA: 0x1817F1800
	|-GenericsUtil.CastImpl<Vector3, ulong>..cctor
	|
	|-RVA: 0x17F1440 Offset: 0x17EFA40 VA: 0x1817F1440
	|-GenericsUtil.CastImpl<Vector3, Color>..cctor
	|
	|-RVA: 0x17EDED0 Offset: 0x17EC4D0 VA: 0x1817EDED0
	|-GenericsUtil.CastImpl<Vector3, Ray>..cctor
	|
	|-RVA: 0x17EE920 Offset: 0x17ECF20 VA: 0x1817EE920
	|-GenericsUtil.CastImpl<Vector3, Vector3>..cctor
	*/

}

