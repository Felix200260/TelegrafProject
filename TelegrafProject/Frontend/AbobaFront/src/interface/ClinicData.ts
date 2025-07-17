interface ClinicData {
    statusStats: {
        online: number;
        unstable: number;
        offline: number;
    };
    activeAnalyzers: Analyzer[];
    disconnectedAnalyzers: Analyzer[];
    unusedAnalyzers: Analyzer[];
}