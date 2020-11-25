import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PollRoomComponent } from './poll-room.component';

describe('PollRoomComponent', () => {
  let component: PollRoomComponent;
  let fixture: ComponentFixture<PollRoomComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PollRoomComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PollRoomComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
