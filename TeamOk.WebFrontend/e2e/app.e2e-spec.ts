import { TeamOk.WebFrontendPage } from './app.po';

describe('team-ok.web-frontend App', () => {
  let page: TeamOk.WebFrontendPage;

  beforeEach(() => {
    page = new TeamOk.WebFrontendPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
