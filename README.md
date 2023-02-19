## 概要
Unityで様々なRoslyn Analyzerの導入を検証するためのリポジトリ

## Microsoft.Unity.Analyzers
[Microsoft.Unity.Analyzers](https://github.com/microsoft/Microsoft.Unity.Analyzers)はUnityプロジェクト向けに開発された`GameObject.Find`のような処理のコストが高いメソッドの呼び出しなどを検知し警告などを行えるようにするRoslyn Analyzerです。

### 導入方法
[nuget](https://www.nuget.org/packages/Microsoft.Unity.Analyzers/1.15.0)からパッケージをDLし、.nupkgを.zipに編集し解凍する。
`analyzers\dotnet\cs`以下にある`Microsoft.Unity.Analyzers.dll`を探してUnity Project内に配置する。

導入後、dllのimport settingから下記のように設定する。

- Select platforms for pluginのチェックをすべて外す
- Asset Labelsに`RoslynAnalyzer`を設定する

![Microsoft.Unity.AnalyzersのImport Settings](Reference/microsoft_unity_analyzers_import_settings)