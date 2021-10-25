# PrevuProjects

### How to setup:

- Clone
- Restore NuGets
- Copy Prevu.Synoptics.zip from the solution folder to %userprofile%\Documents\Visual Studio 2019\Templates\ProjectTemplates
- Restart VisualStudio or in command prompt run "devenv /installvstemplates"

### How to use for a new project:

- Create new branch from master called Vxxxx (number of project)
- Add new project to the Synoptics folder (right click, add new project...)
- Select Prevu.Synoptics template, use naming scheme Prevu.Synoptics.Vxxxx
- Open properties for the new project. In Build Events change the post-build event to the appropriate command, if needed
- In Test project right click on Dependencies, Add Project Reference and select only the new project
- Run Test application, then close it
- Now you can start creating Synoptic Pages.
