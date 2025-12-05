.\Utilities\NStrip\NStrip.exe -p -n -d .\Packages\KSP2_x64 -cg --cg-exclude-events --unity-non-serialized .\Packages\KSP2_x64\Assembly-CSharp.dll .\Assembly-CSharp.tmp
rm .\Packages\KSP2_x64\Assembly-CSharp.dll
mv .\Assembly-CSharp.tmp .\Packages\KSP2_x64\Assembly-CSharp.dll