import { TestBed } from '@angular/core/testing';

import { PeridicoEstadoServiceApi } from './estado.service';

describe('EstadoService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: PeridicoEstadoServiceApi = TestBed.get(PeridicoEstadoServiceApi);
    expect(service).toBeTruthy();
  });
});
