// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ue57SteamAudio : ModuleRules
{
	public ue57SteamAudio(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ue57SteamAudio",
			"ue57SteamAudio/Variant_Platforming",
			"ue57SteamAudio/Variant_Platforming/Animation",
			"ue57SteamAudio/Variant_Combat",
			"ue57SteamAudio/Variant_Combat/AI",
			"ue57SteamAudio/Variant_Combat/Animation",
			"ue57SteamAudio/Variant_Combat/Gameplay",
			"ue57SteamAudio/Variant_Combat/Interfaces",
			"ue57SteamAudio/Variant_Combat/UI",
			"ue57SteamAudio/Variant_SideScrolling",
			"ue57SteamAudio/Variant_SideScrolling/AI",
			"ue57SteamAudio/Variant_SideScrolling/Gameplay",
			"ue57SteamAudio/Variant_SideScrolling/Interfaces",
			"ue57SteamAudio/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
