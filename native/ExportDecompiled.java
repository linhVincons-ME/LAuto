// Export decompiled C of every function to <program>.c next to the binary
import ghidra.app.script.GhidraScript;
import ghidra.app.decompiler.*;
import ghidra.program.model.listing.*;
import java.io.*;

public class ExportDecompiled extends GhidraScript {
    @Override
    public void run() throws Exception {
        String out = getScriptArgs().length > 0 ? getScriptArgs()[0] : currentProgram.getName() + ".c";
        DecompInterface ifc = new DecompInterface();
        ifc.openProgram(currentProgram);
        int n = 0, fail = 0;
        try (PrintWriter w = new PrintWriter(new OutputStreamWriter(new FileOutputStream(out), "UTF-8"))) {
            w.println("// Decompiled by Ghidra from " + currentProgram.getName());
            for (Function f : currentProgram.getFunctionManager().getFunctions(true)) {
                if (monitor.isCancelled()) break;
                DecompileResults r = ifc.decompileFunction(f, 120, monitor);
                w.println("\n// ===== " + f.getName() + " @ " + f.getEntryPoint() + " =====");
                if (r != null && r.decompileCompleted()) { w.println(r.getDecompiledFunction().getC()); n++; }
                else { w.println("// decompile failed: " + (r == null ? "null" : r.getErrorMessage())); fail++; }
            }
        }
        println("Exported " + n + " functions, failed " + fail + " -> " + out);
    }
}
