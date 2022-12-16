# MSBuild Restore Issue

This sometimes works and sometimes fails:

```
msbuild /t:restore SolutionFile.sln
```

When there are two or more project files in the same directory as the solution file,
running MSBuild Restore will only run restore on one of those projects, and the choice of the project seems stochastic.

- When the project picked is the ConsoleApp, it restores the ClassLibrary as well and there's no issue:
  [RestoreConsoleApp.txt](Output/RestoreConsoleApp.txt).
- When the project picked is the ClassLibrary, the ConsoleApp is not restored:
  [RestoreClassLibrary.txt](Output/RestoreClassLibrary.txt). When building the solution with
  `msbuild /t:Clean,Build SolutionFile.sln`, the build will fail: [BuildSolution.txt](Output/BuildSolution.txt).

A simple fix for this is to move the projects to independent subdirectories. However, this can take a while to figure out,
and at least a warning should be included in the MSBuild output.