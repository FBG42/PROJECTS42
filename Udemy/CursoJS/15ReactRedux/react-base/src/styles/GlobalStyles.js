import styled, { createGlobalStyle } from 'styled-components';
import * as colors from '../config/colors';
import 'react-toastify/dist/ReactToastify.css';

export default createGlobalStyle`
  * {
    margin: 0;
    padding: 0;
    outline: none;
    box-sizing: border-box;
  }

  body {
    font-family: sans-serif;
    background: ${colors.primaryDarkColor};
    color: ${colors.primaryDarkColor};
  }

  html, body, #root {
    height: 100%;
  }

  button {
    cursor: pointer;
    background: ${colors.primaryColor};
    border: none;
    color: #fff;
    padding: 10px 20px;
    border-radius: 4px;
  }

  a {
    text-decoration: none;
  }

  ul {
    list-style: none;
  }

  body .Toastify__progress-bar--success {
    background: ${colors.successColor};
  }

  body .Toastify__toast--success .Toastify__toast-body .Toastify--animate-icon svg {
    fill: ${colors.successColor};
  }

  body .Toastify__progress-bar--error {
    background: ${colors.errorColor};
  }

    body .Toastify__toast--error .Toastify__toast-body .Toastify--animate-icon svg {
    fill: ${colors.errorColor};
  }
`;

export const Container = styled.section`
  max-width: 360px;
  background: #fff;
  margin: 30px auto;
  padding: 30px;
  border-radius: 4px;
  box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
`;
