using System.Reflection;
using System.Resources;

[assembly: AssemblyCompany ("Mobile Essentials")]
[assembly: AssemblyProduct ("Xamarin.Forms.Dynamic")]
[assembly: AssemblyCopyright ("Copyright © Mobile Essentials 2015")]
[assembly: AssemblyTrademark ("")]
[assembly: AssemblyCulture ("")]
[assembly: NeutralResourcesLanguage ("en")]

[assembly: AssemblyTitle ("Xamarin.Forms.Dynamic")]
[assembly: AssemblyDescription ("Provides dynamic loading of XAML onto views, as well as dynamic JSON and dictionary-based view models.")]

#if DEBUG
[assembly: AssemblyConfiguration ("DEBUG")]
#else
[assembly: AssemblyConfiguration("RELEASE")]
#endif


//// AssemblyVersion = full version info, since it's used to determine agents versions
//[assembly: AssemblyVersion (ThisAssembly.Version)]
//// FileVersion = release-like simple version (i.e. 3.11.2 for cycle 5, SR2).
//[assembly: AssemblyFileVersion (ThisAssembly.SimpleVersion)]
//// InformationalVersion = full version + branch + commit sha.
//[assembly: AssemblyInformationalVersion (ThisAssembly.InformationalVersion)]