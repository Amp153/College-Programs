<?php

use App\Task;
use Illuminate\Http\Request;
use App\Http\Controllers\TaskController;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/


 Route::get('/', 'TaskController@index');


Route::post('/task', 'TaskController@createTask');


Route::delete('/task/{id}', 'TaskController@deleteTask');
Route::get('/task/json','TaskController@json');
Route::get('/app',function(){
	return view('app');
});