import { TestBed } from '@angular/core/testing';

import { StockCompanyService } from './stock-company.service';

describe('StockCompanyService', () => {
  let service: StockCompanyService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(StockCompanyService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
