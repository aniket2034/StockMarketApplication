import { TestBed } from '@angular/core/testing';

import { StockExchangeServiceService } from './stock-exchange-service.service';

describe('StockExchangeServiceService', () => {
  let service: StockExchangeServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(StockExchangeServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
