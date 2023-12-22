export interface Hero {
  name: string,
  power: string,
  stats: KeyValuePair[]
}

interface KeyValuePair {
  key: string;
  value: number;
}
