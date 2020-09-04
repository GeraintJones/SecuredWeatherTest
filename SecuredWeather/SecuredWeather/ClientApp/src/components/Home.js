import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
        <div>
            <h1>Hello, Belfast!</h1>
            <p>Single-page application to retrive the current 5 day forecast for Belfast.</p>
        </div>
    );
  }
}
