import 'bootstrap/dist/css/bootstrap.css';
import 'bootstrap/dist/css/bootstrap-theme.css';
import './index.css';
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter } from 'react-router-dom';
import App from './App';
import registerServiceWorker from './registerServiceWorker';

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const rootElement = document.getElementById('root');

ReactDOM.render(
  <BrowserRouter basename={baseUrl}>
    <App />
  </BrowserRouter>,
    rootElement);

//import React, { Component } from 'react';
//import Page from './SearchValue.html';  // search HTML file 
//var htmlDoc = { __html: Page };

//export default class Doc extends Component {
//    constructor(props) {
//        super(props);
//    }

//    render() {
//        return (<div dangerouslySetInnerHTML={htmlDoc} />)
//    }
//
//export default function MyComponent() {
//    return (
//        <div dangerouslySetInnerHTML={{ __html: htmlContent }} />
//    );

registerServiceWorker();
