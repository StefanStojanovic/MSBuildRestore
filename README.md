# MSBuildRestore

A simple solution showcasing issues with MSBuild on a specific solution layout.

# MSBuild /t:Restore issue

When there are two or more project files in the same directory as the solution file, running `msbuild /t:restore SolutionFile.sln` will only run restore on one of those projects and the choice of the project seems stochastic.

Outputs of running `msbuild /t:Restore MSBuildRestore.sln` with different results can be viewed at [RestoreConsoleApp.txt](Output/RestoreConsoleApp.txt) and [RestoreClassLibrary.txt](Output/RestoreClassLibrary.txt)

As a result of problems with restoring, building the solution, eg. running `msbuild /t:Clean,Build SolutionFile.sln`, will fail as well. An example of that can be viewed at [BuildSolution.txt](Output/BuildSolution.txt)
