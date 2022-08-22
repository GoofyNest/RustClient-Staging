public sealed class GameObject : Object // TypeDefIndex: 3515
{
// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0xBBF90 Offset: 0xBB390 VA: 0x1800BBF90
[ExcludeFromPresetAttribute] // RVA: 0xBBF90 Offset: 0xBB390 VA: 0x1800BBF90
[NativeHeaderAttribute] // RVA: 0xBBF90 Offset: 0xBB390 VA: 0x1800BBF90
public sealed class GameObject : Object // TypeDefIndex: 3515
	// Properties
	public Transform transform { get; }
	public int layer { get; set; }
	public bool activeSelf { get; }
	public bool activeInHierarchy { get; }
	public bool isStatic { get; set; }
	public string tag { get; set; }
	public GameObject gameObject { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xBC2B0 Offset: 0xBB6B0 VA: 0x1800BC2B0
	// RVA: 0x1818530 Offset: 0x1816B30 VA: 0x181818530
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A31B0 Offset: 0x15A17B0 VA: 0x1815A31B0
	|-GameObject.GetComponent<AdminExistingSellOrder>
	|-GameObject.GetComponent<AmbienceEmitter>
	|-GameObject.GetComponent<AttackEntity>
	|-GameObject.GetComponent<BaseBulb>
	|-GameObject.GetComponent<BaseCollision>
	|-GameObject.GetComponent<BaseEntity>
	|-GameObject.GetComponent<BaseMelee>
	|-GameObject.GetComponent<BaseMeshPaintable>
	|-GameObject.GetComponent<BaseMovement>
	|-GameObject.GetComponent<BaseProjectile>
	|-GameObject.GetComponent<BaseViewModel>
	|-GameObject.GetComponent<BlueprintButton>
	|-GameObject.GetComponent<BobberPreview>
	|-GameObject.GetComponent<BranchConfig>
	|-GameObject.GetComponent<BuildingPrivlidge>
	|-GameObject.GetComponent<CardTableUI>
	|-GameObject.GetComponent<ChangeSignText>
	|-GameObject.GetComponent<ChatEntry>
	|-GameObject.GetComponent<ClientIOLine>
	|-GameObject.GetComponent<ColliderInfo>
	|-GameObject.GetComponent<CommunityEntity.FadeOut>
	|-GameObject.GetComponent<ComputerMenu>
	|-GameObject.GetComponent<ConditionalGibbable>
	|-GameObject.GetComponent<ConstructionSkin>
	|-GameObject.GetComponent<CounterConfig>
	|-GameObject.GetComponent<CraftingQueueIcon>
	|-GameObject.GetComponent<CullingVolume>
	|-GameObject.GetComponent<DemoItem>
	|-GameObject.GetComponent<DemoShotEntry>
	|-GameObject.GetComponent<DemoShotListFolderWidget>
	|-GameObject.GetComponent<DropMe>
	|-GameObject.GetComponent<ERSurfaceScript>
	|-GameObject.GetComponent<ERCrossingPrefabs>
	|-GameObject.GetComponent<ERCrossings>
	|-GameObject.GetComponent<ERIConnector>
	|-GameObject.GetComponent<ERModularBase>
	|-GameObject.GetComponent<ERModularRoad>
	|-GameObject.GetComponent<ERRoundabouts>
	|-GameObject.GetComponent<ERSideObjectInstance>
	|-GameObject.GetComponent<ERSideObjectLog>
	|-GameObject.GetComponent<ERTerrain>
	|-GameObject.GetComponent<EffectParentToWeaponBone>
	|-GameObject.GetComponent<EntityDebug>
	|-GameObject.GetComponent<EnvironmentFish>
	|-GameObject.GetComponent<EnvironmentVolume>
	|-GameObject.GetComponent<SkeletonSkin>
	|-GameObject.GetComponent<VirtualScroll.IDataSource>
	|-GameObject.GetComponent<FavouriteRadioStation>
	|-GameObject.GetComponent<FireworkShell>
	|-GameObject.GetComponent<FoliageGridBatch>
	|-GameObject.GetComponent<FootstepSound>
	|-GameObject.GetComponent<FrequencyConfig>
	|-GameObject.GetComponent<Gib>
	|-GameObject.GetComponent<Gibbable>
	|-GameObject.GetComponent<GrowableEntity>
	|-GameObject.GetComponent<HeldEntity>
	|-GameObject.GetComponent<IEffectRecycle>
	|-GameObject.GetComponent<INotifyLOD>
	|-GameObject.GetComponent<IOEntity>
	|-GameObject.GetComponent<IconSkin>
	|-GameObject.GetComponent<IdentifierConfig>
	|-GameObject.GetComponent<ImageEffectComposite>
	|-GameObject.GetComponent<ImageRenderController>
	|-GameObject.GetComponent<ImpostorShadows>
	|-GameObject.GetComponent<IronSightOverride>
	|-GameObject.GetComponent<ItemBlueprint>
	|-GameObject.GetComponent<ItemDefinition>
	|-GameObject.GetComponent<ItemOptionButton>
	|-GameObject.GetComponent<ItemPickupNotice>
	|-GameObject.GetComponent<ItemStoreCartItem>
	|-GameObject.GetComponent<ItemStoreItem>
	|-GameObject.GetComponent<KeyCodeEntry>
	|-GameObject.GetComponent<KeyframeWidget>
	|-GameObject.GetComponent<LifeInfographicStatDynamicRow>
	|-GameObject.GetComponent<LifeInfographicStatWeapon>
	|-GameObject.GetComponent<MainCamera>
	|-GameObject.GetComponent<MapLayerRenderer>
	|-GameObject.GetComponent<MaterialSwap>
	|-GameObject.GetComponent<MaxSpawnDistance>
	|-GameObject.GetComponent<MedicalTool>
	|-GameObject.GetComponent<MeshRendererBatch>
	|-GameObject.GetComponent<MissionMapMarker>
	|-GameObject.GetComponent<Model>
	|-GameObject.GetComponent<MonumentMarker>
	|-GameObject.GetComponent<NeedsCursor>
	|-GameObject.GetComponent<NeedsKeyboard>
	|-GameObject.GetComponent<ObjectMotionVectorFix>
	|-GameObject.GetComponent<PhoneDialler>
	|-GameObject.GetComponent<PhoneDirectoryEntry>
	|-GameObject.GetComponent<PhysicsEffects>
	|-GameObject.GetComponent<PickAFriend>
	|-GameObject.GetComponent<PieOption>
	|-GameObject.GetComponent<PlantSkin>
	|-GameObject.GetComponent<PlayerModel>
	|-GameObject.GetComponent<PlayerWalkMovement>
	|-GameObject.GetComponent<PointOfInterestMapMarker>
	|-GameObject.GetComponent<Poolable>
	|-GameObject.GetComponent<PowerLineWireConnectionHelper>
	|-GameObject.GetComponent<PrefabParameters>
	|-GameObject.GetComponent<Projectile>
	|-GameObject.GetComponent<ProjectileWeaponMod>
	|-GameObject.GetComponent<QuickCraftButton>
	|-GameObject.GetComponent<RCBookmarkEntry>
	|-GameObject.GetComponent<RadioDialog>
	|-GameObject.GetComponent<Ragdoll>
	|-GameObject.GetComponent<RecordingBars>
	|-GameObject.GetComponent<RenameSleepingBag>
	|-GameObject.GetComponent<ReskinEffect>
	|-GameObject.GetComponent<RidableHorse>
	|-GameObject.GetComponent<IEntity>
	|-GameObject.GetComponent<PropRenderer>
	|-GameObject.GetComponent<FileDialog>
	|-GameObject.GetComponent<FileListElement>
	|-GameObject.GetComponent<RustButton>
	|-GameObject.GetComponent<RustText>
	|-GameObject.GetComponent<ServerAdminServerInfo>
	|-GameObject.GetComponent<SteamInventoryItem>
	|-GameObject.GetComponent<WorkshopItemButton>
	|-GameObject.GetComponent<WorkshopSkin>
	|-GameObject.GetComponent<SellOrderEntry>
	|-GameObject.GetComponent<ServerBrowserItem>
	|-GameObject.GetComponent<ServerHistoryItem>
	|-GameObject.GetComponent<ServerProjectile>
	|-GameObject.GetComponent<SetupAppNotification>
	|-GameObject.GetComponent<SlotMachinePayoutWidget>
	|-GameObject.GetComponent<Sound>
	|-GameObject.GetComponent<SoundLightDialog>
	|-GameObject.GetComponent<SoundPlayer>
	|-GameObject.GetComponent<SoundSource>
	|-GameObject.GetComponent<SprayCanSkinSelect>
	|-GameObject.GetComponent<SteamUserButton>
	|-GameObject.GetComponent<TMP_InputField>
	|-GameObject.GetComponent<TMP_SubMesh>
	|-GameObject.GetComponent<TMP_Text>
	|-GameObject.GetComponent<TerrainGenerator>
	|-GameObject.GetComponent<TerrainMeta>
	|-GameObject.GetComponent<ThrownWeapon>
	|-GameObject.GetComponent<TimedExplosive>
	|-GameObject.GetComponent<TimerConfig>
	|-GameObject.GetComponent<ToggleHUDLayer>
	|-GameObject.GetComponent<UIChatPopup>
	|-GameObject.GetComponent<UIEscapeCapture>
	|-GameObject.GetComponent<UIFireworkDesigner>
	|-GameObject.GetComponent<UIFireworkStar>
	|-GameObject.GetComponent<UIMapGenericRadius>
	|-GameObject.GetComponent<UIMapVendingMachineMarker>
	|-GameObject.GetComponent<UIMapVendingMachineMarkerCluster>
	|-GameObject.GetComponent<UIMarketSearchStore>
	|-GameObject.GetComponent<UIMixingTableItem>
	|-GameObject.GetComponent<UIPaintableImage>
	|-GameObject.GetComponent<UnderwearIcon>
	|-GameObject.GetComponent<NavMeshAgent>
	|-GameObject.GetComponent<NavMeshObstacle>
	|-GameObject.GetComponent<AudioSource>
	|-GameObject.GetComponent<BoxCollider>
	|-GameObject.GetComponent<Camera>
	|-GameObject.GetComponent<Canvas>
	|-GameObject.GetComponent<CanvasGroup>
	|-GameObject.GetComponent<CanvasRenderer>
	|-GameObject.GetComponent<Collider>
	|-GameObject.GetComponent<LODGroup>
	|-GameObject.GetComponent<Light>
	|-GameObject.GetComponent<MeshCollider>
	|-GameObject.GetComponent<MeshFilter>
	|-GameObject.GetComponent<MeshRenderer>
	|-GameObject.GetComponent<ParticleSystem>
	|-GameObject.GetComponent<RectTransform>
	|-GameObject.GetComponent<ReflectionProbe>
	|-GameObject.GetComponent<Renderer>
	|-GameObject.GetComponent<Rigidbody>
	|-GameObject.GetComponent<SpriteRenderer>
	|-GameObject.GetComponent<Terrain>
	|-GameObject.GetComponent<TerrainCollider>
	|-GameObject.GetComponent<Transform>
	|-GameObject.GetComponent<Button>
	|-GameObject.GetComponent<Dropdown>
	|-GameObject.GetComponent<Image>
	|-GameObject.GetComponent<InputField>
	|-GameObject.GetComponent<Mask>
	|-GameObject.GetComponent<ScrollRect>
	|-GameObject.GetComponent<Scrollbar>
	|-GameObject.GetComponent<Slider>
	|-GameObject.GetComponent<Text>
	|-GameObject.GetComponent<Toggle>
	|-GameObject.GetComponent<ToggleGroup>
	|-GameObject.GetComponent<VendingPanelAdmin>
	|-GameObject.GetComponent<ViewmodelClothing>
	|-GameObject.GetComponent<VoicemailEntry>
	|-GameObject.GetComponent<Wearable>
	|-GameObject.GetComponent<WearableHolsterOffset>
	|-GameObject.GetComponent<object>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0xBC3C0 Offset: 0xBB7C0 VA: 0x1800BC3C0
	[FreeFunctionAttribute] // RVA: 0xBC3C0 Offset: 0xBB7C0 VA: 0x1800BC3C0
	// RVA: 0x18186C0 Offset: 0x1816CC0 VA: 0x1818186C0
	public Component GetComponent(Type type) { }

	[NativeWritableSelfAttribute] // RVA: 0xBC590 Offset: 0xBB990 VA: 0x1800BC590
	[FreeFunctionAttribute] // RVA: 0xBC590 Offset: 0xBB990 VA: 0x1800BC590
	// RVA: 0x18185B0 Offset: 0x1816BB0 VA: 0x1818185B0
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunctionAttribute] // RVA: 0xBDB60 Offset: 0xBCF60 VA: 0x1800BDB60
	[TypeInferenceRuleAttribute] // RVA: 0xBDB60 Offset: 0xBCF60 VA: 0x1800BDB60
	// RVA: 0x1818610 Offset: 0x1816C10 VA: 0x181818610
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A2FD0 Offset: 0x15A15D0 VA: 0x1815A2FD0
	|-GameObject.GetComponentInChildren<AnimationEvents>
	|-GameObject.GetComponentInChildren<DungeonGridLink>
	|-GameObject.GetComponentInChildren<DungeonVolume>
	|-GameObject.GetComponentInChildren<ERSurfaceScript>
	|-GameObject.GetComponentInChildren<OQQCCQCDQQ>
	|-GameObject.GetComponentInChildren<ItemButtonTools>
	|-GameObject.GetComponentInChildren<LadderMinMountHeight>
	|-GameObject.GetComponentInChildren<PaintableItem>
	|-GameObject.GetComponentInChildren<ProceduralObject>
	|-GameObject.GetComponentInChildren<HttpImage>
	|-GameObject.GetComponentInChildren<TextMeshProUGUI>
	|-GameObject.GetComponentInChildren<TooltipContainer>
	|-GameObject.GetComponentInChildren<LODGroup>
	|-GameObject.GetComponentInChildren<LineRenderer>
	|-GameObject.GetComponentInChildren<Rigidbody>
	|-GameObject.GetComponentInChildren<Button>
	|-GameObject.GetComponentInChildren<Dropdown.DropdownItem>
	|-GameObject.GetComponentInChildren<Text>
	|-GameObject.GetComponentInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A3000 Offset: 0x15A1600 VA: 0x1815A3000
	|-GameObject.GetComponentInChildren<Text>
	|-GameObject.GetComponentInChildren<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xBDE20 Offset: 0xBD220 VA: 0x1800BDE20
	[TypeInferenceRuleAttribute] // RVA: 0xBDE20 Offset: 0xBD220 VA: 0x1800BDE20
	// RVA: 0x1818670 Offset: 0x1816C70 VA: 0x181818670
	public Component GetComponentInParent(Type type) { }

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A30E0 Offset: 0x15A16E0 VA: 0x1815A30E0
	|-GameObject.GetComponentInParent<BaseEntity>
	|-GameObject.GetComponentInParent<BaseViewModel>
	|-GameObject.GetComponentInParent<DropMe>
	|-GameObject.GetComponentInParent<IProvider>
	|-GameObject.GetComponentInParent<Model>
	|-GameObject.GetComponentInParent<Poolable>
	|-GameObject.GetComponentInParent<Ragdoll>
	|-GameObject.GetComponentInParent<RustControl>
	|-GameObject.GetComponentInParent<SoundSource>
	|-GameObject.GetComponentInParent<IPointerDownHandler>
	|-GameObject.GetComponentInParent<ISubmitHandler>
	|-GameObject.GetComponentInParent<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xBDFB0 Offset: 0xBD3B0 VA: 0x1800BDFB0
	// RVA: 0x18187E0 Offset: 0x1816DE0 VA: 0x1818187E0
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	// RVA: 0x1818860 Offset: 0x1816E60 VA: 0x181818860
	public Component[] GetComponents(Type type) { }

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38980 Offset: 0x1A36F80 VA: 0x181A38980
	|-GameObject.GetComponents<ConstructionGrade>
	|-GameObject.GetComponents<Component>
	|-GameObject.GetComponents<Graphic>
	|-GameObject.GetComponents<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CE270 Offset: 0x5CC870 VA: 0x1805CE270
	|-GameObject.GetComponents<DecalRecycle>
	|-GameObject.GetComponents<IOnParentDestroying>
	|-GameObject.GetComponents<IOnParentSpawning>
	|-GameObject.GetComponents<IOnPostNetworkUpdate>
	|-GameObject.GetComponents<IOnSendNetworkUpdate>
	|-GameObject.GetComponents<RendererBatch>
	|-GameObject.GetComponents<object>
	|-GameObject.GetComponents<Component>
	*/

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1818710 Offset: 0x1816D10 VA: 0x181818710
	public Component[] GetComponentsInChildren(Type type) { }

	// RVA: 0x1818720 Offset: 0x1816D20 VA: 0x181818720
	public Component[] GetComponentsInChildren(Type type, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38780 Offset: 0x1A36D80 VA: 0x181A38780
	|-GameObject.GetComponentsInChildren<BlueprintCategoryButton>
	|-GameObject.GetComponentsInChildren<CraftingQueueIcon>
	|-GameObject.GetComponentsInChildren<SingletonComponent>
	|-GameObject.GetComponentsInChildren<TerrainPathConnect>
	|-GameObject.GetComponentsInChildren<Collider>
	|-GameObject.GetComponentsInChildren<Component>
	|-GameObject.GetComponentsInChildren<LODGroup>
	|-GameObject.GetComponentsInChildren<MonoBehaviour>
	|-GameObject.GetComponentsInChildren<ParticleSystem>
	|-GameObject.GetComponentsInChildren<Renderer>
	|-GameObject.GetComponentsInChildren<Rigidbody>
	|-GameObject.GetComponentsInChildren<Image>
	|-GameObject.GetComponentsInChildren<Text>
	|-GameObject.GetComponentsInChildren<Toggle>
	|-GameObject.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CE0F0 Offset: 0x5CC6F0 VA: 0x1805CE0F0
	|-GameObject.GetComponentsInChildren<IEffect>
	|-GameObject.GetComponentsInChildren<IItemSetup>
	|-GameObject.GetComponentsInChildren<IItemUpdate>
	|-GameObject.GetComponentsInChildren<MaterialReplacement>
	|-GameObject.GetComponentsInChildren<MorphCache>
	|-GameObject.GetComponentsInChildren<object>
	|-GameObject.GetComponentsInChildren<MeshRenderer>
	|-GameObject.GetComponentsInChildren<ParticleSystem>
	|-GameObject.GetComponentsInChildren<Renderer>
	|-GameObject.GetComponentsInChildren<SkinnedMeshRenderer>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A2FD0 Offset: 0x15A15D0 VA: 0x1815A2FD0
	|-GameObject.GetComponentsInChildren<ConditionalGibbable>
	|-GameObject.GetComponentsInChildren<ERSurfaceScript>
	|-GameObject.GetComponentsInChildren<ERConnectionParent>
	|-GameObject.GetComponentsInChildren<ERCrossingPrefabs>
	|-GameObject.GetComponentsInChildren<ERCrossings>
	|-GameObject.GetComponentsInChildren<ERModularRoad>
	|-GameObject.GetComponentsInChildren<ERPrefabInstance>
	|-GameObject.GetComponentsInChildren<ERRoadNetworkObject>
	|-GameObject.GetComponentsInChildren<ERRoundabouts>
	|-GameObject.GetComponentsInChildren<ERSideObjectInstance>
	|-GameObject.GetComponentsInChildren<ERSideObjectSection>
	|-GameObject.GetComponentsInChildren<EffectRecycle>
	|-GameObject.GetComponentsInChildren<MeshFilter>
	|-GameObject.GetComponentsInChildren<ParticleSystem>
	|-GameObject.GetComponentsInChildren<Renderer>
	|-GameObject.GetComponentsInChildren<Toggle>
	|-GameObject.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB500 Offset: 0x5C9B00 VA: 0x1805CB500
	|-GameObject.GetComponentsInChildren<DecalRecycle>
	|-GameObject.GetComponentsInChildren<EffectRecycle>
	|-GameObject.GetComponentsInChildren<IOnParentDestroying>
	|-GameObject.GetComponentsInChildren<IOnParentSpawning>
	|-GameObject.GetComponentsInChildren<IOnPostNetworkUpdate>
	|-GameObject.GetComponentsInChildren<IOnSendNetworkUpdate>
	|-GameObject.GetComponentsInChildren<LODComponent>
	|-GameObject.GetComponentsInChildren<RendererBatch>
	|-GameObject.GetComponentsInChildren<object>
	|-GameObject.GetComponentsInChildren<LODGroup>
	|-GameObject.GetComponentsInChildren<MeshRenderer>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CE1B0 Offset: 0x5CC7B0 VA: 0x1805CE1B0
	|-GameObject.GetComponentsInParent<object>
	|-GameObject.GetComponentsInParent<Canvas>
	|-GameObject.GetComponentsInParent<RectMask2D>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A38880 Offset: 0x1A36E80 VA: 0x181A38880
	|-GameObject.GetComponentsInParent<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF2D30 Offset: 0xBF1330 VA: 0x180BF2D30
	|-GameObject.TryGetComponent<BaseEntity>
	|-GameObject.TryGetComponent<ICustomMaterialReplacer>
	|-GameObject.TryGetComponent<INotifyEntityTrigger>
	|-GameObject.TryGetComponent<INotifyTrigger>
	|-GameObject.TryGetComponent<PatternFireworkStar>
	|-GameObject.TryGetComponent<Ragdoll>
	|-GameObject.TryGetComponent<RendererInfo>
	|-GameObject.TryGetComponent<ServerAdminUGCEntryStub>
	|-GameObject.TryGetComponent<SteamUserButton>
	|-GameObject.TryGetComponent<object>
	|-GameObject.TryGetComponent<ThrownWeapon>
	|-GameObject.TryGetComponent<MeshCollider>
	|-GameObject.TryGetComponent<MeshFilter>
	|-GameObject.TryGetComponent<SkinnedMeshRenderer>
	|-GameObject.TryGetComponent<Button>
	|-GameObject.TryGetComponent<GridLayoutGroup>
	|-GameObject.TryGetComponent<Image>
	|-GameObject.TryGetComponent<Wearable>
	*/

	[FreeFunctionAttribute] // RVA: 0xBE390 Offset: 0xBD790 VA: 0x1800BE390
	[NativeWritableSelfAttribute] // RVA: 0xBE390 Offset: 0xBD790 VA: 0x1800BE390
	// RVA: 0x1818B30 Offset: 0x1817130 VA: 0x181818B30
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x1818960 Offset: 0x1816F60 VA: 0x181818960
	public void SendMessage(string methodName, SendMessageOptions options) { }

	// RVA: 0x1818410 Offset: 0x1816A10 VA: 0x181818410
	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	[FreeFunctionAttribute] // RVA: 0xBE410 Offset: 0xBD810 VA: 0x1800BE410
	// RVA: 0x1818360 Offset: 0x1816960 VA: 0x181818360
	private Component Internal_AddComponentWithType(Type componentType) { }

	[TypeInferenceRuleAttribute] // RVA: 0xB9C80 Offset: 0xB9080 VA: 0x1800B9C80
	// RVA: 0x1818360 Offset: 0x1816960 VA: 0x181818360
	public Component AddComponent(Type componentType) { }

	// RVA: -1 Offset: -1
	public T AddComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15A2ED0 Offset: 0x15A14D0 VA: 0x1815A2ED0
	|-GameObject.AddComponent<AICoverPoint>
	|-GameObject.AddComponent<AddToHeightMap>
	|-GameObject.AddComponent<AddToWaterMap>
	|-GameObject.AddComponent<AudioInterceptComponent>
	|-GameObject.AddComponent<BaseEntityChild>
	|-GameObject.AddComponent<ColliderInfo>
	|-GameObject.AddComponent<CommunityEntity.Countdown>
	|-GameObject.AddComponent<CommunityEntity.FadeOut>
	|-GameObject.AddComponent<ConversationManager.Conversation>
	|-GameObject.AddComponent<DemoShotPlayback>
	|-GameObject.AddComponent<DemoShotRecorder>
	|-GameObject.AddComponent<DeployGuide>
	|-GameObject.AddComponent<DetachMonumentChildren>
	|-GameObject.AddComponent<ERSurfaceScript>
	|-GameObject.AddComponent<ERCrossingPrefabs>
	|-GameObject.AddComponent<ERCrossings>
	|-GameObject.AddComponent<ERIConnector>
	|-GameObject.AddComponent<ERPrefabInstance>
	|-GameObject.AddComponent<ERSideObjectInstance>
	|-GameObject.AddComponent<ERSideObjectSection>
	|-GameObject.AddComponent<ERSideWalkInstanceScript>
	|-GameObject.AddComponent<ERTerrain>
	|-GameObject.AddComponent<OQQCCQCDQQ>
	|-GameObject.AddComponent<EntityDebug>
	|-GameObject.AddComponent<EnvironmentVolume>
	|-GameObject.AddComponent<ExplosionDemoReactivator>
	|-GameObject.AddComponent<ApplicationControllerMonobehaviour>
	|-GameObject.AddComponent<BurstClothManager>
	|-GameObject.AddComponent<Skeleton>
	|-GameObject.AddComponent<TickComponent>
	|-GameObject.AddComponent<Gib>
	|-GameObject.AddComponent<HudMenuInput>
	|-GameObject.AddComponent<InvokeHandler>
	|-GameObject.AddComponent<InvokeHandlerFixedTime>
	|-GameObject.AddComponent<LightLOD>
	|-GameObject.AddComponent<LoadBalancer>
	|-GameObject.AddComponent<MeshLOD>
	|-GameObject.AddComponent<MeshPaintable3D>
	|-GameObject.AddComponent<MeshPaintable>
	|-GameObject.AddComponent<MidiConvar>
	|-GameObject.AddComponent<NeedsCursor>
	|-GameObject.AddComponent<NeedsKeyboard>
	|-GameObject.AddComponent<NeedsKeyboardInputField>
	|-GameObject.AddComponent<ObjectMotionVectorFix>
	|-GameObject.AddComponent<PlayerLoot>
	|-GameObject.AddComponent<PowerLineWire>
	|-GameObject.AddComponent<PowerLineWireSpan>
	|-GameObject.AddComponent<QueryVis>
	|-GameObject.AddComponent<ReflectionProbeEx>
	|-GameObject.AddComponent<RendererInfo>
	|-GameObject.AddComponent<RiverInfo>
	|-GameObject.AddComponent<DepthOfFieldFocusPoint>
	|-GameObject.AddComponent<LightingOverride>
	|-GameObject.AddComponent<NullMonoBehaviour>
	|-GameObject.AddComponent<IconOutline>
	|-GameObject.AddComponent<PropRenderer>
	|-GameObject.AddComponent<WorkshopSkin>
	|-GameObject.AddComponent<TMP_InputField>
	|-GameObject.AddComponent<TMP_SelectionCaret>
	|-GameObject.AddComponent<TMP_SubMeshUI>
	|-GameObject.AddComponent<TextMeshProUGUI>
	|-GameObject.AddComponent<TerrainAlphaMap>
	|-GameObject.AddComponent<TerrainBiomeMap>
	|-GameObject.AddComponent<TerrainCollision>
	|-GameObject.AddComponent<TerrainColors>
	|-GameObject.AddComponent<TerrainHeightMap>
	|-GameObject.AddComponent<TerrainMeta>
	|-GameObject.AddComponent<TerrainPath>
	|-GameObject.AddComponent<TerrainPhysics>
	|-GameObject.AddComponent<TerrainPlacementMap>
	|-GameObject.AddComponent<TerrainQuality>
	|-GameObject.AddComponent<TerrainSplatMap>
	|-GameObject.AddComponent<TerrainTexturing>
	|-GameObject.AddComponent<TerrainTopologyMap>
	|-GameObject.AddComponent<TerrainWaterMap>
	|-GameObject.AddComponent<TrainTrackSpline>
	|-GameObject.AddComponent<UIEscapeCapture>
	|-GameObject.AddComponent<AudioReverbZone>
	|-GameObject.AddComponent<AudioSource>
	|-GameObject.AddComponent<BoxCollider>
	|-GameObject.AddComponent<Camera>
	|-GameObject.AddComponent<Canvas>
	|-GameObject.AddComponent<CanvasGroup>
	|-GameObject.AddComponent<CanvasRenderer>
	|-GameObject.AddComponent<BaseInput>
	|-GameObject.AddComponent<LODGroup>
	|-GameObject.AddComponent<Light>
	|-GameObject.AddComponent<MeshCollider>
	|-GameObject.AddComponent<MeshFilter>
	|-GameObject.AddComponent<MeshRenderer>
	|-GameObject.AddComponent<RectTransform>
	|-GameObject.AddComponent<ReflectionProbe>
	|-GameObject.AddComponent<Renderer>
	|-GameObject.AddComponent<PostProcessVolume>
	|-GameObject.AddComponent<Rigidbody>
	|-GameObject.AddComponent<SkinnedMeshRenderer>
	|-GameObject.AddComponent<SpringJoint>
	|-GameObject.AddComponent<StreamingController>
	|-GameObject.AddComponent<Button>
	|-GameObject.AddComponent<Dropdown.DropdownItem>
	|-GameObject.AddComponent<Image>
	|-GameObject.AddComponent<InputField>
	|-GameObject.AddComponent<LayoutElement>
	|-GameObject.AddComponent<Outline>
	|-GameObject.AddComponent<RawImage>
	|-GameObject.AddComponent<RectMask2D>
	|-GameObject.AddComponent<Scrollbar>
	|-GameObject.AddComponent<Text>
	|-GameObject.AddComponent<UpdateHandler>
	|-GameObject.AddComponent<ViewModelRenderer>
	|-GameObject.AddComponent<WaterBody>
	|-GameObject.AddComponent<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xBE4F0 Offset: 0xBD8F0 VA: 0x1800BE4F0
	// RVA: 0x1818EE0 Offset: 0x18174E0 VA: 0x181818EE0
	public Transform get_transform() { }

	// RVA: 0x1818E60 Offset: 0x1817460 VA: 0x181818E60
	public int get_layer() { }

	// RVA: 0x1818F70 Offset: 0x1817570 VA: 0x181818F70
	public void set_layer(int value) { }

	[NativeMethodAttribute] // RVA: 0xBE700 Offset: 0xBDB00 VA: 0x1800BE700
	// RVA: 0x1818AE0 Offset: 0x18170E0 VA: 0x181818AE0
	public void SetActive(bool value) { }

	[NativeMethodAttribute] // RVA: 0xBE780 Offset: 0xBDB80 VA: 0x1800BE780
	// RVA: 0x1818DE0 Offset: 0x18173E0 VA: 0x181818DE0
	public bool get_activeSelf() { }

	[NativeMethodAttribute] // RVA: 0xBE900 Offset: 0xBDD00 VA: 0x1800BE900
	// RVA: 0x1818DA0 Offset: 0x18173A0 VA: 0x181818DA0
	public bool get_activeInHierarchy() { }

	[NativeMethodAttribute] // RVA: 0xBEA40 Offset: 0xBDE40 VA: 0x1800BEA40
	// RVA: 0x1818E20 Offset: 0x1817420 VA: 0x181818E20
	public bool get_isStatic() { }

	[NativeMethodAttribute] // RVA: 0xBEB90 Offset: 0xBDF90 VA: 0x1800BEB90
	// RVA: 0x1818F20 Offset: 0x1817520 VA: 0x181818F20
	public void set_isStatic(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xBEC10 Offset: 0xBE010 VA: 0x1800BEC10
	// RVA: 0x1818EA0 Offset: 0x18174A0 VA: 0x181818EA0
	public string get_tag() { }

	[FreeFunctionAttribute] // RVA: 0xBED10 Offset: 0xBE110 VA: 0x1800BED10
	// RVA: 0x1818FB0 Offset: 0x18175B0 VA: 0x181818FB0
	public void set_tag(string value) { }

	[FreeFunctionAttribute] // RVA: 0xBEDC0 Offset: 0xBE1C0 VA: 0x1800BEDC0
	// RVA: 0x18184E0 Offset: 0x1816AE0 VA: 0x1818184E0
	public bool CompareTag(string tag) { }

	[FreeFunctionAttribute] // RVA: 0xBEEF0 Offset: 0xBE2F0 VA: 0x1800BEEF0
	// RVA: 0x1818A70 Offset: 0x1817070 VA: 0x181818A70
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1818A10 Offset: 0x1817010 VA: 0x181818A10
	public void SendMessage(string methodName, object value) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18189C0 Offset: 0x1816FC0 VA: 0x1818189C0
	public void SendMessage(string methodName) { }

	[FreeFunctionAttribute] // RVA: 0xBF0E0 Offset: 0xBE4E0 VA: 0x1800BF0E0
	// RVA: 0x1818470 Offset: 0x1816A70 VA: 0x181818470
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18183B0 Offset: 0x18169B0 VA: 0x1818183B0
	public void BroadcastMessage(string methodName, object parameter) { }

	// RVA: 0x1818D10 Offset: 0x1817310 VA: 0x181818D10
	public void .ctor(string name) { }

	// RVA: 0x1818C90 Offset: 0x1817290 VA: 0x181818C90
	public void .ctor() { }

	// RVA: 0x1818B90 Offset: 0x1817190 VA: 0x181818B90
	public void .ctor(string name, Type[] components) { }

	[FreeFunctionAttribute] // RVA: 0xC0710 Offset: 0xBFB10 VA: 0x1800C0710
	// RVA: 0x1818910 Offset: 0x1816F10 VA: 0x181818910
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	[FreeFunctionAttribute] // RVA: 0xC0870 Offset: 0xBFC70 VA: 0x1800C0870
	// RVA: 0x1818570 Offset: 0x1816B70 VA: 0x181818570
	public static GameObject Find(string name) { }

	// RVA: 0xEC2110 Offset: 0xEC0710 VA: 0x180EC2110
	public GameObject get_gameObject() { }

}

