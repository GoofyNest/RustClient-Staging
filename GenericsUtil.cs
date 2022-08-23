public static class GenericsUtil // TypeDefIndex: 4817
{
	public static TDst Cast<TSrc, TDst>(TSrc obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A3340 Offset: 0x15A1940 VA: 0x1815A3340
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
	|-RVA: 0x15A35D0 Offset: 0x15A1BD0 VA: 0x1815A35D0
	|-GenericsUtil.Cast<bool, short>
	|-GenericsUtil.Cast<bool, ushort>
	|-GenericsUtil.Cast<byte, short>
	|-GenericsUtil.Cast<byte, ushort>
	|-GenericsUtil.Cast<sbyte, short>
	|-GenericsUtil.Cast<sbyte, ushort>
	|
	|-RVA: 0x15A3710 Offset: 0x15A1D10 VA: 0x1815A3710
	|-GenericsUtil.Cast<bool, int>
	|-GenericsUtil.Cast<bool, uint>
	|-GenericsUtil.Cast<byte, int>
	|-GenericsUtil.Cast<byte, uint>
	|-GenericsUtil.Cast<sbyte, int>
	|-GenericsUtil.Cast<sbyte, uint>
	|
	|-RVA: 0x15A3850 Offset: 0x15A1E50 VA: 0x1815A3850
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
	|-RVA: 0x15A3AE0 Offset: 0x15A20E0 VA: 0x1815A3AE0
	|-GenericsUtil.Cast<bool, float>
	|-GenericsUtil.Cast<byte, float>
	|-GenericsUtil.Cast<sbyte, float>
	|
	|-RVA: 0x15A3480 Offset: 0x15A1A80 VA: 0x1815A3480
	|-GenericsUtil.Cast<bool, Color>
	|-GenericsUtil.Cast<byte, Color>
	|-GenericsUtil.Cast<sbyte, Color>
	|
	|-RVA: 0x15A3990 Offset: 0x15A1F90 VA: 0x1815A3990
	|-GenericsUtil.Cast<bool, Ray>
	|-GenericsUtil.Cast<byte, Ray>
	|-GenericsUtil.Cast<sbyte, Ray>
	|
	|-RVA: 0x15A3C20 Offset: 0x15A2220 VA: 0x1815A3C20
	|-GenericsUtil.Cast<bool, Vector3>
	|-GenericsUtil.Cast<byte, Vector3>
	|-GenericsUtil.Cast<sbyte, Vector3>
	|
	|-RVA: 0x15A4140 Offset: 0x15A2740 VA: 0x1815A4140
	|-GenericsUtil.Cast<Guid, int>
	|-GenericsUtil.Cast<Color, int>
	|-GenericsUtil.Cast<Color, uint>
	|
	|-RVA: 0x15A4280 Offset: 0x15A2880 VA: 0x1815A4280
	|-GenericsUtil.Cast<Guid, long>
	|-GenericsUtil.Cast<Guid, object>
	|-GenericsUtil.Cast<Color, long>
	|-GenericsUtil.Cast<Color, object>
	|-GenericsUtil.Cast<Color, ulong>
	|
	|-RVA: 0x15A47C0 Offset: 0x15A2DC0 VA: 0x1815A47C0
	|-GenericsUtil.Cast<int, bool>
	|-GenericsUtil.Cast<int, byte>
	|-GenericsUtil.Cast<int, sbyte>
	|-GenericsUtil.Cast<uint, bool>
	|-GenericsUtil.Cast<uint, byte>
	|-GenericsUtil.Cast<uint, sbyte>
	|
	|-RVA: 0x15A4A50 Offset: 0x15A3050 VA: 0x1815A4A50
	|-GenericsUtil.Cast<int, double>
	|
	|-RVA: 0x15A4900 Offset: 0x15A2F00 VA: 0x1815A4900
	|-GenericsUtil.Cast<int, Guid>
	|-GenericsUtil.Cast<int, Color>
	|-GenericsUtil.Cast<uint, Color>
	|
	|-RVA: 0x15A4B90 Offset: 0x15A3190 VA: 0x1815A4B90
	|-GenericsUtil.Cast<int, short>
	|-GenericsUtil.Cast<int, ushort>
	|-GenericsUtil.Cast<uint, short>
	|-GenericsUtil.Cast<uint, ushort>
	|
	|-RVA: 0x15A4CD0 Offset: 0x15A32D0 VA: 0x1815A4CD0
	|-GenericsUtil.Cast<int, int>
	|-GenericsUtil.Cast<int, uint>
	|-GenericsUtil.Cast<uint, int>
	|-GenericsUtil.Cast<uint, uint>
	|
	|-RVA: 0x15A4E00 Offset: 0x15A3400 VA: 0x1815A4E00
	|-GenericsUtil.Cast<int, long>
	|-GenericsUtil.Cast<int, object>
	|-GenericsUtil.Cast<int, ulong>
	|-GenericsUtil.Cast<uint, long>
	|-GenericsUtil.Cast<uint, object>
	|-GenericsUtil.Cast<uint, ulong>
	|
	|-RVA: 0x15A5090 Offset: 0x15A3690 VA: 0x1815A5090
	|-GenericsUtil.Cast<int, float>
	|-GenericsUtil.Cast<uint, float>
	|
	|-RVA: 0x15A4F40 Offset: 0x15A3540 VA: 0x1815A4F40
	|-GenericsUtil.Cast<int, Ray>
	|-GenericsUtil.Cast<uint, Ray>
	|
	|-RVA: 0x15A51D0 Offset: 0x15A37D0 VA: 0x1815A51D0
	|-GenericsUtil.Cast<int, Vector3>
	|-GenericsUtil.Cast<uint, Vector3>
	|
	|-RVA: 0x15A5320 Offset: 0x15A3920 VA: 0x1815A5320
	|-GenericsUtil.Cast<long, int>
	|-GenericsUtil.Cast<ulong, int>
	|-GenericsUtil.Cast<ulong, uint>
	|
	|-RVA: 0x15A5460 Offset: 0x15A3A60 VA: 0x1815A5460
	|-GenericsUtil.Cast<long, long>
	|-GenericsUtil.Cast<long, object>
	|-GenericsUtil.Cast<ulong, long>
	|-GenericsUtil.Cast<ulong, object>
	|-GenericsUtil.Cast<ulong, ulong>
	|
	|-RVA: 0x15A6010 Offset: 0x15A4610 VA: 0x1815A6010
	|-GenericsUtil.Cast<object, bool>
	|-GenericsUtil.Cast<object, byte>
	|-GenericsUtil.Cast<object, sbyte>
	|
	|-RVA: 0x15A62B0 Offset: 0x15A48B0 VA: 0x1815A62B0
	|-GenericsUtil.Cast<object, double>
	|
	|-RVA: 0x15A6150 Offset: 0x15A4750 VA: 0x1815A6150
	|-GenericsUtil.Cast<object, Guid>
	|-GenericsUtil.Cast<object, Color>
	|
	|-RVA: 0x15A63F0 Offset: 0x15A49F0 VA: 0x1815A63F0
	|-GenericsUtil.Cast<object, short>
	|-GenericsUtil.Cast<object, ushort>
	|
	|-RVA: 0x15A6530 Offset: 0x15A4B30 VA: 0x1815A6530
	|-GenericsUtil.Cast<object, int>
	|-GenericsUtil.Cast<object, uint>
	|
	|-RVA: 0x15A6670 Offset: 0x15A4C70 VA: 0x1815A6670
	|-GenericsUtil.Cast<object, long>
	|-GenericsUtil.Cast<object, object>
	|-GenericsUtil.Cast<object, ulong>
	|
	|-RVA: 0x15A6910 Offset: 0x15A4F10 VA: 0x1815A6910
	|-GenericsUtil.Cast<object, float>
	|
	|-RVA: 0x15A67B0 Offset: 0x15A4DB0 VA: 0x1815A67B0
	|-GenericsUtil.Cast<object, Ray>
	|
	|-RVA: 0x15A6A50 Offset: 0x15A5050 VA: 0x1815A6A50
	|-GenericsUtil.Cast<object, Vector3>
	|
	|-RVA: 0x15A6BB0 Offset: 0x15A51B0 VA: 0x1815A6BB0
	|-GenericsUtil.Cast<float, bool>
	|-GenericsUtil.Cast<float, byte>
	|-GenericsUtil.Cast<float, sbyte>
	|
	|-RVA: 0x15A6E40 Offset: 0x15A5440 VA: 0x1815A6E40
	|-GenericsUtil.Cast<float, short>
	|-GenericsUtil.Cast<float, ushort>
	|
	|-RVA: 0x15A6F80 Offset: 0x15A5580 VA: 0x1815A6F80
	|-GenericsUtil.Cast<float, int>
	|-GenericsUtil.Cast<float, uint>
	|
	|-RVA: 0x15A70C0 Offset: 0x15A56C0 VA: 0x1815A70C0
	|-GenericsUtil.Cast<float, long>
	|-GenericsUtil.Cast<float, object>
	|-GenericsUtil.Cast<float, ulong>
	|
	|-RVA: 0x15A7360 Offset: 0x15A5960 VA: 0x1815A7360
	|-GenericsUtil.Cast<float, float>
	|
	|-RVA: 0x15A6CF0 Offset: 0x15A52F0 VA: 0x1815A6CF0
	|-GenericsUtil.Cast<float, Color>
	|
	|-RVA: 0x15A7200 Offset: 0x15A5800 VA: 0x1815A7200
	|-GenericsUtil.Cast<float, Ray>
	|
	|-RVA: 0x15A74A0 Offset: 0x15A5AA0 VA: 0x1815A74A0
	|-GenericsUtil.Cast<float, Vector3>
	|
	|-RVA: 0x15A75F0 Offset: 0x15A5BF0 VA: 0x1815A75F0
	|-GenericsUtil.Cast<ulong, bool>
	|-GenericsUtil.Cast<ulong, byte>
	|-GenericsUtil.Cast<ulong, sbyte>
	|
	|-RVA: 0x15A7880 Offset: 0x15A5E80 VA: 0x1815A7880
	|-GenericsUtil.Cast<ulong, short>
	|-GenericsUtil.Cast<ulong, ushort>
	|
	|-RVA: 0x15A7B10 Offset: 0x15A6110 VA: 0x1815A7B10
	|-GenericsUtil.Cast<ulong, float>
	|
	|-RVA: 0x15A7730 Offset: 0x15A5D30 VA: 0x1815A7730
	|-GenericsUtil.Cast<ulong, Color>
	|
	|-RVA: 0x15A79C0 Offset: 0x15A5FC0 VA: 0x1815A79C0
	|-GenericsUtil.Cast<ulong, Ray>
	|
	|-RVA: 0x15A7C50 Offset: 0x15A6250 VA: 0x1815A7C50
	|-GenericsUtil.Cast<ulong, Vector3>
	|
	|-RVA: 0x15A3D70 Offset: 0x15A2370 VA: 0x1815A3D70
	|-GenericsUtil.Cast<Color, bool>
	|-GenericsUtil.Cast<Color, byte>
	|-GenericsUtil.Cast<Color, sbyte>
	|
	|-RVA: 0x15A4000 Offset: 0x15A2600 VA: 0x1815A4000
	|-GenericsUtil.Cast<Color, short>
	|-GenericsUtil.Cast<Color, ushort>
	|
	|-RVA: 0x15A4520 Offset: 0x15A2B20 VA: 0x1815A4520
	|-GenericsUtil.Cast<Color, float>
	|
	|-RVA: 0x15A3EB0 Offset: 0x15A24B0 VA: 0x1815A3EB0
	|-GenericsUtil.Cast<Color, Color>
	|
	|-RVA: 0x15A43C0 Offset: 0x15A29C0 VA: 0x1815A43C0
	|-GenericsUtil.Cast<Color, Ray>
	|
	|-RVA: 0x15A4660 Offset: 0x15A2C60 VA: 0x1815A4660
	|-GenericsUtil.Cast<Color, Vector3>
	|
	|-RVA: 0x15A55A0 Offset: 0x15A3BA0 VA: 0x1815A55A0
	|-GenericsUtil.Cast<Ray, bool>
	|-GenericsUtil.Cast<Ray, byte>
	|-GenericsUtil.Cast<Ray, sbyte>
	|
	|-RVA: 0x15A5840 Offset: 0x15A3E40 VA: 0x1815A5840
	|-GenericsUtil.Cast<Ray, short>
	|-GenericsUtil.Cast<Ray, ushort>
	|
	|-RVA: 0x15A5980 Offset: 0x15A3F80 VA: 0x1815A5980
	|-GenericsUtil.Cast<Ray, int>
	|-GenericsUtil.Cast<Ray, uint>
	|
	|-RVA: 0x15A5AC0 Offset: 0x15A40C0 VA: 0x1815A5AC0
	|-GenericsUtil.Cast<Ray, long>
	|-GenericsUtil.Cast<Ray, object>
	|-GenericsUtil.Cast<Ray, ulong>
	|
	|-RVA: 0x15A5D60 Offset: 0x15A4360 VA: 0x1815A5D60
	|-GenericsUtil.Cast<Ray, float>
	|
	|-RVA: 0x15A56E0 Offset: 0x15A3CE0 VA: 0x1815A56E0
	|-GenericsUtil.Cast<Ray, Color>
	|
	|-RVA: 0x15A5C00 Offset: 0x15A4200 VA: 0x1815A5C00
	|-GenericsUtil.Cast<Ray, Ray>
	|
	|-RVA: 0x15A5EB0 Offset: 0x15A44B0 VA: 0x1815A5EB0
	|-GenericsUtil.Cast<Ray, Vector3>
	|
	|-RVA: 0x15A7DA0 Offset: 0x15A63A0 VA: 0x1815A7DA0
	|-GenericsUtil.Cast<Vector3, bool>
	|-GenericsUtil.Cast<Vector3, byte>
	|-GenericsUtil.Cast<Vector3, sbyte>
	|
	|-RVA: 0x15A8040 Offset: 0x15A6640 VA: 0x1815A8040
	|-GenericsUtil.Cast<Vector3, short>
	|-GenericsUtil.Cast<Vector3, ushort>
	|
	|-RVA: 0x15A8180 Offset: 0x15A6780 VA: 0x1815A8180
	|-GenericsUtil.Cast<Vector3, int>
	|-GenericsUtil.Cast<Vector3, uint>
	|
	|-RVA: 0x15A82C0 Offset: 0x15A68C0 VA: 0x1815A82C0
	|-GenericsUtil.Cast<Vector3, long>
	|-GenericsUtil.Cast<Vector3, object>
	|-GenericsUtil.Cast<Vector3, ulong>
	|
	|-RVA: 0x15A8560 Offset: 0x15A6B60 VA: 0x1815A8560
	|-GenericsUtil.Cast<Vector3, float>
	|
	|-RVA: 0x15A7EE0 Offset: 0x15A64E0 VA: 0x1815A7EE0
	|-GenericsUtil.Cast<Vector3, Color>
	|
	|-RVA: 0x15A8400 Offset: 0x15A6A00 VA: 0x1815A8400
	|-GenericsUtil.Cast<Vector3, Ray>
	|
	|-RVA: 0x15A86A0 Offset: 0x15A6CA0 VA: 0x1815A86A0
	|-GenericsUtil.Cast<Vector3, Vector3>
	*/

	public static void Swap<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x570F50 Offset: 0x56F550 VA: 0x180570F50
	|-GenericsUtil.Swap<List<PlaceMonuments.SpawnInfo>>
	|-GenericsUtil.Swap<List<PlaceMonumentsOffshore.SpawnInfo>>
	|-GenericsUtil.Swap<List<PlaceMonumentsRailside.SpawnInfo>>
	|-GenericsUtil.Swap<List<PlaceMonumentsRoadside.SpawnInfo>>
	|-GenericsUtil.Swap<object>
	|-GenericsUtil.Swap<float[]>
	*/

}

private static class GenericsUtil.CastImpl<TSrc, TDst> // TypeDefIndex: 4818
{	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static TSrc Value; // 0xFFFFFFFF


	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1890570 Offset: 0x188EB70 VA: 0x181890570
	|-GenericsUtil.CastImpl<bool, bool>..cctor
	|
	|-RVA: 0x188A6C0 Offset: 0x1888CC0 VA: 0x18188A6C0
	|-GenericsUtil.CastImpl<bool, byte>..cctor
	|
	|-RVA: 0x188FDF0 Offset: 0x188E3F0 VA: 0x18188FDF0
	|-GenericsUtil.CastImpl<bool, short>..cctor
	|
	|-RVA: 0x18894F0 Offset: 0x1887AF0 VA: 0x1818894F0
	|-GenericsUtil.CastImpl<bool, int>..cctor
	|
	|-RVA: 0x1889A90 Offset: 0x1888090 VA: 0x181889A90
	|-GenericsUtil.CastImpl<bool, long>..cctor
	|
	|-RVA: 0x188AB70 Offset: 0x1889170 VA: 0x18188AB70
	|-GenericsUtil.CastImpl<bool, object>..cctor
	|
	|-RVA: 0x1890CF0 Offset: 0x188F2F0 VA: 0x181890CF0
	|-GenericsUtil.CastImpl<bool, sbyte>..cctor
	|
	|-RVA: 0x1891740 Offset: 0x188FD40 VA: 0x181891740
	|-GenericsUtil.CastImpl<bool, float>..cctor
	|
	|-RVA: 0x188D0F0 Offset: 0x188B6F0 VA: 0x18188D0F0
	|-GenericsUtil.CastImpl<bool, ushort>..cctor
	|
	|-RVA: 0x188A030 Offset: 0x1888630 VA: 0x18188A030
	|-GenericsUtil.CastImpl<bool, uint>..cctor
	|
	|-RVA: 0x1890660 Offset: 0x188EC60 VA: 0x181890660
	|-GenericsUtil.CastImpl<bool, ulong>..cctor
	|
	|-RVA: 0x188B110 Offset: 0x1889710 VA: 0x18188B110
	|-GenericsUtil.CastImpl<bool, Color>..cctor
	|
	|-RVA: 0x188B980 Offset: 0x1889F80 VA: 0x18188B980
	|-GenericsUtil.CastImpl<bool, Ray>..cctor
	|
	|-RVA: 0x1889B80 Offset: 0x1888180 VA: 0x181889B80
	|-GenericsUtil.CastImpl<bool, Vector3>..cctor
	|
	|-RVA: 0x188C4C0 Offset: 0x188AAC0 VA: 0x18188C4C0
	|-GenericsUtil.CastImpl<byte, bool>..cctor
	|
	|-RVA: 0x188AE40 Offset: 0x1889440 VA: 0x18188AE40
	|-GenericsUtil.CastImpl<byte, byte>..cctor
	|
	|-RVA: 0x1891650 Offset: 0x188FC50 VA: 0x181891650
	|-GenericsUtil.CastImpl<byte, short>..cctor
	|
	|-RVA: 0x188B5C0 Offset: 0x1889BC0 VA: 0x18188B5C0
	|-GenericsUtil.CastImpl<byte, int>..cctor
	|
	|-RVA: 0x188E860 Offset: 0x188CE60 VA: 0x18188E860
	|-GenericsUtil.CastImpl<byte, long>..cctor
	|
	|-RVA: 0x188E3B0 Offset: 0x188C9B0 VA: 0x18188E3B0
	|-GenericsUtil.CastImpl<byte, object>..cctor
	|
	|-RVA: 0x1889400 Offset: 0x1887A00 VA: 0x181889400
	|-GenericsUtil.CastImpl<byte, sbyte>..cctor
	|
	|-RVA: 0x188B200 Offset: 0x1889800 VA: 0x18188B200
	|-GenericsUtil.CastImpl<byte, float>..cctor
	|
	|-RVA: 0x188F3A0 Offset: 0x188D9A0 VA: 0x18188F3A0
	|-GenericsUtil.CastImpl<byte, ushort>..cctor
	|
	|-RVA: 0x188A3F0 Offset: 0x18889F0 VA: 0x18188A3F0
	|-GenericsUtil.CastImpl<byte, uint>..cctor
	|
	|-RVA: 0x1889C70 Offset: 0x1888270 VA: 0x181889C70
	|-GenericsUtil.CastImpl<byte, ulong>..cctor
	|
	|-RVA: 0x188CD30 Offset: 0x188B330 VA: 0x18188CD30
	|-GenericsUtil.CastImpl<byte, Color>..cctor
	|
	|-RVA: 0x18895E0 Offset: 0x1887BE0 VA: 0x1818895E0
	|-GenericsUtil.CastImpl<byte, Ray>..cctor
	|
	|-RVA: 0x188D690 Offset: 0x188BC90 VA: 0x18188D690
	|-GenericsUtil.CastImpl<byte, Vector3>..cctor
	|
	|-RVA: 0x188F0D0 Offset: 0x188D6D0 VA: 0x18188F0D0
	|-GenericsUtil.CastImpl<double, int>..cctor
	|
	|-RVA: 0x1890750 Offset: 0x188ED50 VA: 0x181890750
	|-GenericsUtil.CastImpl<double, object>..cctor
	|
	|-RVA: 0x188DD20 Offset: 0x188C320 VA: 0x18188DD20
	|-GenericsUtil.CastImpl<Guid, int>..cctor
	|
	|-RVA: 0x188BD40 Offset: 0x188A340 VA: 0x18188BD40
	|-GenericsUtil.CastImpl<Guid, long>..cctor
	|
	|-RVA: 0x188A120 Offset: 0x1888720 VA: 0x18188A120
	|-GenericsUtil.CastImpl<Guid, object>..cctor
	|
	|-RVA: 0x1891470 Offset: 0x188FA70 VA: 0x181891470
	|-GenericsUtil.CastImpl<short, bool>..cctor
	|
	|-RVA: 0x188D1E0 Offset: 0x188B7E0 VA: 0x18188D1E0
	|-GenericsUtil.CastImpl<short, byte>..cctor
	|
	|-RVA: 0x188B3E0 Offset: 0x18899E0 VA: 0x18188B3E0
	|-GenericsUtil.CastImpl<short, int>..cctor
	|
	|-RVA: 0x188BC50 Offset: 0x188A250 VA: 0x18188BC50
	|-GenericsUtil.CastImpl<short, object>..cctor
	|
	|-RVA: 0x188F580 Offset: 0x188DB80 VA: 0x18188F580
	|-GenericsUtil.CastImpl<short, sbyte>..cctor
	|
	|-RVA: 0x188EB30 Offset: 0x188D130 VA: 0x18188EB30
	|-GenericsUtil.CastImpl<short, float>..cctor
	|
	|-RVA: 0x188EC20 Offset: 0x188D220 VA: 0x18188EC20
	|-GenericsUtil.CastImpl<short, uint>..cctor
	|
	|-RVA: 0x188EFE0 Offset: 0x188D5E0 VA: 0x18188EFE0
	|-GenericsUtil.CastImpl<short, ulong>..cctor
	|
	|-RVA: 0x188BE30 Offset: 0x188A430 VA: 0x18188BE30
	|-GenericsUtil.CastImpl<short, Color>..cctor
	|
	|-RVA: 0x188F760 Offset: 0x188DD60 VA: 0x18188F760
	|-GenericsUtil.CastImpl<short, Ray>..cctor
	|
	|-RVA: 0x188AD50 Offset: 0x1889350 VA: 0x18188AD50
	|-GenericsUtil.CastImpl<short, Vector3>..cctor
	|
	|-RVA: 0x188FD00 Offset: 0x188E300 VA: 0x18188FD00
	|-GenericsUtil.CastImpl<int, bool>..cctor
	|
	|-RVA: 0x1890A20 Offset: 0x188F020 VA: 0x181890A20
	|-GenericsUtil.CastImpl<int, byte>..cctor
	|
	|-RVA: 0x188C010 Offset: 0x188A610 VA: 0x18188C010
	|-GenericsUtil.CastImpl<int, double>..cctor
	|
	|-RVA: 0x188E770 Offset: 0x188CD70 VA: 0x18188E770
	|-GenericsUtil.CastImpl<int, Guid>..cctor
	|
	|-RVA: 0x188E2C0 Offset: 0x188C8C0 VA: 0x18188E2C0
	|-GenericsUtil.CastImpl<int, short>..cctor
	|
	|-RVA: 0x188C5B0 Offset: 0x188ABB0 VA: 0x18188C5B0
	|-GenericsUtil.CastImpl<int, int>..cctor
	|
	|-RVA: 0x188DC30 Offset: 0x188C230 VA: 0x18188DC30
	|-GenericsUtil.CastImpl<int, long>..cctor
	|
	|-RVA: 0x188DB40 Offset: 0x188C140 VA: 0x18188DB40
	|-GenericsUtil.CastImpl<int, object>..cctor
	|
	|-RVA: 0x18910B0 Offset: 0x188F6B0 VA: 0x1818910B0
	|-GenericsUtil.CastImpl<int, sbyte>..cctor
	|
	|-RVA: 0x1890DE0 Offset: 0x188F3E0 VA: 0x181890DE0
	|-GenericsUtil.CastImpl<int, float>..cctor
	|
	|-RVA: 0x188ED10 Offset: 0x188D310 VA: 0x18188ED10
	|-GenericsUtil.CastImpl<int, ushort>..cctor
	|
	|-RVA: 0x188CE20 Offset: 0x188B420 VA: 0x18188CE20
	|-GenericsUtil.CastImpl<int, uint>..cctor
	|
	|-RVA: 0x1890480 Offset: 0x188EA80 VA: 0x181890480
	|-GenericsUtil.CastImpl<int, ulong>..cctor
	|
	|-RVA: 0x188C790 Offset: 0x188AD90 VA: 0x18188C790
	|-GenericsUtil.CastImpl<int, Color>..cctor
	|
	|-RVA: 0x188CA60 Offset: 0x188B060 VA: 0x18188CA60
	|-GenericsUtil.CastImpl<int, Ray>..cctor
	|
	|-RVA: 0x188D870 Offset: 0x188BE70 VA: 0x18188D870
	|-GenericsUtil.CastImpl<int, Vector3>..cctor
	|
	|-RVA: 0x188C970 Offset: 0x188AF70 VA: 0x18188C970
	|-GenericsUtil.CastImpl<long, bool>..cctor
	|
	|-RVA: 0x188E680 Offset: 0x188CC80 VA: 0x18188E680
	|-GenericsUtil.CastImpl<long, byte>..cctor
	|
	|-RVA: 0x18901B0 Offset: 0x188E7B0 VA: 0x1818901B0
	|-GenericsUtil.CastImpl<long, Guid>..cctor
	|
	|-RVA: 0x188E950 Offset: 0x188CF50 VA: 0x18188E950
	|-GenericsUtil.CastImpl<long, int>..cctor
	|
	|-RVA: 0x1891290 Offset: 0x188F890 VA: 0x181891290
	|-GenericsUtil.CastImpl<long, long>..cctor
	|
	|-RVA: 0x1890FC0 Offset: 0x188F5C0 VA: 0x181890FC0
	|-GenericsUtil.CastImpl<long, object>..cctor
	|
	|-RVA: 0x188CB50 Offset: 0x188B150 VA: 0x18188CB50
	|-GenericsUtil.CastImpl<long, sbyte>..cctor
	|
	|-RVA: 0x188E0E0 Offset: 0x188C6E0 VA: 0x18188E0E0
	|-GenericsUtil.CastImpl<long, float>..cctor
	|
	|-RVA: 0x188C3D0 Offset: 0x188A9D0 VA: 0x18188C3D0
	|-GenericsUtil.CastImpl<long, uint>..cctor
	|
	|-RVA: 0x188FC10 Offset: 0x188E210 VA: 0x18188FC10
	|-GenericsUtil.CastImpl<long, ulong>..cctor
	|
	|-RVA: 0x188D3C0 Offset: 0x188B9C0 VA: 0x18188D3C0
	|-GenericsUtil.CastImpl<long, Color>..cctor
	|
	|-RVA: 0x188DA50 Offset: 0x188C050 VA: 0x18188DA50
	|-GenericsUtil.CastImpl<long, Ray>..cctor
	|
	|-RVA: 0x1889F40 Offset: 0x1888540 VA: 0x181889F40
	|-GenericsUtil.CastImpl<long, Vector3>..cctor
	|
	|-RVA: 0x188EE00 Offset: 0x188D400 VA: 0x18188EE00
	|-GenericsUtil.CastImpl<object, bool>..cctor
	|
	|-RVA: 0x188A8A0 Offset: 0x1888EA0 VA: 0x18188A8A0
	|-GenericsUtil.CastImpl<object, byte>..cctor
	|
	|-RVA: 0x1890840 Offset: 0x188EE40 VA: 0x181890840
	|-GenericsUtil.CastImpl<object, double>..cctor
	|
	|-RVA: 0x188C100 Offset: 0x188A700 VA: 0x18188C100
	|-GenericsUtil.CastImpl<object, Guid>..cctor
	|
	|-RVA: 0x1890390 Offset: 0x188E990 VA: 0x181890390
	|-GenericsUtil.CastImpl<object, short>..cctor
	|
	|-RVA: 0x188D5A0 Offset: 0x188BBA0 VA: 0x18188D5A0
	|-GenericsUtil.CastImpl<object, int>..cctor
	|
	|-RVA: 0x188A5D0 Offset: 0x1888BD0 VA: 0x18188A5D0
	|-GenericsUtil.CastImpl<object, long>..cctor
	|
	|-RVA: 0x188F1C0 Offset: 0x188D7C0 VA: 0x18188F1C0
	|-GenericsUtil.CastImpl<object, object>..cctor
	|
	|-RVA: 0x188D4B0 Offset: 0x188BAB0 VA: 0x18188D4B0
	|-GenericsUtil.CastImpl<object, sbyte>..cctor
	|
	|-RVA: 0x188A210 Offset: 0x1888810 VA: 0x18188A210
	|-GenericsUtil.CastImpl<object, float>..cctor
	|
	|-RVA: 0x188FB20 Offset: 0x188E120 VA: 0x18188FB20
	|-GenericsUtil.CastImpl<object, ushort>..cctor
	|
	|-RVA: 0x1891560 Offset: 0x188FB60 VA: 0x181891560
	|-GenericsUtil.CastImpl<object, uint>..cctor
	|
	|-RVA: 0x188B2F0 Offset: 0x18898F0 VA: 0x18188B2F0
	|-GenericsUtil.CastImpl<object, ulong>..cctor
	|
	|-RVA: 0x18897C0 Offset: 0x1887DC0 VA: 0x1818897C0
	|-GenericsUtil.CastImpl<object, Color>..cctor
	|
	|-RVA: 0x188E1D0 Offset: 0x188C7D0 VA: 0x18188E1D0
	|-GenericsUtil.CastImpl<object, Ray>..cctor
	|
	|-RVA: 0x188BA70 Offset: 0x188A070 VA: 0x18188BA70
	|-GenericsUtil.CastImpl<object, Vector3>..cctor
	|
	|-RVA: 0x1890ED0 Offset: 0x188F4D0 VA: 0x181890ED0
	|-GenericsUtil.CastImpl<sbyte, bool>..cctor
	|
	|-RVA: 0x188DF00 Offset: 0x188C500 VA: 0x18188DF00
	|-GenericsUtil.CastImpl<sbyte, byte>..cctor
	|
	|-RVA: 0x188A7B0 Offset: 0x1888DB0 VA: 0x18188A7B0
	|-GenericsUtil.CastImpl<sbyte, short>..cctor
	|
	|-RVA: 0x1889E50 Offset: 0x1888450 VA: 0x181889E50
	|-GenericsUtil.CastImpl<sbyte, int>..cctor
	|
	|-RVA: 0x1889D60 Offset: 0x1888360 VA: 0x181889D60
	|-GenericsUtil.CastImpl<sbyte, long>..cctor
	|
	|-RVA: 0x1890B10 Offset: 0x188F110 VA: 0x181890B10
	|-GenericsUtil.CastImpl<sbyte, object>..cctor
	|
	|-RVA: 0x188D2D0 Offset: 0x188B8D0 VA: 0x18188D2D0
	|-GenericsUtil.CastImpl<sbyte, sbyte>..cctor
	|
	|-RVA: 0x188D780 Offset: 0x188BD80 VA: 0x18188D780
	|-GenericsUtil.CastImpl<sbyte, float>..cctor
	|
	|-RVA: 0x188AC60 Offset: 0x1889260 VA: 0x18188AC60
	|-GenericsUtil.CastImpl<sbyte, ushort>..cctor
	|
	|-RVA: 0x188B6B0 Offset: 0x1889CB0 VA: 0x18188B6B0
	|-GenericsUtil.CastImpl<sbyte, uint>..cctor
	|
	|-RVA: 0x1891380 Offset: 0x188F980 VA: 0x181891380
	|-GenericsUtil.CastImpl<sbyte, ulong>..cctor
	|
	|-RVA: 0x188DE10 Offset: 0x188C410 VA: 0x18188DE10
	|-GenericsUtil.CastImpl<sbyte, Color>..cctor
	|
	|-RVA: 0x1891830 Offset: 0x188FE30 VA: 0x181891830
	|-GenericsUtil.CastImpl<sbyte, Ray>..cctor
	|
	|-RVA: 0x188B4D0 Offset: 0x1889AD0 VA: 0x18188B4D0
	|-GenericsUtil.CastImpl<sbyte, Vector3>..cctor
	|
	|-RVA: 0x188AF30 Offset: 0x1889530 VA: 0x18188AF30
	|-GenericsUtil.CastImpl<float, bool>..cctor
	|
	|-RVA: 0x18896D0 Offset: 0x1887CD0 VA: 0x1818896D0
	|-GenericsUtil.CastImpl<float, byte>..cctor
	|
	|-RVA: 0x188C6A0 Offset: 0x188ACA0 VA: 0x18188C6A0
	|-GenericsUtil.CastImpl<float, short>..cctor
	|
	|-RVA: 0x188FFD0 Offset: 0x188E5D0 VA: 0x18188FFD0
	|-GenericsUtil.CastImpl<float, int>..cctor
	|
	|-RVA: 0x188FA30 Offset: 0x188E030 VA: 0x18188FA30
	|-GenericsUtil.CastImpl<float, long>..cctor
	|
	|-RVA: 0x188AA80 Offset: 0x1889080 VA: 0x18188AA80
	|-GenericsUtil.CastImpl<float, object>..cctor
	|
	|-RVA: 0x18898B0 Offset: 0x1887EB0 VA: 0x1818898B0
	|-GenericsUtil.CastImpl<float, sbyte>..cctor
	|
	|-RVA: 0x188CF10 Offset: 0x188B510 VA: 0x18188CF10
	|-GenericsUtil.CastImpl<float, float>..cctor
	|
	|-RVA: 0x188A990 Offset: 0x1888F90 VA: 0x18188A990
	|-GenericsUtil.CastImpl<float, ushort>..cctor
	|
	|-RVA: 0x188D960 Offset: 0x188BF60 VA: 0x18188D960
	|-GenericsUtil.CastImpl<float, uint>..cctor
	|
	|-RVA: 0x188BB60 Offset: 0x188A160 VA: 0x18188BB60
	|-GenericsUtil.CastImpl<float, ulong>..cctor
	|
	|-RVA: 0x188EEF0 Offset: 0x188D4F0 VA: 0x18188EEF0
	|-GenericsUtil.CastImpl<float, Color>..cctor
	|
	|-RVA: 0x188A4E0 Offset: 0x1888AE0 VA: 0x18188A4E0
	|-GenericsUtil.CastImpl<float, Ray>..cctor
	|
	|-RVA: 0x188F850 Offset: 0x188DE50 VA: 0x18188F850
	|-GenericsUtil.CastImpl<float, Vector3>..cctor
	|
	|-RVA: 0x188F490 Offset: 0x188DA90 VA: 0x18188F490
	|-GenericsUtil.CastImpl<ushort, bool>..cctor
	|
	|-RVA: 0x188C880 Offset: 0x188AE80 VA: 0x18188C880
	|-GenericsUtil.CastImpl<ushort, byte>..cctor
	|
	|-RVA: 0x188E4A0 Offset: 0x188CAA0 VA: 0x18188E4A0
	|-GenericsUtil.CastImpl<ushort, int>..cctor
	|
	|-RVA: 0x18900C0 Offset: 0x188E6C0 VA: 0x1818900C0
	|-GenericsUtil.CastImpl<ushort, object>..cctor
	|
	|-RVA: 0x188EA40 Offset: 0x188D040 VA: 0x18188EA40
	|-GenericsUtil.CastImpl<ushort, sbyte>..cctor
	|
	|-RVA: 0x188F940 Offset: 0x188DF40 VA: 0x18188F940
	|-GenericsUtil.CastImpl<ushort, float>..cctor
	|
	|-RVA: 0x18899A0 Offset: 0x1887FA0 VA: 0x1818899A0
	|-GenericsUtil.CastImpl<ushort, uint>..cctor
	|
	|-RVA: 0x188C2E0 Offset: 0x188A8E0 VA: 0x18188C2E0
	|-GenericsUtil.CastImpl<ushort, ulong>..cctor
	|
	|-RVA: 0x188BF20 Offset: 0x188A520 VA: 0x18188BF20
	|-GenericsUtil.CastImpl<ushort, Color>..cctor
	|
	|-RVA: 0x18911A0 Offset: 0x188F7A0 VA: 0x1818911A0
	|-GenericsUtil.CastImpl<ushort, Ray>..cctor
	|
	|-RVA: 0x188E590 Offset: 0x188CB90 VA: 0x18188E590
	|-GenericsUtil.CastImpl<ushort, Vector3>..cctor
	|
	|-RVA: 0x1889310 Offset: 0x1887910 VA: 0x181889310
	|-GenericsUtil.CastImpl<uint, bool>..cctor
	|
	|-RVA: 0x188B890 Offset: 0x1889E90 VA: 0x18188B890
	|-GenericsUtil.CastImpl<uint, byte>..cctor
	|
	|-RVA: 0x188B7A0 Offset: 0x1889DA0 VA: 0x18188B7A0
	|-GenericsUtil.CastImpl<uint, short>..cctor
	|
	|-RVA: 0x18902A0 Offset: 0x188E8A0 VA: 0x1818902A0
	|-GenericsUtil.CastImpl<uint, int>..cctor
	|
	|-RVA: 0x188C1F0 Offset: 0x188A7F0 VA: 0x18188C1F0
	|-GenericsUtil.CastImpl<uint, long>..cctor
	|
	|-RVA: 0x188A300 Offset: 0x1888900 VA: 0x18188A300
	|-GenericsUtil.CastImpl<uint, object>..cctor
	|
	|-RVA: 0x188D000 Offset: 0x188B600 VA: 0x18188D000
	|-GenericsUtil.CastImpl<uint, sbyte>..cctor
	|
	|-RVA: 0x188CC40 Offset: 0x188B240 VA: 0x18188CC40
	|-GenericsUtil.CastImpl<uint, float>..cctor
	|
	|-RVA: 0x188F2B0 Offset: 0x188D8B0 VA: 0x18188F2B0
	|-GenericsUtil.CastImpl<uint, ushort>..cctor
	|
	|-RVA: 0x1890930 Offset: 0x188EF30 VA: 0x181890930
	|-GenericsUtil.CastImpl<uint, uint>..cctor
	|
	|-RVA: 0x188F670 Offset: 0x188DC70 VA: 0x18188F670
	|-GenericsUtil.CastImpl<uint, ulong>..cctor
	|
	|-RVA: 0x188B020 Offset: 0x1889620 VA: 0x18188B020
	|-GenericsUtil.CastImpl<uint, Color>..cctor
	|
	|-RVA: 0x188FEE0 Offset: 0x188E4E0 VA: 0x18188FEE0
	|-GenericsUtil.CastImpl<uint, Ray>..cctor
	|
	|-RVA: 0x188DFF0 Offset: 0x188C5F0 VA: 0x18188DFF0
	|-GenericsUtil.CastImpl<uint, Vector3>..cctor
	|
	|-RVA: 0x1890C00 Offset: 0x188F200 VA: 0x181890C00
	|-GenericsUtil.CastImpl<ulong, bool>..cctor
	|
	|-RVA: 0x1642940 Offset: 0x1640F40 VA: 0x181642940
	|-GenericsUtil.CastImpl<ulong, byte>..cctor
	|
	|-RVA: 0x1642C10 Offset: 0x1641210 VA: 0x181642C10
	|-GenericsUtil.CastImpl<ulong, short>..cctor
	|
	|-RVA: 0x16440B0 Offset: 0x16426B0 VA: 0x1816440B0
	|-GenericsUtil.CastImpl<ulong, int>..cctor
	|
	|-RVA: 0x1643840 Offset: 0x1641E40 VA: 0x181643840
	|-GenericsUtil.CastImpl<ulong, long>..cctor
	|
	|-RVA: 0x16421C0 Offset: 0x16407C0 VA: 0x1816421C0
	|-GenericsUtil.CastImpl<ulong, object>..cctor
	|
	|-RVA: 0x1642580 Offset: 0x1640B80 VA: 0x181642580
	|-GenericsUtil.CastImpl<ulong, sbyte>..cctor
	|
	|-RVA: 0x1643A20 Offset: 0x1642020 VA: 0x181643A20
	|-GenericsUtil.CastImpl<ulong, float>..cctor
	|
	|-RVA: 0x1642A30 Offset: 0x1641030 VA: 0x181642A30
	|-GenericsUtil.CastImpl<ulong, ushort>..cctor
	|
	|-RVA: 0x1644650 Offset: 0x1642C50 VA: 0x181644650
	|-GenericsUtil.CastImpl<ulong, uint>..cctor
	|
	|-RVA: 0x1643390 Offset: 0x1641990 VA: 0x181643390
	|-GenericsUtil.CastImpl<ulong, ulong>..cctor
	|
	|-RVA: 0x1644830 Offset: 0x1642E30 VA: 0x181644830
	|-GenericsUtil.CastImpl<ulong, Color>..cctor
	|
	|-RVA: 0x16431B0 Offset: 0x16417B0 VA: 0x1816431B0
	|-GenericsUtil.CastImpl<ulong, Ray>..cctor
	|
	|-RVA: 0x1642DF0 Offset: 0x16413F0 VA: 0x181642DF0
	|-GenericsUtil.CastImpl<ulong, Vector3>..cctor
	|
	|-RVA: 0x1643570 Offset: 0x1641B70 VA: 0x181643570
	|-GenericsUtil.CastImpl<Color, bool>..cctor
	|
	|-RVA: 0x1644380 Offset: 0x1642980 VA: 0x181644380
	|-GenericsUtil.CastImpl<Color, byte>..cctor
	|
	|-RVA: 0x1643B10 Offset: 0x1642110 VA: 0x181643B10
	|-GenericsUtil.CastImpl<Color, short>..cctor
	|
	|-RVA: 0x1642760 Offset: 0x1640D60 VA: 0x181642760
	|-GenericsUtil.CastImpl<Color, int>..cctor
	|
	|-RVA: 0x1644B00 Offset: 0x1643100 VA: 0x181644B00
	|-GenericsUtil.CastImpl<Color, long>..cctor
	|
	|-RVA: 0x1641A40 Offset: 0x1640040 VA: 0x181641A40
	|-GenericsUtil.CastImpl<Color, object>..cctor
	|
	|-RVA: 0x1643CF0 Offset: 0x16422F0 VA: 0x181643CF0
	|-GenericsUtil.CastImpl<Color, sbyte>..cctor
	|
	|-RVA: 0x1644A10 Offset: 0x1643010 VA: 0x181644A10
	|-GenericsUtil.CastImpl<Color, float>..cctor
	|
	|-RVA: 0x1644470 Offset: 0x1642A70 VA: 0x181644470
	|-GenericsUtil.CastImpl<Color, ushort>..cctor
	|
	|-RVA: 0x1642490 Offset: 0x1640A90 VA: 0x181642490
	|-GenericsUtil.CastImpl<Color, uint>..cctor
	|
	|-RVA: 0x1643ED0 Offset: 0x16424D0 VA: 0x181643ED0
	|-GenericsUtil.CastImpl<Color, ulong>..cctor
	|
	|-RVA: 0x1644740 Offset: 0x1642D40 VA: 0x181644740
	|-GenericsUtil.CastImpl<Color, Color>..cctor
	|
	|-RVA: 0x1643660 Offset: 0x1641C60 VA: 0x181643660
	|-GenericsUtil.CastImpl<Color, Ray>..cctor
	|
	|-RVA: 0x1642FD0 Offset: 0x16415D0 VA: 0x181642FD0
	|-GenericsUtil.CastImpl<Color, Vector3>..cctor
	|
	|-RVA: 0x1643C00 Offset: 0x1642200 VA: 0x181643C00
	|-GenericsUtil.CastImpl<Ray, bool>..cctor
	|
	|-RVA: 0x16420D0 Offset: 0x16406D0 VA: 0x1816420D0
	|-GenericsUtil.CastImpl<Ray, byte>..cctor
	|
	|-RVA: 0x1641E00 Offset: 0x1640400 VA: 0x181641E00
	|-GenericsUtil.CastImpl<Ray, short>..cctor
	|
	|-RVA: 0x1641C20 Offset: 0x1640220 VA: 0x181641C20
	|-GenericsUtil.CastImpl<Ray, int>..cctor
	|
	|-RVA: 0x1643DE0 Offset: 0x16423E0 VA: 0x181643DE0
	|-GenericsUtil.CastImpl<Ray, long>..cctor
	|
	|-RVA: 0x1643FC0 Offset: 0x16425C0 VA: 0x181643FC0
	|-GenericsUtil.CastImpl<Ray, object>..cctor
	|
	|-RVA: 0x16441A0 Offset: 0x16427A0 VA: 0x1816441A0
	|-GenericsUtil.CastImpl<Ray, sbyte>..cctor
	|
	|-RVA: 0x16430C0 Offset: 0x16416C0 VA: 0x1816430C0
	|-GenericsUtil.CastImpl<Ray, float>..cctor
	|
	|-RVA: 0x1644290 Offset: 0x1642890 VA: 0x181644290
	|-GenericsUtil.CastImpl<Ray, ushort>..cctor
	|
	|-RVA: 0x16422B0 Offset: 0x16408B0 VA: 0x1816422B0
	|-GenericsUtil.CastImpl<Ray, uint>..cctor
	|
	|-RVA: 0x1642D00 Offset: 0x1641300 VA: 0x181642D00
	|-GenericsUtil.CastImpl<Ray, ulong>..cctor
	|
	|-RVA: 0x1641FE0 Offset: 0x16405E0 VA: 0x181641FE0
	|-GenericsUtil.CastImpl<Ray, Color>..cctor
	|
	|-RVA: 0x1642B20 Offset: 0x1641120 VA: 0x181642B20
	|-GenericsUtil.CastImpl<Ray, Ray>..cctor
	|
	|-RVA: 0x1642EE0 Offset: 0x16414E0 VA: 0x181642EE0
	|-GenericsUtil.CastImpl<Ray, Vector3>..cctor
	|
	|-RVA: 0x1641EF0 Offset: 0x16404F0 VA: 0x181641EF0
	|-GenericsUtil.CastImpl<Vector3, bool>..cctor
	|
	|-RVA: 0x1643750 Offset: 0x1641D50 VA: 0x181643750
	|-GenericsUtil.CastImpl<Vector3, byte>..cctor
	|
	|-RVA: 0x1643480 Offset: 0x1641A80 VA: 0x181643480
	|-GenericsUtil.CastImpl<Vector3, short>..cctor
	|
	|-RVA: 0x16432A0 Offset: 0x16418A0 VA: 0x1816432A0
	|-GenericsUtil.CastImpl<Vector3, int>..cctor
	|
	|-RVA: 0x1642850 Offset: 0x1640E50 VA: 0x181642850
	|-GenericsUtil.CastImpl<Vector3, long>..cctor
	|
	|-RVA: 0x1641860 Offset: 0x163FE60 VA: 0x181641860
	|-GenericsUtil.CastImpl<Vector3, object>..cctor
	|
	|-RVA: 0x1641950 Offset: 0x163FF50 VA: 0x181641950
	|-GenericsUtil.CastImpl<Vector3, sbyte>..cctor
	|
	|-RVA: 0x1643930 Offset: 0x1641F30 VA: 0x181643930
	|-GenericsUtil.CastImpl<Vector3, float>..cctor
	|
	|-RVA: 0x1641B30 Offset: 0x1640130 VA: 0x181641B30
	|-GenericsUtil.CastImpl<Vector3, ushort>..cctor
	|
	|-RVA: 0x16423A0 Offset: 0x16409A0 VA: 0x1816423A0
	|-GenericsUtil.CastImpl<Vector3, uint>..cctor
	|
	|-RVA: 0x1644920 Offset: 0x1642F20 VA: 0x181644920
	|-GenericsUtil.CastImpl<Vector3, ulong>..cctor
	|
	|-RVA: 0x1644560 Offset: 0x1642B60 VA: 0x181644560
	|-GenericsUtil.CastImpl<Vector3, Color>..cctor
	|
	|-RVA: 0x1641D10 Offset: 0x1640310 VA: 0x181641D10
	|-GenericsUtil.CastImpl<Vector3, Ray>..cctor
	|
	|-RVA: 0x1642670 Offset: 0x1640C70 VA: 0x181642670
	|-GenericsUtil.CastImpl<Vector3, Vector3>..cctor
	*/

}

