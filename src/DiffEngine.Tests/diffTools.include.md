
## Non-MDI tools

Non-MDI tools are preferred since it allows [DiffEngineTray](tray.md) to track and close diffs.


### [BeyondCompare](https://www.scootersoftware.com)

  * Cost: Paid
  * Is MDI: False
  * Supports auto-refresh: True
  * Supports text files: True
  * Supported binaries: pdf, bmp, gif, ico, jpg, jpeg, png, tif, tiff, rtf

#### Notes:

 * [Command line reference](https://www.scootersoftware.com/v4help/index.html?command_line_reference.html)

#### Windows settings:

  * Example target on left arguments: `/solo /rightreadonly "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `/solo /leftreadonly "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_BeyondCompare`
  * Default scanned paths:  
    * `%PATH%BCompare.exe`
    * `%ProgramFiles%\Beyond Compare *\BCompare.exe`
    * `%ProgramW6432%\Beyond Compare *\BCompare.exe`
    * `%ProgramFiles(x86)%\Beyond Compare *\BCompare.exe`

#### OSX settings:

  * Example target on left arguments: `-solo -rightreadonly "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `-solo -leftreadonly "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_BeyondCompare`
  * Default scanned paths:  
    * `%PATH%bcomp`
    * `/Applications/Beyond Compare.app/Contents/MacOS/bcomp`

#### Linux settings:

  * Example target on left arguments: `-solo -rightreadonly "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `-solo -leftreadonly "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_BeyondCompare`
  * Default scanned paths:  
    * `%PATH%bcomp`
    * `/usr/lib/beyondcompare/bcomp`

### [DeltaWalker](https://www.deltawalker.com/)

  * Cost: Paid
  * Is MDI: False
  * Supports auto-refresh: True
  * Supports text files: True
  * Supported binaries: jpg, jp2, j2k, png, gif, psd, tif, bmp, pct, pict, pic, ico, ppm, pgm, pbm, pnm, zip, jar, ear, tar, tgz, tbz2, gz, bz2, doc, docx, xls, xlsx, ppt, pdf, rtf, html, htm

#### Notes:

 * [Command line usage](https://www.deltawalker.com/integrate/command-line)

#### Windows settings:

  * Example target on left arguments: `-mi "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `-mi "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_DeltaWalker`
  * Default scanned paths:  
    * `%PATH%DeltaWalker.exe`
    * `C:\Program Files\Deltopia\DeltaWalker\DeltaWalker.exe`

#### OSX settings:

  * Example target on left arguments: `-mi "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `-mi "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_DeltaWalker`
  * Default scanned paths:  
    * `%PATH%DeltaWalker`
    * `/Applications/DeltaWalker.app/Contents/MacOS/DeltaWalker`

### [Diffinity](https://truehumandesign.se/s_diffinity.php)

  * Cost: Free with option to donate
  * Is MDI: False
  * Supports auto-refresh: True
  * Supports text files: True

#### Notes:

 * Disable single instance:
   \ Preferences \ Tabs \ uncheck `Use single instance and open new diffs in tabs`.

#### Windows settings:

  * Example target on left arguments: `"targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `"tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_Diffinity`
  * Default scanned paths:  
    * `%PATH%Diffinity.exe`
    * `%ProgramFiles%\Diffinity\Diffinity.exe`
    * `%ProgramW6432%\Diffinity\Diffinity.exe`
    * `%ProgramFiles(x86)%\Diffinity\Diffinity.exe`

### [DiffMerge](https://www.sourcegear.com/diffmerge/)

  * Cost: Free
  * Is MDI: False
  * Supports auto-refresh: True
  * Supports text files: True

#### Notes:

 * Ensure [Check for Modified Files](https://www.sourcegear.com/diffmerge/webhelp/sec__opt__filewindows.html) is enabled

#### Windows settings:

  * Example target on left arguments: `--nosplash "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `--nosplash "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_DiffMerge`
  * Default scanned paths:  
    * `%PATH%sgdm.exe`
    * `%ProgramFiles%\SourceGear\Common\DiffMerge\sgdm.exe`
    * `%ProgramW6432%\SourceGear\Common\DiffMerge\sgdm.exe`
    * `%ProgramFiles(x86)%\SourceGear\Common\DiffMerge\sgdm.exe`

#### OSX settings:

  * Example target on left arguments: `--nosplash "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `--nosplash "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_DiffMerge`
  * Default scanned paths:  
    * `%PATH%DiffMerge`
    * `/Applications/DiffMerge.app/Contents/MacOS/DiffMerge`

#### Linux settings:

  * Example target on left arguments: `--nosplash "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `--nosplash "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_DiffMerge`
  * Default scanned paths:  
    * `%PATH%diffmerge`

### [ExamDiff](https://www.prestosoft.com/edp_examdiffpro.asp)

  * Cost: Paid
  * Is MDI: False
  * Supports auto-refresh: True
  * Supports text files: True

#### Notes:

 * [Command line reference](https://www.prestosoft.com/ps.asp?page=htmlhelp/edp/command_line_options)
 * `/nh`: do not add files or directories to comparison history
 * `/diffonly`: diff-only merge mode: hide the merge pane

#### Windows settings:

  * Example target on left arguments: `"targetFile.txt" "tempFile.txt" /nh /diffonly /dn1:targetFile.txt /dn2:tempFile.txt `
  * Example target on right arguments: `"tempFile.txt" "targetFile.txt" /nh /diffonly /dn1:tempFile.txt /dn2:targetFile.txt `
  * Environment variable: `DiffEngine_ExamDiff`
  * Default scanned paths:  
    * `%PATH%ExamDiff.exe`
    * `%ProgramFiles%\ExamDiff Pro\ExamDiff.exe`
    * `%ProgramW6432%\ExamDiff Pro\ExamDiff.exe`
    * `%ProgramFiles(x86)%\ExamDiff Pro\ExamDiff.exe`

### [Guiffy](https://www.guiffy.com/)

  * Cost: Paid
  * Is MDI: False
  * Supports auto-refresh: False
  * Supports text files: True
  * Supported binaries: bmp, gif, jpeg, jpg, png, wbmp

#### Notes:

 * [Command line reference](https://www.guiffy.com/help/GuiffyHelp/GuiffyCmd.html)
 * [Image Diff Tool](https://www.guiffy.com/Image-Diff-Tool.html)
 * `-ge1`: Forbid first file view Editing
 * `-ge2`: Forbid second file view Editing

#### Windows settings:

  * Example target on left arguments: `"targetFile.txt" "tempFile.txt" -ge2 `
  * Example target on right arguments: `"tempFile.txt" "targetFile.txt" -ge1 `
  * Environment variable: `DiffEngine_Guiffy`
  * Default scanned paths:  
    * `%PATH%guiffy.exe`
    * `%ProgramFiles%\Guiffy\guiffy.exe`
    * `%ProgramW6432%\Guiffy\guiffy.exe`
    * `%ProgramFiles(x86)%\Guiffy\guiffy.exe`

#### OSX settings:

  * Example target on left arguments: `"targetFile.txt" "tempFile.txt" -ge2 `
  * Example target on right arguments: `"tempFile.txt" "targetFile.txt" -ge1 `
  * Environment variable: `DiffEngine_Guiffy`
  * Default scanned paths:  
    * `%PATH%guiffyCL.command`
    * `/Applications/Guiffy/guiffyCL.command`

### [Kaleidoscope](https://www.kaleidoscopeapp.com/)

  * Cost: Paid
  * Is MDI: False
  * Supports auto-refresh: True
  * Supports text files: True
  * Supported binaries: bmp, gif, ico, jpg, jpeg, png, tiff, tif

#### OSX settings:

  * Example target on left arguments: `"targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `"tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_Kaleidoscope`
  * Default scanned paths:  
    * `%PATH%ksdiff`

### [KDiff3](https://github.com/KDE/kdiff3)

  * Cost: Free
  * Is MDI: False
  * Supports auto-refresh: False
  * Supports text files: True

#### Notes:

 * `--cs CreateBakFiles=0` to not save a `.orig` file when merging

#### Windows settings:

  * Example target on left arguments: `"targetFile.txt" "tempFile.txt" --cs CreateBakFiles=0 `
  * Example target on right arguments: `"tempFile.txt" "targetFile.txt" --cs CreateBakFiles=0 `
  * Environment variable: `DiffEngine_KDiff3`
  * Default scanned paths:  
    * `%PATH%kdiff3.exe`
    * `%ProgramFiles%\KDiff3\kdiff3.exe`
    * `%ProgramW6432%\KDiff3\kdiff3.exe`
    * `%ProgramFiles(x86)%\KDiff3\kdiff3.exe`

#### OSX settings:

  * Example target on left arguments: `"targetFile.txt" "tempFile.txt" --cs CreateBakFiles=0 `
  * Example target on right arguments: `"tempFile.txt" "targetFile.txt" --cs CreateBakFiles=0 `
  * Environment variable: `DiffEngine_KDiff3`
  * Default scanned paths:  
    * `%PATH%kdiff3`
    * `/Applications/kdiff3.app/Contents/MacOS/kdiff3`

### [Neovim](https://neovim.io/)

  * Cost: Free with option to sponsor
  * Is MDI: False
  * Supports auto-refresh: False
  * Supports text files: True

#### Notes:

 * https://neovim.io/doc/user/diff.html

#### Windows settings:

  * Example target on left arguments: `-d "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `-d "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_Neovim`
  * Default scanned paths:  
    * `%PATH%nvim.exe`

#### OSX settings:

  * Example target on left arguments: `-d "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `-d "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_Neovim`
  * Default scanned paths:  
    * `%PATH%nvim`

#### Linux settings:

  * Example target on left arguments: `-d "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `-d "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_Neovim`
  * Default scanned paths:  
    * `%PATH%nvim`

### [P4Merge](https://www.perforce.com/products/helix-core-apps/merge-diff-tool-p4merge)

  * Cost: Free
  * Is MDI: False
  * Supports auto-refresh: False
  * Supports text files: True
  * Supported binaries: bmp, gif, jpg, jpeg, png, pbm, pgm, ppm, tif, tiff, xbm, xpm

#### Windows settings:

  * Example target on left arguments for text: `"targetFile.txt" "tempFile.txt" `
  * Example target on right arguments for text: `"tempFile.txt" "targetFile.txt" `
  * Example target on left arguments for binary: `-C utf8-bom "tempFile.png" "targetFile.png" "targetFile.png" "targetFile.png" `
  * Example target on right arguments for binary: `-C utf8-bom "targetFile.png" "tempFile.png" "targetFile.png" "targetFile.png" `
  * Environment variable: `DiffEngine_P4Merge`
  * Default scanned paths:  
    * `%PATH%p4merge.exe`
    * `%ProgramFiles%\Perforce\p4merge.exe`
    * `%ProgramW6432%\Perforce\p4merge.exe`
    * `%ProgramFiles(x86)%\Perforce\p4merge.exe`

#### OSX settings:

  * Example target on left arguments for text: `"targetFile.txt" "tempFile.txt" `
  * Example target on right arguments for text: `"tempFile.txt" "targetFile.txt" `
  * Example target on left arguments for binary: `-C utf8-bom "tempFile.png" "targetFile.png" "targetFile.png" "targetFile.png" `
  * Example target on right arguments for binary: `-C utf8-bom "targetFile.png" "tempFile.png" "targetFile.png" "targetFile.png" `
  * Environment variable: `DiffEngine_P4Merge`
  * Default scanned paths:  
    * `%PATH%p4merge`
    * `/Applications/p4merge.app/Contents/MacOS/p4merge`

#### Linux settings:

  * Example target on left arguments for text: `"targetFile.txt" "tempFile.txt" `
  * Example target on right arguments for text: `"tempFile.txt" "targetFile.txt" `
  * Example target on left arguments for binary: `-C utf8-bom "tempFile.png" "targetFile.png" "targetFile.png" "targetFile.png" `
  * Example target on right arguments for binary: `-C utf8-bom "targetFile.png" "tempFile.png" "targetFile.png" "targetFile.png" `
  * Environment variable: `DiffEngine_P4Merge`
  * Default scanned paths:  
    * `%PATH%p4merge`

### [Rider](https://www.jetbrains.com/rider/)

  * Cost: Paid with free option for OSS
  * Is MDI: False
  * Supports auto-refresh: True
  * Supports text files: True

#### Notes:

 * https://www.jetbrains.com/help/rider/Command_Line_Differences_Viewer.html

#### Windows settings:

  * Example target on left arguments: `diff "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `diff "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_Rider`
  * Default scanned paths:  
    * `%PATH%rider64.exe`
    * `%LOCALAPPDATA%\JetBrains\Installations\Rider*\bin\rider64.exe`
    * `%ProgramFiles%\JetBrains\JetBrains Rider *\bin\rider64.exe`
    * `%ProgramW6432%\JetBrains\JetBrains Rider *\bin\rider64.exe`
    * `%ProgramFiles(x86)%\JetBrains\JetBrains Rider *\bin\rider64.exe`
    * `%JetBrains Rider%\rider64.exe`
    * `%LOCALAPPDATA%\JetBrains\Toolbox\apps\Rider\*\*\bin\rider64.exe`

#### OSX settings:

  * Example target on left arguments: `diff "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `diff "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_Rider`
  * Default scanned paths:  
    * `%PATH%rider`
    * `%HOME%/Library/Application Support/JetBrains/Toolbox/apps/Rider/*/*/Rider EAP.app/Contents/MacOS/rider`
    * `%HOME%/Library/Application Support/JetBrains/Toolbox/apps/Rider/*/*/Rider.app/Contents/MacOS/rider`
    * `/Applications/Rider EAP.app/Contents/MacOS/rider`
    * `/Applications/Rider.app/Contents/MacOS/rider`

#### Linux settings:

  * Example target on left arguments: `diff "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `diff "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_Rider`
  * Default scanned paths:  
    * `%PATH%rider.sh`
    * `%HOME%/.local/share/JetBrains/Toolbox/apps/Rider/*/*/bin/rider.sh`
    * `/opt/jetbrains/rider/bin/rider.sh`
    * `/usr/share/rider/bin/rider.sh`

### [TkDiff](https://sourceforge.net/projects/tkdiff/)

  * Cost: Free
  * Is MDI: False
  * Supports auto-refresh: False
  * Supports text files: True

#### OSX settings:

  * Example target on left arguments: `"targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `"tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_TkDiff`
  * Default scanned paths:  
    * `%PATH%tkdiff`
    * `/Applications/TkDiff.app/Contents/MacOS/tkdiff`

### [TortoiseGitIDiff](https://tortoisegit.org/docs/tortoisegitmerge/)

  * Cost: Free
  * Is MDI: False
  * Supports auto-refresh: False
  * Supports text files: False
  * Supported binaries: bmp, gif, ico, jpg, jpeg, png, tif, tiff

#### Windows settings:

  * Example target on left arguments: `"targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `"tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_TortoiseGitIDiff`
  * Default scanned paths:  
    * `%PATH%TortoiseGitIDiff.exe`
    * `%ProgramFiles%\TortoiseGit\bin\TortoiseGitIDiff.exe`
    * `%ProgramW6432%\TortoiseGit\bin\TortoiseGitIDiff.exe`
    * `%ProgramFiles(x86)%\TortoiseGit\bin\TortoiseGitIDiff.exe`

### [TortoiseGitMerge](https://tortoisegit.org/docs/tortoisegitmerge/)

  * Cost: Free
  * Is MDI: False
  * Supports auto-refresh: False
  * Supports text files: True

#### Windows settings:

  * Example target on left arguments: `"targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `"tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_TortoiseGitMerge`
  * Default scanned paths:  
    * `%PATH%TortoiseGitMerge.exe`
    * `%ProgramFiles%\TortoiseGit\bin\TortoiseGitMerge.exe`
    * `%ProgramW6432%\TortoiseGit\bin\TortoiseGitMerge.exe`
    * `%ProgramFiles(x86)%\TortoiseGit\bin\TortoiseGitMerge.exe`

### [TortoiseIDiff](https://tortoisesvn.net/TortoiseIDiff.html)

  * Cost: Free
  * Is MDI: False
  * Supports auto-refresh: False
  * Supports text files: False
  * Supported binaries: bmp, gif, ico, jpg, jpeg, png, tif, tiff

#### Windows settings:

  * Example target on left arguments: `/left:"targetFile.txt" /right:"tempFile.txt" `
  * Example target on right arguments: `/left:"tempFile.txt" /right:"targetFile.txt" `
  * Environment variable: `DiffEngine_TortoiseIDiff`
  * Default scanned paths:  
    * `%PATH%TortoiseIDiff.exe`
    * `%ProgramFiles%\TortoiseSVN\bin\TortoiseIDiff.exe`
    * `%ProgramW6432%\TortoiseSVN\bin\TortoiseIDiff.exe`
    * `%ProgramFiles(x86)%\TortoiseSVN\bin\TortoiseIDiff.exe`

### [TortoiseMerge](https://tortoisesvn.net/TortoiseMerge.html)

  * Cost: Free
  * Is MDI: False
  * Supports auto-refresh: False
  * Supports text files: True

#### Windows settings:

  * Example target on left arguments: `"targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `"tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_TortoiseMerge`
  * Default scanned paths:  
    * `%PATH%TortoiseMerge.exe`
    * `%ProgramFiles%\TortoiseSVN\bin\TortoiseMerge.exe`
    * `%ProgramW6432%\TortoiseSVN\bin\TortoiseMerge.exe`
    * `%ProgramFiles(x86)%\TortoiseSVN\bin\TortoiseMerge.exe`

### [Vim](https://www.vim.org/)

  * Cost: Free with option to donate
  * Is MDI: False
  * Supports auto-refresh: True
  * Supports text files: True

#### Notes:

 * [Options](http://vimdoc.sourceforge.net/htmldoc/options.html)
 * [Vim help files](https://vimhelp.org/)
 * [autoread](http://vimdoc.sourceforge.net/htmldoc/options.html#'autoread')
 * [nobackup](http://vimdoc.sourceforge.net/htmldoc/options.html#'backup')
 * [noswapfile](http://vimdoc.sourceforge.net/htmldoc/options.html#'swapfile')

#### Windows settings:

  * Example target on left arguments: `-d "targetFile.txt" "tempFile.txt" -c "setl autoread | setl nobackup | set noswapfile" `
  * Example target on right arguments: `-d "tempFile.txt" "targetFile.txt" -c "setl autoread | setl nobackup | set noswapfile" `
  * Environment variable: `DiffEngine_Vim`
  * Default scanned paths:  
    * `%PATH%vim.exe`
    * `%ProgramFiles%\Vim\*\vim.exe`
    * `%ProgramW6432%\Vim\*\vim.exe`
    * `%ProgramFiles(x86)%\Vim\*\vim.exe`

#### OSX settings:

  * Example target on left arguments: `-d "targetFile.txt" "tempFile.txt" -c "setl autoread | setl nobackup | set noswapfile" `
  * Example target on right arguments: `-d "tempFile.txt" "targetFile.txt" -c "setl autoread | setl nobackup | set noswapfile" `
  * Environment variable: `DiffEngine_Vim`
  * Default scanned paths:  
    * `%PATH%mvim`
    * `/Applications/MacVim.app/Contents/bin/mvim`

### [WinMerge](https://winmerge.org/)

  * Cost: Free with option to donate
  * Is MDI: False
  * Supports auto-refresh: True
  * Supports text files: True
  * Supported binaries: bmp, cut, dds, exr, g3, gif, hdr, ico, iff, lbm, j2k, j2c, jng, jp2, jpg, jif, jpeg, jpe, jxr, wdp, hdp, koa, mng, pcd, pcx, pfm, pct, pict, pic, png, pbm, pgm, ppm, psd, ras, sgi, rgb, rgba, bw, tga, targa, tif, tiff, wap, wbmp, wbm, webp, xbm, xpm

#### Notes:

 * [Command line reference](https://manual.winmerge.org/en/Command_line.html).
 * `/u` Prevents WinMerge from adding paths to the Most Recently Used (MRU) list.
 * `/wl` Opens the left side as read-only.
 * `/dl` and `/dr` Specifies file descriptions in the title bar.
 * `/e` Enables close with a single Esc key press.

#### Windows settings:

  * Example target on left arguments: `/u /wr /e "targetFile.txt" "tempFile.txt" /dl "targetFile.txt" /dr "tempFile.txt" `
  * Example target on right arguments: `/u /wl /e "tempFile.txt" "targetFile.txt" /dl "tempFile.txt" /dr "targetFile.txt" `
  * Environment variable: `DiffEngine_WinMerge`
  * Default scanned paths:  
    * `%PATH%WinMergeU.exe`
    * `%ProgramFiles%\WinMerge\WinMergeU.exe`
    * `%ProgramW6432%\WinMerge\WinMergeU.exe`
    * `%ProgramFiles(x86)%\WinMerge\WinMergeU.exe`
    * `%LocalAppData%\Programs\WinMerge\WinMergeU.exe`

## MDI tools


### [AraxisMerge](https://www.araxis.com/merge)

  * Cost: Paid
  * Is MDI: True
  * Supports auto-refresh: True
  * Supports text files: True
  * Supported binaries: bmp, dib, emf, gif, jif, j2c, j2k, jp2, jpc, jpeg, jpg, jpx, pbm, pcx, pgm, png, ppm, ras, tif, tiff, tga, wmf

#### Notes:

 * [Supported image files](https://www.araxis.com/merge/documentation-windows/comparing-image-files.en)
 * [Windows command line usage](https://www.araxis.com/merge/documentation-windows/command-line.en)
 * [MacOS command line usage](https://www.araxis.com/merge/documentation-os-x/command-line.en)
 * [Installing MacOS command line](https://www.araxis.com/merge/documentation-os-x/installing.en)

#### Windows settings:

  * Example target on left arguments: `/nowait "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `/nowait "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_AraxisMerge`
  * Default scanned paths:  
    * `%PATH%Compare.exe`
    * `%ProgramFiles%\Araxis\Araxis Merge\Compare.exe`
    * `%ProgramW6432%\Araxis\Araxis Merge\Compare.exe`
    * `%ProgramFiles(x86)%\Araxis\Araxis Merge\Compare.exe`

#### OSX settings:

  * Example target on left arguments: `-nowait "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `-nowait "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_AraxisMerge`
  * Default scanned paths:  
    * `%PATH%compare`
    * `/Applications/Araxis Merge.app/Contents/Utilities/compare`

### [CodeCompare](https://www.devart.com/codecompare/)

  * Cost: Paid
  * Is MDI: True
  * Supports auto-refresh: False
  * Supports text files: True

#### Notes:

 * [Command line reference](https://docs.devart.com/code-compare/using-command-line/comparing-via-command-line.html)

#### Windows settings:

  * Example target on left arguments: `"targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `"tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_CodeCompare`
  * Default scanned paths:  
    * `%PATH%CodeCompare.exe`
    * `%ProgramFiles%\Devart\Code Compare\CodeCompare.exe`
    * `%ProgramW6432%\Devart\Code Compare\CodeCompare.exe`
    * `%ProgramFiles(x86)%\Devart\Code Compare\CodeCompare.exe`

### [Meld](https://meldmerge.org/)

  * Cost: Free
  * Is MDI: True
  * Supports auto-refresh: False
  * Supports text files: True

#### Notes:

 * While Meld is not MDI, it is treated as MDI since it uses a single shared process to managing multiple windows. As such it is not possible to close a Meld merge process for a specific diff. [Vote for this feature](https://gitlab.gnome.org/GNOME/meld/-/issues/584)

#### Windows settings:

  * Example target on left arguments: `"targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `"tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_Meld`
  * Default scanned paths:  
    * `%PATH%meld.exe`
    * `%LOCALAPPDATA%\Programs\Meld\meld.exe`
    * `%ProgramFiles%\Meld\meld.exe`
    * `%ProgramW6432%\Meld\meld.exe`
    * `%ProgramFiles(x86)%\Meld\meld.exe`

#### OSX settings:

  * Example target on left arguments: `"targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `"tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_Meld`
  * Default scanned paths:  
    * `%PATH%meld`
    * `/Applications/meld.app/Contents/MacOS/meld`

#### Linux settings:

  * Example target on left arguments: `"targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `"tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_Meld`
  * Default scanned paths:  
    * `%PATH%meld`

### [SublimeMerge](https://www.sublimemerge.com/)

  * Cost: Paid
  * Is MDI: True
  * Supports auto-refresh: False
  * Supports text files: True

#### Notes:

 * While SublimeMerge is not MDI, it is treated as MDI since it uses a single shared process to managing multiple windows. As such it is not possible to close a Sublime merge process for a specific diff. [Vote for this feature](https://github.com/sublimehq/sublime_merge/issues/1168)

#### Windows settings:

  * Example target on left arguments: `mergetool "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `mergetool "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_SublimeMerge`
  * Default scanned paths:  
    * `%PATH%smerge.exe`
    * `%ProgramFiles%\Sublime Merge\smerge.exe`
    * `%ProgramW6432%\Sublime Merge\smerge.exe`
    * `%ProgramFiles(x86)%\Sublime Merge\smerge.exe`

#### OSX settings:

  * Example target on left arguments: `mergetool "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `mergetool "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_SublimeMerge`
  * Default scanned paths:  
    * `%PATH%smerge`
    * `/Applications/smerge.app/Contents/MacOS/smerge`

#### Linux settings:

  * Example target on left arguments: `mergetool "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `mergetool "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_SublimeMerge`
  * Default scanned paths:  
    * `%PATH%smerge`

### [VisualStudio](https://docs.microsoft.com/en-us/visualstudio/ide/reference/diff)

  * Cost: Paid and free options
  * Is MDI: True
  * Supports auto-refresh: True
  * Supports text files: True

#### Windows settings:

  * Example target on left arguments: `/diff "targetFile.txt" "tempFile.txt" "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `/diff "tempFile.txt" "targetFile.txt" "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_VisualStudio`
  * Default scanned paths:  
    * `%PATH%devenv.exe`
    * `%ProgramFiles%\Microsoft Visual Studio\2022\Preview\Common7\IDE\devenv.exe`
    * `%ProgramW6432%\Microsoft Visual Studio\2022\Preview\Common7\IDE\devenv.exe`
    * `%ProgramFiles(x86)%\Microsoft Visual Studio\2022\Preview\Common7\IDE\devenv.exe`
    * `%ProgramFiles%\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe`
    * `%ProgramW6432%\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe`
    * `%ProgramFiles(x86)%\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe`
    * `%ProgramFiles%\Microsoft Visual Studio\2022\Professional\Common7\IDE\devenv.exe`
    * `%ProgramW6432%\Microsoft Visual Studio\2022\Professional\Common7\IDE\devenv.exe`
    * `%ProgramFiles(x86)%\Microsoft Visual Studio\2022\Professional\Common7\IDE\devenv.exe`
    * `%ProgramFiles%\Microsoft Visual Studio\2022\Enterprise\Common7\IDE\devenv.exe`
    * `%ProgramW6432%\Microsoft Visual Studio\2022\Enterprise\Common7\IDE\devenv.exe`
    * `%ProgramFiles(x86)%\Microsoft Visual Studio\2022\Enterprise\Common7\IDE\devenv.exe`

### [VisualStudioCode](https://code.visualstudio.com)

  * Cost: Free
  * Is MDI: True
  * Supports auto-refresh: True
  * Supports text files: True

#### Notes:

 * [Command line reference](https://code.visualstudio.com/docs/editor/command-line)

#### Windows settings:

  * Example target on left arguments: `--diff "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `--diff "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_VisualStudioCode`
  * Default scanned paths:  
    * `%PATH%code.exe`
    * `%LocalAppData%\Programs\Microsoft VS Code\code.exe`
    * `%ProgramFiles%\Microsoft VS Code\code.exe`
    * `%ProgramW6432%\Microsoft VS Code\code.exe`
    * `%ProgramFiles(x86)%\Microsoft VS Code\code.exe`

#### OSX settings:

  * Example target on left arguments: `--diff "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `--diff "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_VisualStudioCode`
  * Default scanned paths:  
    * `%PATH%code`
    * `/Applications/Visual Studio Code.app/Contents/Resources/app/bin/code`

#### Linux settings:

  * Example target on left arguments: `--diff "targetFile.txt" "tempFile.txt" `
  * Example target on right arguments: `--diff "tempFile.txt" "targetFile.txt" `
  * Environment variable: `DiffEngine_VisualStudioCode`
  * Default scanned paths:  
    * `%PATH%code`
