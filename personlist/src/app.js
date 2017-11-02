export class App {
  constructor() {
    this.message = 'Hello World!';
    this.getValues();
  }

  getValues() {
    fetch('http://localhost:5000/api/person/all', {
      method: 'GET',
    }).then(resp => resp.json())
    .then(obj => {
      this.list = obj;
    });
  }
}
