# Platform_boy

Git protocols we would be following that i stole from our CS145 capstone repo readme :
 # ~~CS 145 (first take) Project Group 17~~

Please follow these guides for working with other people using git:

http://nvie.com/posts/a-successful-git-branching-model/

https://www.atlassian.com/git/tutorials/merging-vs-rebasing

The short summary of the workflow is:
1. update your local copy of `dev`
2. create a feature branch starting from `dev`, for example, `myfeature`
	- optionally, merge feature branches by other members onto `myfeature`
3. once you are done with feature, DO NOT merge it to `dev`
4. instead, push `myfeature` to the remote repository
5. then open a pull request on github to request merging `myfeature` onto `dev` 
6. wait for someone to approve
7. repeat 1 - 6 until we ~~pass cs145~~ deliver a shippable product.

Please ask me for clarifications regarding our workflow. The whole purpose of 
this very easy process is to make sure that `dev` is clean and easy to follow.
If we ever need to revert a file to what it was before it introduced a bug, 
this workflow will make looking for the stable version very very easy.

A longer description of the workflow:

## Getting Started

After cloning this repository, you should be at the `master` branch.  There
will be a `dev` branch when you clone this repository.  Run `git branch -a`.
You should see something like

```
remotes/origin/dev/
```

Access your local copy of it with `git checkout dev`.

```
Branch experimental set up to track remote branch dev from origin.
Switched to a new branch 'dev'
```

This output is expected. Now you are on the `dev` branch.

## Updating your copy

Before working, update your local copy with `git pull` (this only pulls onto
your current branch, confirm with `git branch` to see where you're at).

Sometimes you might be afraid to do a `git pull`. Maybe you've already started
working and forgot to pull, and  you're worried that it will undo all your
changes. To make absolutely sure that your work is safe, run

```
git branch # check which branch you're working on
git fetch # update your remote copy of this branch
git diff <branch> origin/<branch> # compare local branch with copy of remote
# if you're satisfied, then do
git merge origin/<branch>
```

## Working on a Feature

Before working, decide on what feature you want to work on (ex. arduino code
for manipulating LCD). 

Let everyone know what feature you will be working on to avoid wasted work.

While in `dev`, create a new branch, for example `myfeature` (use a better
name). Until you finish this feature, all of your work must be committed on
`myfeature`. 

## Updating your local repo or reacting to changes by other group members

In the middle of working on `myfeature`, your groupmate makes some changes to a
file that your feature is dependent on. Their request gets approved and now
`dev` contains that change. Since you will merge onto `dev` at the end of your
work, you might want to make sure that `myfeature` still works even with the
recent change to `dev`

There is no easy way to solve this. I think it would be better to just 
submit your pull request as is, and create a small bugfix branch if we run
into any issues.

## Updating everyone on your work

Once you are complete, push this branch to the remote repository.
Go to github and open a pull request. Set

```
base: dev
compare: myfeature
```

then create the pull request. Submit a short description so the other members
can see a summary of what you've been doing. Now wait for someone else to 
approve this change to the `dev` branch.

## Approving a pull request

Anyone can approve a pull request, so long as it isn't the one who wrote the
pull request in the first place. If the pull request is well-formed, orderly, 
and (most importantly) functional, then please approve the pull request right
away. DO NOT delete the branch you merged.

Because of the above conventions, I made the `master` and `dev` branches
protected. That means that you cannot ever push onto the `master` and `dev`
branch. The only way to change `dev` is by creating and merging pull requests.
