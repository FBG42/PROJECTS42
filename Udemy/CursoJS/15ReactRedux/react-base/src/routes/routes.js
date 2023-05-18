import React from 'react';
import { Switch } from 'react-router-dom';

import MyRoute from './MyRoute';
import Login from '../pages/Login/login';
import Page404 from '../pages/Page404/page404';

export default function Routes() {
  return (
    <Switch>
      <MyRoute path="/" exact component={Login} />
      <MyRoute path="*" component={Page404} />
    </Switch>
  );
}
