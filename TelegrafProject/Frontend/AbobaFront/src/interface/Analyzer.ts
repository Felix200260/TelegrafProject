interface Analyzer {
    id: number;
    name: string;
    ip: string;
    protocol?: string;
    port?: number;
    status: string;
    hasExpandButton?: boolean;
}