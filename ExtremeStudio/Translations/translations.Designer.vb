﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Public Class translations
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("ExtremeStudio.translations", GetType(translations).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Install Plugin.
        '''</summary>
        Public Shared ReadOnly Property EsPluginsForm_PluginList_Click_InstallPlugin() As String
            Get
                Return ResourceManager.GetString("EsPluginsForm_PluginList_Click_InstallPlugin", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ReInstall Plugin.
        '''</summary>
        Public Shared ReadOnly Property EsPluginsForm_PluginList_Click_ReInstallPlugin() As String
            Get
                Return ResourceManager.GetString("EsPluginsForm_PluginList_Click_ReInstallPlugin", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The include &apos;{0}&apos; has been successfully installed..
        '''</summary>
        Public Shared ReadOnly Property IncludesForm_Button1_Click_IncludeInstalled() As String
            Get
                Return ResourceManager.GetString("IncludesForm_Button1_Click_IncludeInstalled", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The include can&apos;t be found in the cache..
        '''</summary>
        Public Shared ReadOnly Property IncludesForm_Button1_Click_IncludeNotFoundCache() As String
            Get
                Return ResourceManager.GetString("IncludesForm_Button1_Click_IncludeNotFoundCache", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The include is cached, No description is available..
        '''</summary>
        Public Shared ReadOnly Property IncludesForm_IncludesForm_Load_IncludeCached() As String
            Get
                Return ResourceManager.GetString("IncludesForm_IncludesForm_Load_IncludeCached", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to This include needs the {0} plugin to work..
        '''</summary>
        Public Shared ReadOnly Property IncludesForm_includesList_SelectedIndexChanged_IncludeNeedsPlugin() As String
            Get
                Return ResourceManager.GetString("IncludesForm_includesList_SelectedIndexChanged_IncludeNeedsPlugin", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Install Include.
        '''</summary>
        Public Shared ReadOnly Property IncludesForm_includesList_SelectedIndexChanged_InstallInclude() As String
            Get
                Return ResourceManager.GetString("IncludesForm_includesList_SelectedIndexChanged_InstallInclude", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Reinstall Include.
        '''</summary>
        Public Shared ReadOnly Property IncludesForm_includesList_SelectedIndexChanged_ReinstallInclude() As String
            Get
                Return ResourceManager.GetString("IncludesForm_includesList_SelectedIndexChanged_ReinstallInclude", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The file pawncc.exe hasn&apos;t been found at the path.
        '''</summary>
        Public Shared ReadOnly Property MainForm_CompilerWorker_DoWork_PawnccNotFound() As String
            Get
                Return ResourceManager.GetString("MainForm_CompilerWorker_DoWork_PawnccNotFound", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please verify its there..
        '''</summary>
        Public Shared ReadOnly Property MainForm_CompilerWorker_DoWork_VerifyPawnccIsThere() As String
            Get
                Return ResourceManager.GetString("MainForm_CompilerWorker_DoWork_VerifyPawnccIsThere", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Would you like to save all files ?.
        '''</summary>
        Public Shared ReadOnly Property MainForm_CompilerWorker_DoWork_WouldYouLikeToSaveFiles() As String
            Get
                Return ResourceManager.GetString("MainForm_CompilerWorker_DoWork_WouldYouLikeToSaveFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Compiling....
        '''</summary>
        Public Shared ReadOnly Property MainForm_CompilerWorker_ProgressChanged_Compiling() As String
            Get
                Return ResourceManager.GetString("MainForm_CompilerWorker_ProgressChanged_Compiling", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Compiling finished sucessfully with no errors/warnings..
        '''</summary>
        Public Shared ReadOnly Property MainForm_CompilerWorker_ProgressChanged_CompilingDoneWithNoErrorsWarnings() As String
            Get
                Return ResourceManager.GetString("MainForm_CompilerWorker_ProgressChanged_CompilingDoneWithNoErrorsWarnings", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Compiling finished successfully but there are warning(s)..
        '''</summary>
        Public Shared ReadOnly Property MainForm_CompilerWorker_ProgressChanged_CompilingDoneWithWarnings() As String
            Get
                Return ResourceManager.GetString("MainForm_CompilerWorker_ProgressChanged_CompilingDoneWithWarnings", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Compiling failed with errors/warnings..
        '''</summary>
        Public Shared ReadOnly Property MainForm_CompilerWorker_ProgressChanged_CompilingFailedWithErrors() As String
            Get
                Return ResourceManager.GetString("MainForm_CompilerWorker_ProgressChanged_CompilingFailedWithErrors", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please wait until the current compilation or parsing process is finished..
        '''</summary>
        Public Shared ReadOnly Property MainForm_compileScriptBtn_Click_WaitForCompile() As String
            Get
                Return ResourceManager.GetString("MainForm_compileScriptBtn_Click_WaitForCompile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The plugin can&apos;t be found in the cache..
        '''</summary>
        Public Shared ReadOnly Property PluginsForm_Button1_Click_PluginCantBeFoundInCache() As String
            Get
                Return ResourceManager.GetString("PluginsForm_Button1_Click_PluginCantBeFoundInCache", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The plugin &apos;{0}&apos; has been successfully installed..
        '''</summary>
        Public Shared ReadOnly Property PluginsForm_Button1_Click_PluginInstalled() As String
            Get
                Return ResourceManager.GetString("PluginsForm_Button1_Click_PluginInstalled", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Add to server.cfg.
        '''</summary>
        Public Shared ReadOnly Property PluginsForm_includesList_SelectedIndexChanged_AddToServerCfg() As String
            Get
                Return ResourceManager.GetString("PluginsForm_includesList_SelectedIndexChanged_AddToServerCfg", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Install Plugin.
        '''</summary>
        Public Shared ReadOnly Property PluginsForm_includesList_SelectedIndexChanged_InstallPlugin() As String
            Get
                Return ResourceManager.GetString("PluginsForm_includesList_SelectedIndexChanged_InstallPlugin", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Reinstall Plugin.
        '''</summary>
        Public Shared ReadOnly Property PluginsForm_includesList_SelectedIndexChanged_ReinstallPlugin() As String
            Get
                Return ResourceManager.GetString("PluginsForm_includesList_SelectedIndexChanged_ReinstallPlugin", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Remove from server.cfg.
        '''</summary>
        Public Shared ReadOnly Property PluginsForm_includesList_SelectedIndexChanged_RemoveFromServerCfg() As String
            Get
                Return ResourceManager.GetString("PluginsForm_includesList_SelectedIndexChanged_RemoveFromServerCfg", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to This plugin needs the {0} include to work..
        '''</summary>
        Public Shared ReadOnly Property PluginsForm_includesList_SelectedIndexChanged_ThisPluginNeedsTheIncludeToWork() As String
            Get
                Return ResourceManager.GetString("PluginsForm_includesList_SelectedIndexChanged_ThisPluginNeedsTheIncludeToWork", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The plugin is cached, No description is available..
        '''</summary>
        Public Shared ReadOnly Property PluginsForm_PluginsForm_Load_PluginCached() As String
            Get
                Return ResourceManager.GetString("PluginsForm_PluginsForm_Load_PluginCached", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Exported Successfully!.
        '''</summary>
        Public Shared ReadOnly Property SettingsForm_exportBtn_Click_ExporteSuccess() As String
            Get
                Return ResourceManager.GetString("SettingsForm_exportBtn_Click_ExporteSuccess", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Select Target..
        '''</summary>
        Public Shared ReadOnly Property SettingsForm_exportBtn_Click_OpenFileDialogTitle() As String
            Get
                Return ResourceManager.GetString("SettingsForm_exportBtn_Click_OpenFileDialogTitle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Select Source..
        '''</summary>
        Public Shared ReadOnly Property SettingsForm_importBtn_Click_OpenFileDialogTitle() As String
            Get
                Return ResourceManager.GetString("SettingsForm_importBtn_Click_OpenFileDialogTitle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Settings. [GLOBAL].
        '''</summary>
        Public Shared ReadOnly Property SettingsForm_IsGlobal_SettingsGLOBAL() As String
            Get
                Return ResourceManager.GetString("SettingsForm_IsGlobal_SettingsGLOBAL", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Settings. [PROJECT].
        '''</summary>
        Public Shared ReadOnly Property SettingsForm_IsGlobal_SettingsPROJECT() As String
            Get
                Return ResourceManager.GetString("SettingsForm_IsGlobal_SettingsPROJECT", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Are you sure you want to reset to default settings ?.
        '''</summary>
        Public Shared ReadOnly Property SettingsForm_resetBtn_Click_ResetDefaultSettings() As String
            Get
                Return ResourceManager.GetString("SettingsForm_resetBtn_Click_ResetDefaultSettings", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 
        '''
        '''Would you like to continue ?.
        '''</summary>
        Public Shared ReadOnly Property StartupForm_Button1_Click_WouldYouLikeToContinue() As String
            Get
                Return ResourceManager.GetString("StartupForm_Button1_Click_WouldYouLikeToContinue", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to That directory doesn&apos;t exist or there is a project with that name already there..
        '''</summary>
        Public Shared ReadOnly Property StartupForm_CreateProjectBtn_Click_DirError() As String
            Get
                Return ResourceManager.GetString("StartupForm_CreateProjectBtn_Click_DirError", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid Name..
        '''</summary>
        Public Shared ReadOnly Property StartupForm_CreateProjectBtn_Click_InvalidName() As String
            Get
                Return ResourceManager.GetString("StartupForm_CreateProjectBtn_Click_InvalidName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid SAMP Folder.. 
        '''Must contain the pawno folder, gamemodes folder, plugins folder, all executables and the server config..
        '''</summary>
        Public Shared ReadOnly Property StartupForm_CreateProjectBtn_Click_InvalidSampFolder() As String
            Get
                Return ResourceManager.GetString("StartupForm_CreateProjectBtn_Click_InvalidSampFolder", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You haven&apos;t selected a SAMP version to use..
        '''</summary>
        Public Shared ReadOnly Property StartupForm_CreateProjectBtn_Click_NoSampSelected() As String
            Get
                Return ResourceManager.GetString("StartupForm_CreateProjectBtn_Click_NoSampSelected", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ERROR: That folder isn&apos;t a valid ExtremeStudio project. Make sure you haven&apos;t deleted or modified any file manually..
        '''</summary>
        Public Shared ReadOnly Property StartupForm_pathTextBox_TextChanged_InvalidESPrj() As String
            Get
                Return ResourceManager.GetString("StartupForm_pathTextBox_TextChanged_InvalidESPrj", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to None.
        '''</summary>
        Public Shared ReadOnly Property StartupForm_pathTextBox_TextChanged_None() As String
            Get
                Return ResourceManager.GetString("StartupForm_pathTextBox_TextChanged_None", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Project version is newer then ExtremeStudio&apos;s version, Please download latest ExtremeStudio package..
        '''</summary>
        Public Shared ReadOnly Property StartupForm_pathTextBox_TextChanged_ProjectVersionNewer() As String
            Get
                Return ResourceManager.GetString("StartupForm_pathTextBox_TextChanged_ProjectVersionNewer", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Project older then ExtremeStudio, Conversion will be done however it may bug with older versions so its recommended to not try..
        '''</summary>
        Public Shared ReadOnly Property StartupForm_pathTextBox_TextChanged_ProjectVersionOlder() As String
            Get
                Return ResourceManager.GetString("StartupForm_pathTextBox_TextChanged_ProjectVersionOlder", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Project version is the same as ExtremeStudio&apos;s version, No converion is needed..
        '''</summary>
        Public Shared ReadOnly Property StartupForm_pathTextBox_TextChanged_ProjectVersionSame() As String
            Get
                Return ResourceManager.GetString("StartupForm_pathTextBox_TextChanged_ProjectVersionSame", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
