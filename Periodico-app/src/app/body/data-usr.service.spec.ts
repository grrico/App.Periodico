import { TestBed } from '@angular/core/testing';

import { DataUsrServiceApi } from './data-usr.service';

describe('DataUsrService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: DataUsrServiceApi = TestBed.get(DataUsrServiceApi);
    expect(service).toBeTruthy();
  });
});
