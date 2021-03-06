<?php

namespace App\Http\Controllers;

use Illuminate\Support\Facades\Validator;
use Illuminate\Http\Request;
use App\Task;

class TaskController extends Controller
{
/**
 * Display All Tasks
 */
	public function index(){
    
    $tasks = \App\Task::orderBy('created_at', 'asc')->get();

    return view('tasks', [
        'tasks' => $tasks
    ]);
	}
	public function json(){
		return Task::orderBy('created_at','asc')->get();
	}

/**
 * Add A New Task
 */
public function createTask(Request $request){

    $validator = Validator::make($request->all(), [
        'name' => 'required|max:255',
    ]);

    if ($validator->fails()) {
        return redirect('/')
            ->withInput()
            ->withErrors($validator);
    }

    $task = new \App\Task;
    $task->name = $request->name;
    $task->save();

    return redirect('/');

}

/**
 * Delete An Existing Task
 */
public function deleteTask($id){
Task::findOrFail($id)->delete();

    return redirect('/');
	}
}
